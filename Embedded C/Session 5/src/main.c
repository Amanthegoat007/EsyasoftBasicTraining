#include "hal/hal_gpio.h"
#include "../config/led_config.h"
#include <util/delay.h>

int main(void){
    GPIO_Init(LED, LED_PIN, OUTPUT);
    GPIO_Init(BUTTON, BUTTON_PIN, INPUT);

    *(BUTTON - 1) |= (1 << BUTTON_PIN);
    uint8_t led_state = 0;

    while(1){
        if(GPIO_Read(BUTTON, BUTTON_PIN) && !led_state){
            led_state = !led_state;
            GPIO_Write(LED, LED_PIN, 1);
            _delay_ms(400);
        }
        if(GPIO_Read(BUTTON, BUTTON_PIN) && led_state){
            GPIO_Write(LED,LED_PIN,0);
            led_state = !led_state;
            _delay_ms(200);
        }
        // _delay_ms(100);
    }
}
