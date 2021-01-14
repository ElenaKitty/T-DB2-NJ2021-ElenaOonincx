#include <stdio.h>
#include <stdint.h>
#include <string.h>
#include <math.h>
#include "encryption.h"
char string[] = {"de gele kip eet graag zaad"};//works 26
// char string[] = {"ABCDEFGHIJKLMNOPQRSTUVWXYZ"}; //works 26
// char string[] = {"abcdefghijklmnopqrstuvwxyz"}; //works 26
// char string[] = {"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"}; //doesnt work
int arrayLength = sizeof(string);
uint16_t numbers[sizeof(string)];

int main(void)
{
    for (int i = 0; i < arrayLength; i++)
    {
        numbers[i] = string[i];
    }
    //Het principe van de opdracht is om een bepaalde string doormiddel van bitshiften te encrypten
    printf("----------------------------------\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de originele string uit
    }
    printf("\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%d ", numbers[i]); //number waardes voor originele string.
    }
    printf("\n");
    encrypt(arrayLength, numbers, string);
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de nieuwe string uit
    }
    printf("\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%d ", numbers[i]); //number waardes voor nieuwe string.
    }
    printf("\n");
    decrypt(arrayLength, numbers, string);
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de originele string uit
    }
    printf("\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%d ", numbers[i]); //number waardes voor originele string
    }
    printf("\n");
    printf("----------------------------------\n");
}
