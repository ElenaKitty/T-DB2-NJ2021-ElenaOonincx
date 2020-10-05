#include <Arduino.h>

int potPin = A0;    // select the input pin for the potentiometer
int ledPin = 5;   // select the pin for the LED
int LDRpin = A1;

void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);  // declare the ledPin as an OUTPUT
  pinMode(LDRpin, INPUT);
}

void loop() 
{
  // Serial.print("LDR value: ");
  // Serial.println(analogRead(LDRpin));
  // Serial.print("Potentio value: ");
  // Serial.println(analogRead(potPin));

  if (analogRead(LDRpin) > 100)
  {
    analogWrite(ledPin, HIGH);
  }
  else if (analogRead(LDRpin) < 10)
  {
    analogWrite(ledPin, LOW);
  }
}