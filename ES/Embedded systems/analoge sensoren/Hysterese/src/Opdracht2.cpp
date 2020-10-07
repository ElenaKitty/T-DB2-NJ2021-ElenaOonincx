#include <Arduino.h>

//Define Pins HC-SR04 on Arduino

const int trigPin = 12;
const int echoPin = 13;

//Define variables
long duration;
long distance;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
}

void loop() 
{
    afstand();
}

void afstand()
{
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  duration = pulseIn(echoPin, HIGH);

  distance = duration * 0.034 / 2;

 Serial.println(distance);
}