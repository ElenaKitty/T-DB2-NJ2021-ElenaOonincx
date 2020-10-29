#include "fifo.h"
#include "unity.h"
#include <stdbool.h>
#include <stdio.h>

// I rather dislike keeping line numbers updated, so I made my own macro to
// ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)


void setUp(void)
{
    // printf("This is run before EACH test.\n");
    initbuffer();
}


void tearDown(void)
{
    // printf("This is run after EACH test.\n");
}


void emptybuffertest(void)
{
    int value = 56734;
    int succes = fiforead(&value);
    TEST_ASSERT_EQUAL(-1, succes);  // lets test if it was really empty
    TEST_ASSERT_EQUAL(56734, value);// and that our vlue has not been touched..
}
void readnulltest()
{

    int succes = fiforead(NULL);
    TEST_ASSERT_EQUAL(-1, succes);// lets test if it was really empty
}
void fiforeadnullnonemptybuffer()
{

    int succes;

    succes = fifowrite(42);
    TEST_ASSERT_EQUAL(0, succes);
    int returnvalue = fiforead(NULL);
    TEST_ASSERT_EQUAL(-1, returnvalue);
}

// testen voor FIFO read
// pre: readvalue not null
// post : function returnvalue:
// 	0 : read succeeded
// 	-1: readvalue null or buffer empty


void fiforeadempty(void)
{
    int val;
    int returnvalue = fiforead(&val);
    TEST_ASSERT_EQUAL(-1, returnvalue);
}

void fifowriteread(void)
{
    // approach : write 1 value and read back
    // write 2 different values and check if they appear in the right order
    int val1 = 15;
    int val2 = 0;
    int succes;
    succes = fifowrite(val1);
    TEST_ASSERT_EQUAL(0, succes);
    succes = fiforead(&val2);
    TEST_ASSERT_EQUAL(0, succes);
    TEST_ASSERT_EQUAL(val1, val2);
}
void writereadalottest(void)
{
    for (int i = 0; i < 1000; i++)
    {
        fifowriteread();
    }
}
void writefulltest(void)
{
    int succes = -1;
    int value = 0;
    for (int i = 0; i < BUFSIZE; i++)
    {
        succes = fifowrite(i);
        TEST_ASSERT_EQUAL(0, succes);
    }


    // at this point the buffer is full, a next write should return full
    succes = fifowrite(567);
    TEST_ASSERT_EQUAL(1, succes);
    // the oldest value should be 1 as we started writing 0,1,2,3,4,5,6,7 etc
    succes = fiforead(&value);
    TEST_ASSERT_EQUAL(0, succes);
    TEST_ASSERT_EQUAL(1, value);
    // we have 1 slot free, so the next write should pass
    succes = fifowrite(678);
    TEST_ASSERT_EQUAL(0, succes);
    // all other writes also should return 1 (because buffer is full)
    for (int i = 0; i < 1000; i++)
    {
        succes = fifowrite(i);
        TEST_ASSERT_EQUAL(1, succes);
    }
}

void sequencetest()
{
    // we write a sequence and then the same sequence must be returned
    // we do this 5 times so also the buffer will wrap around (but not full)
    int succes = -1;
    int value = 0;
    for (int j = 0; j < 5; j++)
    {
        for (int i = 0; i < BUFSIZE; i++)
        {
            succes = fifowrite(i);
            TEST_ASSERT_EQUAL(0, succes);
        }
        for (int i = 0; i < BUFSIZE; i++)
        {
            succes = fiforead(&value);
            TEST_ASSERT_EQUAL(0, succes);
            TEST_ASSERT_EQUAL(i, value);
        }
    }
    // by now the buffer is empty, lets check
    succes = fiforead(&value);
    TEST_ASSERT_EQUAL(-1, succes);
}


int main(int argc, char* argv[])
{
    UnityBegin();
    MY_RUN_TEST(readnulltest);
    MY_RUN_TEST(emptybuffertest);
    MY_RUN_TEST(fifowriteread);
    MY_RUN_TEST(fiforeadnullnonemptybuffer);
    MY_RUN_TEST(writereadalottest);
    MY_RUN_TEST(writefulltest);
    MY_RUN_TEST(sequencetest);

    return UnityEnd();
}
