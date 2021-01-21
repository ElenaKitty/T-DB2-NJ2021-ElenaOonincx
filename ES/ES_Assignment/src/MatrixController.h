#ifndef MATRIXCONTROLLER_H
#define MATRIXCONTROLLER_H

#include <RGBmatrixPanel.h>
#include <Adafruit_I2CDevice.h>
#include <Adafruit_SPIDevice.h>
extern RGBmatrixPanel matrix;

void DrawSans();
void StopLights();
void test();
void StopSign();

void DrawLine(int xValue, int beginPoint, int endPoint);

#endif