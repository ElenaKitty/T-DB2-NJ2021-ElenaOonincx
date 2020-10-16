#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int passByValue(int value)
{
    value = value * value * value;
    return value;
}

void passByRefernce(int *pointerValue)
{
    *pointerValue = *pointerValue * *pointerValue * *pointerValue;
}
void printConstArray(const char *constArray, int arrayLength)
{
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", constArray[i]);
    }
}

int main(int argc, char *argv[])
{
    //Oefening 1
    printf("--------------------------\n");
    printf("Pointer assignment\n");
    printf("--------------------------\n");
    int value = 6;
    printf("The value is now %d\n", value);
    value = passByValue(value);
    printf("The value is now %d\n", value);
    int *pointerValue = &value;
    passByRefernce(pointerValue);
    printf("The value is now %d\n", value);

    //Oefening 2m
    printf("--------------------------\n");
    printf("Capitalize assignment \n");
    printf("--------------------------\n");
    int arrayLength = 25;
    char array[] = {"De hond loopt in het gras"};
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", array[i]);
    }
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = toupper(array[i]);
    }
    printf("\n");
    for (int i = 0; i < arrayLength; i++)
    {
        printf("%c", array[i]);
  
    }
    printf("\n");
    //Oefening 3
    printf("--------------------------\n");
    printf("Constant array assignment\n");
    printf("--------------------------\n");
    printConstArray(array, arrayLength);
    printf("\n");
}