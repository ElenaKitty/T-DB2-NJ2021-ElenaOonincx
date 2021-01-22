#include <stdlib.h>
#include <unistd.h>		// for close()

#include "unity.h"

#include "resource_detector.h"
#include "encode.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

extern void setUp(void)
{
    // This is run before EACH test
}

extern void tearDown(void)
{
    // This is run after EACH test
}

void test_encode(void)
{
	
}
void encode_get_nibbles_Test(void)
{
    uint8_t value = 10;
    uint8_t* low = 0;
    uint8_t* high = 0;

    uint8_t* lowExpected = *low = value & 0xF; //00001111 clear left 4 bits
             lowExpected = (*low << 3);
    uint8_t* highExpected = value & 0x78; 

    encode_get_nibbles(value, low, high);

    TEST_ASSERT_EQUAL(lowExpected, low);
    TEST_ASSERT_EQUAL(highExpected, high);
}
int main (int argc, char * argv[])
{
	if (argc > 1)
	{
		fprintf (stderr, "ERROR: '%s': invalid arguments\n", argv[0]);
	}
    UnityBegin();

    MY_RUN_TEST(test_encode);

    return UnityEnd();
}
