#include "fifo.h"
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


int head = 0;
int tail = 0;
int buffer[BUFSIZE];

void initbuffer()
{
}


int fiforead(int* value)
{
    return -1;
}


int fifowrite(int value)
{
    return -1;
}
