#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include <avr/io.h>

#define INPUT 0
#define OUTPUT 1

void GPIO_Init(volatile uint8_t *device, uint8_t pin, uint8_t direction);
void GPIO_Write(volatile uint8_t *device, uint8_t pin, uint8_t value);
void GPIO_Toggle(volatile uint8_t *device, uint8_t pin);
uint8_t GPIO_Read(volatile uint8_t *device, uint8_t pin);

#endif