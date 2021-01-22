#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

#include "decode.h"
#include "io.h"
#include "parity.h"

uint8_t decode_combine_nibbles(uint8_t high, uint8_t low)
{
    uint8_t fullBit = 0;
    fullBit = fullBit | (high & 0x78);
    fullBit = (fullBit << 4); //01111000 shift result 4 to left for first 4 bits
    fullBit = fullBit | (low & 0x78);         //01111000

    return fullBit;
}

void decode_byte(uint8_t in, uint8_t *nibble)
{
    //first check if d0, d1, d2, d3 are > 3
    //if yes check which D should be fixed
    //if no check partition bits > 3
    //if yes fix partition bits based on requirements.
    //if no MSB Bit
    int dNumbers = 0;
    int partNumbers = 0;

    int group0 = 0; //p0 d0 d1 d2 00111001
    int group1 = 0; //p1 d0 d1 d3 01011010
    int group2 = 0; //p2 d1 d2 d3 01110100




    //check if bit is set
    for (int i = 1; i < 8; i++)
    {
        if (i == 1)
        {
            group0 = group0 + 1;
        }
        if (i == 2)
        {
            group1 = group1 + 1;
        }
        if (i == 3)
        {
            group2 = group2 + 1;
        }
        if (i == 4)
        {
            group0 = group0 + 1;
            group1 = group1 + 1;
        }
        if (i == 5)
        {
            group0 = group0 + 1;
            group1 = group1 + 1;
            group2 = group2 + 1;
        }
        if (i == 6)
        {
            group0 = group0 + 1;
            group2 = group2 + 1;
        }
        if (i == 7)
        {
            group1 = group1 + 1;
            group2 = group2 + 1;
        }
        if (i < 4)
        {
            if (in & (1 << i))
            {
                partNumbers = partNumbers + 1;;
            }
        }
        if (in & (1 << i))
        {
            dNumbers = dNumbers + 1;
        }
    }

    //D bits gone wrong
    //check which bit should be fixed according to the partitions
    if (group0 > 3 && group1 > 3)
    {
        //d0
        //00001000
        *nibble = in ^ 0x8;
    }
    else if (group0 > 3 && group1 > 3 && group2 > 3)
    {
        //d1
        //00010000
        *nibble = in ^ 0x10;
    }
    else if (group0 > 3 && group2 > 3)
    {
        //d2
        //00100000
        *nibble = in ^ 0x20;
    }
    else if(group1 >> 3 && group2 > 3)
    {
        //d3
        //01000000
        *nibble = in ^ 0x40;
    }
    //nog ff iets beter naar kijken dalijk.
    else if (partNumbers >= 2)
    {
        //paritions bits should be fixed according to the D bits
        if (group0 > 3)
        {
            *nibble = in ^ 0x1;
        }
        else if (group1 > 3)
        {
            *nibble = in ^ 0x2;
        }
        else if (group2 > 3)
        {
            *nibble = in ^ 0x4;
        }
    }
    else
    {
        //MSB bit should be fixed
        *nibble = in ^ 0x80;
    }
}
