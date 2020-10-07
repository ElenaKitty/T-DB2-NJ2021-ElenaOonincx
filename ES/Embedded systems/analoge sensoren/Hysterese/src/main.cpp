#include <Arduino.h>

int potPin = A0;    // select the input pin for the potentiometer
int ledPin = 13;   // select the pin for the LED
int LDRpin = A4;
int val = 0;       // variable to store the value coming from the sensor

void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);  // declare the ledPin as an OUTPUT
}

void loop() {
  val = analogRead(potPin); // read the value from the sensor

  Serial.println(analogRead(potPin));

  if (analogRead(LDRpin) > 50 + val)
  {
    digitalWrite(ledPin, HIGH);
  }
  else if (analogRead(LDRpin)< 80 + val){
    digitalWrite(ledPin, LOW);
  }
}