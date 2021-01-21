#include <Arduino.h>
#include "MatrixController.h"
//Assignment:
/*
Make an arduino setup that checks if somebody walks through the sensor.
If they walk through the sensor activate the matrix and make the color RED.
While the matrix goes RED let the speaker beep for a minute long.
after the minute has passed turn off everything and return to the normal state
*/
int sensorPinTrig = 13;
int sensorPinEcho = 12;
int speakerPin = 11;
enum state
{
  neutral,
  detected,
  alarmed
};
state status;
void setup()
{
  pinMode(sensorPinTrig, OUTPUT);
  pinMode(sensorPinEcho, INPUT);
  pinMode(speakerPin, OUTPUT);
  matrix.begin();
  status = neutral;
}
int calculateDistance()
{
  int travelTime = pulseIn(sensorPinEcho, HIGH);
  int distance = travelTime / (343 / 10000); //deel snelheid door 10000 voor milliseconden.

  return distance;
}

void loop()
{
  digitalWrite(sensorPinTrig, LOW);
  delayMicroseconds(2);
  digitalWrite(sensorPinTrig, HIGH);
  delayMicroseconds(10);
  digitalWrite(sensorPinTrig, LOW);

  if(calculateDistance() < 90)
  {
    status = detected;
  }
  switch (status)
  {
  case neutral:
    matrix.fillScreen(0);
    noTone(speakerPin);
    break;
  case detected:
    status = alarmed;
    matrix.fillScreen(matrix.Color888(255, 0 , 0));
    break;
  case alarmed:
    for(int i = 0; i < 60; i++)
    {
      tone(speakerPin, 100, 1);
      noTone(speakerPin);
    }
    status = neutral;
    break;
  }
}