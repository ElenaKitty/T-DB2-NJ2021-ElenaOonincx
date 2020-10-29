// MMA 7455L Arduino Simulation  (Slave)
// see also https://www.nxp.com/docs/en/data-sheet/MMA7455L.pdf
//
// The X, Y, Z accell. values will equal 0b11111111 (i.e. 255) when MMA is not
// in 2g mode and measurement mode
//
// Only the 8 bit accell registers and the control register are supported by
// this simulation. See the datasheet for the register numbers.


#include <Wire.h>

// forward declarations
void printBitPattern(byte b);

#define CTL_REG 0x16
#define X_REG 0x06
#define Y_REG 0x07
#define Z_REG 0x08


#define NR_OF_REGS 32
byte registers[NR_OF_REGS];
int selectedReg = 0;

void setup()
{
    Wire.begin(0x1D);
    Wire.onReceive(receiveEvent);
    Wire.onRequest(requestEvent);
    Serial.begin(9600);
}

void loop()
{
}

void receiveEvent(int howMany)
{
    if ((registers[CTL_REG] & 0b00001111) == 0b00000101)
    {
        registers[X_REG] = (random(256) & 0b11111100) |
                    0b00000001;// last two bits fixed,
                               // for debugging only
        registers[Y_REG] = (random(256) & 0b11111100) | 0b00000010;
        registers[Z_REG] = (random(256) & 0b11111100) | 0b00000011;
    }
    else
    {
        registers[X_REG] = 0b11111111;
        registers[Y_REG] = 0b11111111;
        registers[Z_REG] = 0b11111111;
    }

    bool firstByte = true;
    while (Wire.available() > 0)
    {
        byte c = Wire.read();
        if (firstByte)
        {
            selectedReg = c;
            firstByte = false;
        }
        else
        {
            registers[selectedReg] = c;
        }
    }

    /*	Serial.print("Selected reg is  ");
   Serial.print(selectedReg);
   Serial.print("  ;content is ");
   printBitPattern(registers[selectedReg]);
   Serial.println("");
    */
}

void requestEvent()
{
    byte data2sent[NR_OF_REGS];
    for (int i = 0; i < NR_OF_REGS; ++i)
    {
        if (selectedReg + i < NR_OF_REGS)
            data2sent[i] = registers[selectedReg + i];
        else
            data2sent[i] = 0;
    }

    Wire.write(data2sent,
               NR_OF_REGS);// always transmit 32 bytes!! Master will read
                           // only the requested number of bytes
}

void printBitPattern(byte b)
{
    byte mask = 0b10000000;
    for (int i = 0; i <= 7; ++i)
    {
        if (b & mask)
            Serial.print('1');
        else
            Serial.print('0');
        mask = mask >> 1;
    }
}
