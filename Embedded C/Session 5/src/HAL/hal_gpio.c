#include "hal_gpio.h"
#include <util/delay.h>

void GPIO_Init(volatile uint8_t *device, uint8_t pin, uint8_t direction){
    if(direction){
        *device |= (1 << pin);
    }
    else {
        *device &= ~(1 << pin);
        // *(device - 1) |= (1<<pin);
    };
    
}

void GPIO_Write(volatile uint8_t *device, uint8_t pin, uint8_t value){
    volatile uint8_t *device_port = device + 1;
    if(value){
        *device_port |= (1 << pin);
    }
    else *device_port &= ~(1<< pin);
}


void GPIO_Toggle(volatile uint8_t *device, uint8_t pin){
    volatile uint8_t *device_port = device + 1;
    *device_port ^= (1<< pin);
    // _delay_ms(500);

}

uint8_t GPIO_Read(volatile uint8_t *device, uint8_t pin){
    volatile uint8_t *device_pin = device - 1;
    return ((*device_pin) & (1<<pin)? 0 : 1);
}