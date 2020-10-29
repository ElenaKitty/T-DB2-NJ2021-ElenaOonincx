#ifndef CODESTUFF_H
#define CODESTUFF_H

#include <stdint.h>

#define BUFSIZE 10

// pre: readvalue not null
// post : function returnvalue:
// 	0 : read succeeded
// 	-1: readvalue null or buffer empty

int fiforead(int* value);

//Please define a prototype for the write function taking in to account the following
//-	Return value 0 if element has been added.
//-	Return value 1 if element has been added to the buffer, but the buffer was already full
//-	Return value -1 if the element has not been added.
int fifowrite(int value);
// initializes the buffer
void initbuffer();

#endif
