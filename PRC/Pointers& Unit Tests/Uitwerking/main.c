#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

#define GROOTTE 20

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
void BubbleSort(int *arrayPointer, int arrayLength)
{
    for (int j = 0; j < arrayLength; j++)
    {
        for (int i = 1; i < arrayLength - j; i++)
        {
            if (arrayPointer[i - 1] > arrayPointer[i])
            {
                int temp = arrayPointer[i];
                arrayPointer[i] = arrayPointer[i - 1];
                arrayPointer[i - 1] = temp;
            }
        }
    }
}

size_t getSize(float *ptr)
{
    return sizeof(ptr);
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

    //Oefening 4
    int intArray[] = {10, 6, 2, 14, 9, 3, 5};
    int intArrayLength = 7;
    printf("--------------------------\n");
    printf("Bubble sort Reference assignment\n");
    printf("--------------------------\n");
    for (int i = 0; i < intArrayLength; i++)
    {
        printf("%u", intArray[i]);
    }
    BubbleSort(intArray, intArrayLength);
    for (int i = 0; i < intArrayLength; i++)
    {
        printf("%u", intArray[i]);
    }
    printf("\n");

    //Oefening 5
    // grootte van de pointer geven
    printf("--------------------------\n");
    printf("SizeOf assignment\n");
    printf("--------------------------\n");
    size_t getSize(float *ptr); // prototype
    float floatArray[GROOTTE];  // create array
    printf("Het aantal bytes van deze array is %lu"
           "\nHet aantal bytes met GetSize is %lu\n",
           sizeof(floatArray), getSize(floatArray));

    //Het verschil in de waardes komt door de grootte van de bytes

    //Oefening 6
    printf("--------------------------\n");
    printf("SizeOf datatypes assignment\n");
    printf("--------------------------\n");
    char sChar = 'a';
    unsigned char uChar = 'a';
    int sInt = 5;
    unsigned int uInt = 5;
    short sShort = 3;
    unsigned short uShort = 3;
    long sLong = 9;
    unsigned long uLong = 9;
    float sFloat = 25;
    double sDouble = 6.9;
    long double lDouble = 6.9;
    int sizeArray[20];    // array van 20 int elementen
    int *ptr = sizeArray; // pointer naar

    printf("Char: %ld\n", sizeof(sChar));
    printf("Unsigned char: %ld\n", sizeof(uChar));
    printf("Int: %ld\n", sizeof(sInt));
    printf("Unsigned int: %ld\n", sizeof(uInt));
    printf("Short: %ld\n", sizeof(sShort));
    printf("Unsigned short: %ld\n", sizeof(uShort));
    printf("Long: %ld\n", sizeof(sLong));
    printf("Unsigned long: %ld\n", sizeof(uLong));
    printf("Float: %ld\n", sizeof(sFloat));
    printf("Double: %ld\n", sizeof(sDouble));
    printf("Long double: %ld\n", sizeof(lDouble));
    printf("Array: %ld\n", sizeof(sizeArray));
    printf("Pointer %ld\n", sizeof(ptr));
}