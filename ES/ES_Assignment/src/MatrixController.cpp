#include "MatrixController.h"
#include <Arduino.h>

#define CLK  8   
#define OE   9
#define LAT 10
#define A   A0
#define B   A1
#define C   A2

RGBmatrixPanel matrix(A, B, C, CLK, LAT, OE, true);


void DrawSans()
{
  uint16_t color = matrix.Color888(0,255,0);
  //forehead
  for(int i = 4; i < 12; i++)
  {
    matrix.drawPixel(2,i,color);
  } 
  for(int i = 2; i < 14; i++)
  {
    matrix.drawPixel(3,i,color);
  } 
  for(int i = 2; i < 14; i++)
  {
    matrix.drawPixel(4,i,color);
  } 
  for(int i = 1; i < 15; i++)
  {
    matrix.drawPixel(5,i,color);
  } 
  //eyes
  for(int i = 1; i < 3; i++)
  {
    matrix.drawPixel(6,i,color);
  } 
  for(int i = 3; i < 6; i++)
  {
    matrix.drawPixel(6,i, matrix.Color888(0,150,255));
    matrix.drawPixel(7,i, matrix.Color888(0,150,255));
    matrix.drawPixel(8,i, matrix.Color888(0,150,255));
  }
  for(int i = 6; i < 9; i++)
  {
    matrix.drawPixel(6,i,color);
  }
  for(int i = 12; i < 15; i++)
  {
    matrix.drawPixel(6,i,color);
  } 
  for(int i = 1; i < 3; i++)
  {
    matrix.drawPixel(7,i,color);
  } 
  for(int i = 6; i < 9; i++)
  {
    matrix.drawPixel(7,i,color);
  }
  for(int i = 12; i < 15; i++)
  {
    matrix.drawPixel(7,i,color);
  } 
  for(int i = 1; i < 3; i++)
  {
    matrix.drawPixel(8,i,color);
  } 
  matrix.drawPixel(8,6,color);
  matrix.drawPixel(8,8,color);
  for(int i = 12; i < 15; i++)
  {
    matrix.drawPixel(8,i,color);
  }
  for(int i = 2; i < 6; i++)
  {
    matrix.drawPixel(9,i,color);
  }
  for(int i = 9; i < 14; i++)
  {
    matrix.drawPixel(9,i,color);
  } 
  //smile
  matrix.drawPixel(10,2,color);
  for(int i = 4; i < 12; i++)
  {
    matrix.drawPixel(10,i,color);
  } 
  matrix.drawPixel(10,13,color);
  for(int i = 1; i < 3; i++)
  {
    matrix.drawPixel(11,i,color);
  }
  for(int i = 13; i < 15; i++)
  {
    matrix.drawPixel(11,i,color);
  }
  for(int i = 1; i < 3; i++)
  {
    matrix.drawPixel(12,i,color);
  }
  matrix.drawPixel(12,4,color);
  matrix.drawPixel(12,6,color);
  matrix.drawPixel(12,8,color);
  matrix.drawPixel(12,10,color);
  for(int i = 12; i < 15; i++)
  {
    matrix.drawPixel(12,i,color);
  }
  //underchin
  for(int i = 2; i < 4; i++)
  {
    matrix.drawPixel(13,i,color);
  }
  for(int i = 11; i < 13; i++)
  {
    matrix.drawPixel(13,i,color);
  }
  for(int i = 4; i < 11; i++)
  {
    matrix.drawPixel(14,i,color);
  }
}