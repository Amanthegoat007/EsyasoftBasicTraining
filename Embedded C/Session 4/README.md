# LCD Interface with AVR Microcontroller

This project demonstrates interfacing a 16x2 LCD display with an AVR microcontroller using 4-bit mode. The code initializes the LCD and displays two lines of text.

## Features

- LCD initialization in 4-bit mode
- Displays "Hello, World!" on the first line
- Displays "LCD Working :)" on the second line
- Continuously scrolls the display left

## Pin Connections

| LCD Pin | AVR Pin | Arduino Pin |
|---------|---------|-------------|
| RS      | PB4     | 12          |
| EN      | PB3     | 11          |
| D4      | PB2     | 10          |
| D5      | PB1     | 9           |
| D6      | PB0     | 8           |
| D7      | PD7     | 7           |

## How It Works

- The LCD is initialized in 4-bit mode.
- Text is sent to the LCD using `lcd_string`.
- The display is scrolled left in an infinite loop.

## Files

- `main.c`: Source code for LCD interfacing
- `.vscode/avr_project.json`: Project configuration

## Usage

1. Connect the LCD to the AVR microcontroller as per the pin mapping above.
2. Build and flash the code to your AVR device.
3. The LCD should display the messages and scroll them left.

