#include <stdio.h>
#include <stdint.h>
#include <string.h>
char string[] = {"De gele kip eet graag zaad"};
int arrayLength = sizeof(string);
int maxValue = 146;
int minValue = 32;

void encrypt()
{
    //encrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        string[i] >>= 1;
        string[i] = string[i] % maxValue + minValue;
    }
}
void decrypt()
{
    //decrypt doormiddel van bitshift.
    for (int i = 0; i < arrayLength; i++)
    {
        string[i] >>= 1;
        string[i] = (string[i] * maxValue) - maxValue;
    }
}

//probleem: je raakt bits kwijt door bitshiften. zoek manier om dit terug te halen of alternatieve manier

int main(void)
{
    //Het principe van de opdracht is om een bepaalde string doormiddel van bitshiften te encrypten
    printf("----------------------------------\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de originele string uit
    }
    printf("\n");
    encrypt();
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de nieuwe string uit
    }
    printf("\n");
    decrypt();
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", string[i]); //print de originele string uit
    }
    printf("\n");
    printf("----------------------------------\n");
}