#include <stdio.h>
#include <stdlib.h>

#include "encode.h"
#include "io.h"
#include "parity.h"

void encode_get_nibbles(uint8_t value, uint8_t* low, uint8_t* high)
{
    *low = value & 0xF; //00001111 clear left 4 bits
    *low = (*low << 3);


    *high = value & 0x78; //01111000 clear right 4 bits

}

void encode_value(uint8_t value, uint8_t* high, uint8_t* low)
{
    //parity bits
    //p0 = d0 + d1 + d2
    //p1 = d0 + d1 + d3
    //p2 = d1 + d2 + d3
    *low = value & 0xF; //00001111 clear left 4 bits
    *low = (*low << 3);
    uint8_t lowP0 = (*low & 8) + (*low & 16) + (*low & 32);
    uint8_t lowP1 = (*low & 8) + (*low & 16) + (*low & 64);
    uint8_t lowP2 = (*low & 16) + (*low & 32) + (*low & 64);
    uint8_t lowP = lowP0 | lowP1 | lowP2;
    *low = *low | lowP;


    *high = value & 0x78; //01110000 clear right 4 bits
    uint8_t highP0 = (*high & 8) + (*high & 16) + (*high & 32);
    uint8_t highP1 = (*high & 8) + (*high & 16) + (*high & 64);
    uint8_t highP2 = (*high & 16) + (*high & 32) + (*high & 64);
    uint8_t highP = highP0 | highP1 | highP2;
    *high = *high | highP;

}
