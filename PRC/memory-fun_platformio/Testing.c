#include <stdio.h>
void metricToImperial(int lengthInCm, int* feet, int* remainingInches)
{
    *feet = lengthInCm / 30.48;
    *remainingInches = (lengthInCm - *feet * 30.48) / 2.54;
}
void swapValues(int* value1, int* value2)
{
    int temp = *value1;
    *value1 = *value2;
    *value2 = temp; 
}

int main(int argc, char *argv[])
{

    //memory fun
    int a = 1;
    char b = 2;
    int * pointer_to_a = &a;
    char * pointer_to_b = &b;

    printf("The value a is %d\n", a);
    printf("The value b is %d\n", b);
    printf("The value of a is also %d\n", *pointer_to_a);
    printf("The value of b is also %d\n", *pointer_to_b);

    //assignment 2.2 change a pointer value
    int number = 0;
    int * writePointer = &number;
    int * readPointer = &number;

    printf("number before write is %d\n", *readPointer);
    *writePointer = 10; 
    printf("number after write is %d\n", *readPointer);

    int lengthInCm = 163;
    int feet = 0;
    int remmainingInches = 0;
    int * feetPointer = &feet;
    int * inchPointer = &remmainingInches;

    //assignment 2.3 Metric to Imperial conversion
    metricToImperial(lengthInCm, feetPointer, inchPointer);
    printf("Length in cm: %d --> Feet: %d Inches: %d\n", lengthInCm, feet, remmainingInches);


    //assignment 2.4 Value swap
    int value1 = 30;
    int value2 = 69;
    int* pointerValue1 = &value1;
    int* pointerValue2 = &value2;
    printf("Value1: %d  and Value2: %d\n", value1, value2);
    swapValues(pointerValue1, pointerValue2);
    printf("Value1: %d  and Value2: %d\n", value1, value2);
}
