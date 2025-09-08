# AVR 3-LED Control Example

This project demonstrates how to control three LEDs using an AVR microcontroller (such as ATmega328P) with direct bit manipulation.

## Features

- **LED1 (PD2):** Turns ON and stays ON.
- **LED2 (PD5):** Turns ON for 1 second at startup, then stays OFF.
- **LED3 (PD7):** Toggles ON/OFF every 500 ms.

## Hardware Connections

| LED   | AVR Pin |
|-------|---------|
| LED1  | PD2     |
| LED2  | PD5     |
| LED3  | PD7     |

Connect each LED (with appropriate resistors) to the specified PORTD pins.

## How It Works

- The code sets PD2, PD5, and PD7 as output pins.
- LED1 is turned ON and remains ON.
- LED2 is turned ON for 1 second at startup, then turned OFF.
- LED3 toggles its state every 500 ms, creating a blinking effect.

## File Structure

- `main.c` : Source code for LED control logic.
