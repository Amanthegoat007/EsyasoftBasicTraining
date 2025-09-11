# Assignment 5 (Button-Controlled LED)
This project uses a button to toggle an LED on an AVR microcontroller. It is built with a modular structure including a Hardware Abstraction Layer (HAL) for GPIO functions like Init, Write, Toggle, and Read.

## Functionality
The main loop continuously checks the button state. Each press toggles the LED's on/off state. Basic delays are included for debouncing the button

## Tasks
1. hal_gpio.h -> Defines the GPIO functions
2. hal_gpio.c-> Implements the low-level GPIO register manipulation using pointer arithmetic
3. pin_config.h -> Centralizes pin definitions (LED_PIN, BUTTON_PIN)
4. main.c -> Contains the application logic for the button and LED 