#include <Arduino.h>

#define ds_pin 3 // Pin to which the distance sensor is connected
int i = 0;
int total = 0;
int average = 0;

void setup ()
{
  pinMode(ds_pin, INPUT);
  Serial.begin (9600); // Initiates serial communication at 9600 baud
}

void loop ()
{
  if(i < 10)
  {
    int analogValue = analogRead(ds_pin);
    Serial.print("Analoge value: ");
    Serial.println(analogValue);

    Serial.println(i);
    total += analogValue;
  }
  delay(100);

  if(i == 10)
  {
    Serial.print("Total: ");
    Serial.println(total);
    average = total / 10;
    Serial.print("Average: ");
    Serial.println(average);
  }
  i++;
}