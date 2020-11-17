#include <stdio.h>
#include <stdint.h>
#include <string.h>
#include <math.h>
char string[] = {"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"};
int arrayLength = sizeof(string);
int numbers[sizeof(string)];

void encrypt()
{
    //encrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        numbers[i] = string[i];
        if(string[i] % 2 == 0)
        {
            string[i] >>= 1; //delen door 2
            numbers[i] = string[i];
        }
        else
        {
            numbers[i] = numbers[i] / 2 + 1;
        }
        string[i] = numbers[i];
    }
}
void decrypt()
{
    //decrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            string[i] <<= 1; //vermenigvuldigen met 2
            numbers[i] = string[i];
        }
        else
        {
            numbers[i] = numbers[i] * 2 -1;
        }
        string[i] = numbers[i];
    }
}

//probleem: je raakt bits kwijt door bitshiften. zoek manier om dit terug te halen of alternatieve manier

int main(void)
{
    for (int i = 0; i < arrayLength; i++)
    {
        numbers[i] = string[i];
    }
    printf("\n");
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
    encrypt();
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
    decrypt();
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