#include <stdio.h>
#include <stdint.h>

#define BitVal(data,y) ( (data>>y) & 1)      /** Return Data.Y value   **/
#define SetBit(data,y)    data |= (1 << y)    /** Set Data.Y   to 1    **/
#define ClearBit(data,y)  data &= ~(1 << y)   /** Clear Data.Y to 0    **/
#define TogleBit(data,y)     (data ^=BitVal(y))     /** Togle Data.Y  value  **/
#define Togle(data)   (data =~data )         /** Togle Data value     **/


void binairPrintf8Bits(int8_t v)
{
    unsigned int masker=1<<((sizeof(int8_t)<<3)-1);
    while(masker) {
        printf("%d", (v&masker ? 1 : 0));
        masker >>= 1;
    }
}

int main(void) {
int8_t getal = 0x05; //0b00000101
printf("Originele waarde: ");
binairPrintf8Bits(getal);

int8_t bit_2 = BitVal(getal,2); // bit_2 = 1
printf("\nWaarde van bit 2: ");
printf("%d", bit_2);

int8_t bit_1 = BitVal(getal,1); // bit_1 = 0
printf("\nWaarde van bit 1: ");
printf("%d", bit_1);

SetBit(getal,1); // getal =  0x07 => 0b00000111
printf("\nZet de waarde van bit 1 op 1: ");
binairPrintf8Bits(getal);

ClearBit(getal,2); // getal =0x03 => 0b0000011
printf("\nZet de waarde van bit 2 op 0: ");
binairPrintf8Bits(getal);




}