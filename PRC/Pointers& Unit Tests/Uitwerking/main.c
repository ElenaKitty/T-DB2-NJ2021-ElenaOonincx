#include <stdio.h>
#include <stdlib.h>

int passByValue(int value)
{
    value = value * value * value;
    return value;
}

void passByRefernce(int* pointerValue)
{
    *pointerValue = *pointerValue * *pointerValue * *pointerValue;
}

int main(int argc, char *argv[])
{
    //Oefening 1
    int value = 6;
    printf("The value is now %d\n", value);
    value = passByValue(value);
    printf("The value is now %d\n", value);
    int * pointerValue = &value;
    passByRefernce(pointerValue);
    printf("The value is now %d\n", value);

    //Oefening 2
    
}