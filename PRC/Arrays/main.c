#include <stdio.h>
#include <stdlib.h>
#include<time.h>
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
//Prints the values of the array
void PrintArrayIncrem(int * arrayPointer, int arrayLength)
{
    for(int i = 0; i < arrayLength; i = i + 1)
    {
          printf("The value on location %d is %d\n", i+1, arrayPointer[i]);
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
//Give a random number based on the maximum number.
int randomNumber(int numberCap)
{
    int rnd = (rand() % numberCap);
    return rnd;
}

//Loop through a certain ammount and then add 1 to that array index.
void LoopAddIndex(int * arrayPointer, int arrayLength, int ammount, int maxNumber)
{
    for(int i = 0; i < ammount; i++)
    {
        int number = randomNumber(maxNumber);
        arrayPointer[number] = arrayPointer[number] + 1;
    }
}
 void BubbleSort(int * arrayPointer, int arrayLength) 
 {
    for (int j = 0; j < arrayLength; j++) 
    {
       for (int i = 1; i < arrayLength - j; i++) 
       {
          if(arrayPointer[i-1] > arrayPointer[i]) 
          {
             int temp = arrayPointer[i];
             arrayPointer[i] = arrayPointer[i-1];
             arrayPointer[i-1] = temp;
          }
       }
    }
 }

int main(int argc, char *argv[])
{
    srand(time(0));
    int arrayLength = 5;
    int worstArrayLength = 10;
    int diceArrayLength = 6;
    int numberArray[5];
    int worstArray[10];
    int diceArray[6];

    //assignment 2 and 3
    InitArray(numberArray, arrayLength);
    printf("The total value of the numbers in this array are: %d\n", TotalArray(numberArray, arrayLength));
    PrintArray(numberArray, arrayLength);

    //Assignment 1
    ZeroNumber(numberArray, arrayLength);
    PrintArray(numberArray, arrayLength);

    //Assignment 4 
    ZeroNumber(worstArray, worstArrayLength);
    printf("voting started... \n");
    LoopAddIndex(worstArray, worstArrayLength, 40, 10);
    PrintArrayIncrem(worstArray, worstArrayLength);

    //Assignment 5
    printf("Throwing 120.000.000 times the dice... \n");
    LoopAddIndex(diceArray, diceArrayLength,120000000, 6);
    PrintArrayIncrem(diceArray, diceArrayLength);

    //Assignment 6
    BubbleSort(worstArray, worstArrayLength);
    PrintArray(worstArray, worstArrayLength);

    //Assignment 7
    
}


