#include <stdio.h>
int main(int argc, char *argv[])
{
    /* define a local variable a */
int a = 1;
char b = 2;

/* define a pointer variable, and point it to a using the & operator */
int * pointer_to_a = &a;
char * pointer_to_b = &b;

printf("The value a is %d\n", a);
printf("The value b is %d\n", b);
printf("The value of a is also %d\n", *pointer_to_a);
printf("The value of b is also %d\n", *pointer_to_b);
}