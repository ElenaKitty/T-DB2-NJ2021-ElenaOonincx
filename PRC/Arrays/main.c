#include <stdio.h>
#include <stdlib.h>
//Puts every number to zero in the array.
void ZeroNumber(int * arrayPointer, int arrayLength)
{
    for(int i = 0; i < arrayLength; i = i + 1)
    {
        arrayPointer[i] = 0;
    }
}
//Prints the values of the array
void PrintArray(int * arrayPointer, int arrayLength)
{
    for(int i = 0; i < arrayLength; i = i + 1)
    {
          printf("The value on location %d is %d\n", i, arrayPointer[i]);
    }
}
//Initializes the array
void InitArray(int * arrayPointer, int arrayLength)
{
    for(int i = 0; i < arrayLength; i = i + 1)
    {
        arrayPointer[i] = rand() % 100;
    }
}
//Adds up all the values in the array.
int TotalArray(int * arrayPointer, int arrayLength)
{
    int total = 0;
    for(int i = 0; i < arrayLength; i = i + 1)
    {
        total = total + arrayPointer[i];
    }
    return total;
}

int main(int argc, char *argv[])
{
    int arrayLength = 5;
    int numberArray[5];
    InitArray(numberArray, arrayLength);
    printf("The total value of the numbers in this array are: %d\n", TotalArray(numberArray, arrayLength));
    PrintArray(numberArray, arrayLength);
    ZeroNumber(numberArray, arrayLength);
    PrintArray(numberArray, arrayLength);
}


