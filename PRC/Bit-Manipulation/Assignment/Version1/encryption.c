#include "encryption.h"
void encrypt(int arrayLength, uint16_t numbers[], char string[])
{
    //encrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        if (numbers[i] != 0)
        {
            numbers[i] = (numbers[i] >> 1);
        }
    }
}
void decrypt(int arrayLength, uint16_t numbers[], char string[])
{
    //decrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        if (numbers[i] != 0)
        {     
            numbers[i] = ((numbers[i]) << 1);
            if(numbers[i] != string[i])
            {
                numbers[i] += 1;
            }
            string[i] = numbers[i];
        }
    }
}
