#include <avr/io.h>
#include <util/delay.h>
#include <stdio.h>
#include "uart.h"

#define BLINK_DELAY_MS 500

int main1(void) {

    uart_init();
    stdout = &uart_output;
    stdin  = &uart_input;

    char input;

    while(1) {
        puts("Hello world!");
        input = getchar();
        printf("You wrote %c\n", input);
    }

    return 0;
}

int main(void)
{
  uart_init();
  stdout = &uart_output;
  stdin  = &uart_input;

  puts("Enter world!");
 /* set pin 5 of PORTB for output*/
 DDRB |= _BV(DDB5);

 while(1) {
  /* set pin 5 high to turn led on */
  PORTB |= _BV(PORTB5);
  puts("ON!");
  _delay_ms(BLINK_DELAY_MS);

  /* set pin 5 low to turn led off */
  PORTB &= ~_BV(PORTB5);
  puts("OFF!");
  _delay_ms(BLINK_DELAY_MS);
 }
}
