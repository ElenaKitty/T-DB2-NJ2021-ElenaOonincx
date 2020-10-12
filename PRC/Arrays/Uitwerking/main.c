#include <stdio.h>
#include <stdlib.h>
#include <time.h>
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
void CountIndex(int * arrayPointer, int arrayLength, int ammount, int maxNumber)
{
    for(int i = 0; i < ammount; i++)
    {
        int number = randomNumber(maxNumber);
        arrayPointer[number] = arrayPointer[number] + 1;
    }
}
//standard bubble sort
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

double CalculateAverage(int * arrayPointer, int arrayLength)
{
    int total = TotalArray(arrayPointer, arrayLength);
    int average = total / arrayLength;
    return average;
}
double CalculateMiddle(int *arrayPointer, int arrayLength)
{
    int middleNumber = 0;
    BubbleSort(arrayPointer, arrayLength);
    int min = arrayPointer[0];
    int max = arrayPointer[arrayLength-1];

    middleNumber = min + (max-min) / 2;
    return middleNumber;
}
int CalculateModus(int * arrayPointer, int arrayLength)
{
    int modus = 0;
    BubbleSort(arrayPointer, arrayLength);
    for(int i = 0; i < arrayLength; i++)
    {
        if(arrayPointer[i] > modus)
        {
            modus = arrayPointer[i];
        }
    }
    return modus;
}
int LinearSearch(int * arrayPointer, int arrayLength, int numberToFind)
{
    for(int i = 0; i < arrayLength;i++)
    {
        if(numberToFind == arrayPointer[i])
        {
            return arrayPointer[i];
        }
    }
    return -1;
}
int BinairySearch(int * arrayPointer, int arrayLength, int numberToFind)
{
    int locationBinairy = 0;
    int maximum = 100;
    int minimum = 0;
    for(int i =0; i < arrayLength; i++)
    {
        int randomNumber = (rand() % maximum - minimum + 1) + minimum;
        if(numberToFind == randomNumber)
        {
            locationBinairy = i;
        }
        else if(numberToFind > randomNumber)
        {
            minimum = arrayPointer[i] - 1;
        }
        else if(numberToFind < randomNumber)
        {
            maximum = arrayPointer[i] + 1;
        }  
    }
    return arrayPointer[locationBinairy];
}

int main(int argc, char *argv[])
{
    srand(time(0));
    int arrayLength = 5;
    int worstArrayLength = 10;
    int diceArrayLength = 6;
    int searchArrayLength = 10;
    int numberArray[5];
    int worstArray[10];
    int diceArray[6]; 
    int searchArray[10];


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
    CountIndex(worstArray, worstArrayLength, 40, 10);
    PrintArrayIncrem(worstArray, worstArrayLength);

    //Assignment 5
    printf("Throwing 120.000.000 times the dice... \n");
    CountIndex(diceArray, diceArrayLength,120000000, 6);
    PrintArrayIncrem(diceArray, diceArrayLength);

    //Assignment 6
    BubbleSort(worstArray, worstArrayLength);
    PrintArray(worstArray, worstArrayLength);

    //Assignment 7
    InitArray(numberArray, arrayLength);
    printf("The average number is %g\n", CalculateAverage(numberArray, arrayLength));
    printf("The middle number is %g\n", CalculateMiddle(numberArray, arrayLength));
    printf("The modus is %d\n", CalculateModus(worstArray, worstArrayLength));

    //Assignment 8
    InitArray(searchArray, searchArrayLength);
    int location = LinearSearch(searchArray, searchArrayLength, searchArray[rand() % 10]);
    if(location == -1)
    {
        printf("The random number was not found in this sequence.\n");
    }
    else
    {
        printf("The random number was found at location %d\n", location);
    }

    //Assignment 9
    InitArray(searchArray, searchArrayLength);
    BubbleSort(searchArray, searchArrayLength);
    int locationBinairy = BinairySearch(searchArray, searchArrayLength, searchArray[rand() % 10]);
    if(location == -1)
    {
        printf("The random number was not found in this sequence.\n");
    }
    else
    {
        printf("The random number was found at location %d\n", locationBinairy);
    }
}


