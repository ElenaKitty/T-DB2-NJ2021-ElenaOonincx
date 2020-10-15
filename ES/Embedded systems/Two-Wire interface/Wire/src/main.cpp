#include <Arduino.h>
#include <Wire.h>

void setup()
{
  Serial.begin(115200);
  Wire.begin(); // join i2c bus (address optional for master)
}

byte x = 90;

void loop()
{
  Wire.beginTransmission(42); // transmit to device #4
  Wire.write("x is ");        // sends five bytes
  Wire.write(x);              // sends one byte 
  Wire.endTransmission();    // stop transmitting

  Wire.requestFrom(42, 1);
  Serial.print("The number value is: ");
  Serial.println(x);
  while(Wire.available())
  {
    char c = Wire.read();
    Serial.print("The returned value is: ");
    Serial.println(c);
  }

  x++;
  delay(1000);
}
