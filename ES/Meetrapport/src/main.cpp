#include <Arduino.h>

int sensorPinTrig = 12;
int sensorPinEcho = 13;

int i = 0;
float maximumTime = 0;
float minimumTime = 99999;
float totalTravelTime = 0;
float totalDistance = 0;

void setup()
{
    Serial.begin(9600);
    pinMode(sensorPinTrig, OUTPUT);
    pinMode(sensorPinEcho, INPUT);
}

void loop()
{
    if (i < 100 && i > -1)
    {
        digitalWrite(sensorPinTrig, LOW);
        delayMicroseconds(2);
        digitalWrite(sensorPinTrig, HIGH);
        delayMicroseconds(10);
        digitalWrite(sensorPinTrig, LOW);

        float travelTime = pulseIn(sensorPinEcho, HIGH);
        totalTravelTime = totalTravelTime + travelTime;
        if (travelTime != 0)
        {
            if(travelTime < minimumTime)
            {
                minimumTime = travelTime;
            }
            if(travelTime > maximumTime)
            {
                maximumTime = travelTime;
            }
            Serial.print("TravelTime: ");
            Serial.println(travelTime);
            int distance = travelTime / 60;
            totalDistance = totalDistance + distance;
            Serial.print("Distance: ");
            Serial.print(distance);
            Serial.println(" cm");
        }
        delay(100);
    }
    i++;
    if(i == 100)
    {
        float averageTime = totalTravelTime / 100;
        Serial.print("AverageTime: ");
        Serial.println(averageTime);
        float averageDistance = totalDistance / 100;
        Serial.print("AverageDistance: ");
        Serial.println(averageDistance);
        Serial.print("MaximumTime: ");
        Serial.println(maximumTime);
        Serial.print("MinimumTime: ");
        Serial.println(minimumTime);
        i = 100;
    }
   
}