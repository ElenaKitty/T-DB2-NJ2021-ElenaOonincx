#include <Arduino.h>
#include <Wire.h>
byte x = 0;
void requestEvent()
{
  if (x > 100)
  {
    Wire.write("2");
    Serial.println(2);
  }
  else
  {
    Wire.write("4");
    Serial.println(4);
  }
}

void receiveEvent(int howMany)
{
  while (1 < Wire.available()) // loop through all but the last
  {
    char c = Wire.read(); // receive byte as a character
    Serial.print(c);      // print the character
  }
  x = Wire.read();   // receive byte as an integer
  Serial.println(x); // print the integer
}

void setup()
{
  Wire.begin(42);               // join i2c bus with address #4
  Wire.onReceive(receiveEvent); // register event
  Wire.onRequest(requestEvent);
  Serial.begin(115200); // start serial for output
}

void loop()
{
  delay(100);
}
