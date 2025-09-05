# Session 2

This session demonstrates how to control an LED using a push button(with a twist of Keeping it blinking while keeping the button ON) on an Arduino Uno (Rev-3).

## Files

- `test.c`: Embedded C code for blinking an LED when the button is pressed.
- `diagram.json`: Circuit diagram showing connections between Arduino Uno, LED, and push button.

## How it works

- The LED (connected to pin 8) turns ON and OFF with a 250ms delay when the button (connected to pin 1) is pressed.
- When the button is not pressed, the LED remains OFF.

## Circuit

Refer to `diagram.json` for the wiring:
- LED anode → Arduino pin 8
- LED cathode → Arduino GND
- Push button → Arduino pin 1 and GND

## Author

AMAN PRATAP SINGH