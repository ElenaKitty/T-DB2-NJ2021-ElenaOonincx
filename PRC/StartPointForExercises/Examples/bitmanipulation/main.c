#include <stdint.h>
#include <stdlib.h>
#include <stdio.h>


// each byte has two nibbles
// bit nr 
// 7 6 5 4 3 2 1 0
// 0 0 0 1 0 0 0 0 
// nibble high (bits 7-4) = 0b0001 = 0x1
// nibble low (bits 3-0) = 0b0000 = 0x0
// byte = nibble high-nibble low = 0x10
#define MASK 0x10  

// method is needed as there is no standard way to print binary format...
// for you: study this code and explain how it works.
void print_bin(uint8_t  var)
{
    for (int i = 7 ;i>=0 ; i--)
	{
        putchar('0' + ((var >> i) & 1)); /* loop through and print the bits */
    }
	printf("\n");
}
// & = bitwise and
// | = bitwise or
// ^ = bitwise xor
// ~ = bitwise negate
// << = bit shift left
// >> = bit shift right

// inouts|  outputs
// A | B | & | | | ^ |
// -------------------
// 0 | 0 | 0 | 0 | 0 |
// 0 | 1 | 0 | 1 | 1 |
// 1 | 0 | 0 | 1 | 1 |
// 1 | 1 | 1 | 1 | 0 |
// 
// 1 << 2, shifts bit 2 to the right : outcome = 0x00000100 (4 decimal)
// 0x11001001 >> 3 : outcome = 0x00011001

int main (int argc, char * argv[])
{
	uint8_t varA = 0;
	uint8_t varB = 0xFF;


	// what does this do??
	varA = varA & MASK;
	varB = varB & MASK;
	print_bin(varA);
	print_bin(varB);
	varA = 0;
 	varB = 0xFF;
	// whats the value of A and B here?
	
	
	// what does this do??
	varA = varA && MASK;
	varB = varB && MASK;
	print_bin(varA);
	print_bin(varB);
	// whats the value of A and B here? same or different from above  poll
	
	
	varA = 0;
 	varB = 0xFF;
	varA = varA | MASK;
	varB = varB | MASK;
	print_bin(varA);
	print_bin(varB);
	
	
	
	varA = 0;
 	varB = 0xFF;
	varA = varA ^ MASK;
	varB = varB ^ MASK;
	print_bin(varA);
	print_bin(varB);
	
	varA = ~MASK;
	print_bin(varA);
	print_bin(varB);

	// how to set a bit. e.g. 6, is this correct? poll
	varA = 0xE8;
	print_bin(varA);
	varA = 1<<6;
	print_bin(varA);






















	// better not to touch the other bits
	varA = 0xE8;
	print_bin(varA);
	varA = varA & ~(1<<6); // what is going on here?
	print_bin(varA);
	// again
	varA = 0xE8;
	print_bin(varA);
	print_bin(1<<6);
	print_bin(~(1<<6));
	varA = varA & ~(1<<6); // what is going on here?
	print_bin(varA);

	// excersize : 
	// set bit 4 of varA
	// clear bit 6 of varA
	// flip bit 3 of varA (if it was 1 make it 0, if it was 0 make it 1)
	// AND do not touch other bits while you perform the operations!


}
