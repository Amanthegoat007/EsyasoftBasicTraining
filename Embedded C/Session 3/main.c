/*
 * Program to control 3 LEDs using AVR microcontroller.
 * 
 * LED1 (PD2): Turns ON and stays ON.
 * LED2 (PD5): Turns ON for 1 second at startup, then stays OFF.
 * LED3 (PD7): Toggles ON/OFF every 500 ms.
 *
 * Connections:
 *   - LED1 to pin PD2
 *   - LED2 to pin PD5
 *   - LED3 to pin PD7
 */

#include <avr/io.h>
#include <util/delay.h>

// Define LED pin numbers
#define led1 PD2  // LED1 connected to PD2
#define led2 PD5  // LED2 connected to PD5
#define led3 PD7  // LED3 connected to PD7

int main(void){
    // Set PD2, PD5, and PD7 as output pins
    DDRD |= (1<<led1);
    DDRD |= (1<<led2);
    DDRD |= (1<<led3);

    // Turn ON LED1 (PD2)
    PORTD |= (1<<led1);

    // Turn ON LED2 (PD5) for 1 second, then turn OFF
    PORTD |= (1<<led2);
    _delay_ms(1000);
    PORTD &= ~(1<<led2);

    while(1){
        // Toggle LED3 (PD7) ON/OFF every 500 ms
        PORTD ^= (1<<led3);
        _delay_ms(500);
    }
}

/*
 * Second Approach Using Flag for the First Time Toggling
 *
 * This code demonstrates controlling three LEDs connected to PD2, PD5, and PD7 of an AVR microcontroller.
 * - LED1 (PD2): Remains ON.
 * - LED2 (PD5): Turns ON for 1 second only once at startup, then stays OFF.
 * - LED3 (PD7): Toggles ON/OFF every 500 ms.
 *
 * The 'flag' variable ensures LED2 is ON for only the first cycle.
 *
 * Why Bit Manipulation is Preferred:
 * - **Efficiency:** Directly accesses and modifies specific bits, resulting in faster execution.
 * - **Low Memory Usage:** No extra variables or overhead; only the required bits are changed.
 * - **Hardware Control:** Essential for microcontroller programming, where each bit often controls a hardware pin.
 * - **Atomic Operations:** Reduces risk of unintended changes to other bits in the register.
 */

// #include <avr/io.h>
// #include <util/delay.h>

// #define led1 PD2  // LED1 connected to PD2
// #define led2 PD5  // LED2 connected to PD5
// #define led3 PD7  // LED3 connected to PD7

// int main(void){
//     DDRD |= (1<<led1); // Set PD2 as output
//     DDRD |= (1<<led2); // Set PD5 as output
//     DDRD |= (1<<led3); // Set PD7 as output
//     int flag = 1;      // Used to turn ON LED2 only once
//     while(1){
//         PORTD |= (1<<led1); // LED1 ON
//         if(flag){
//             PORTD |= (1<<led2); // LED2 ON
//             _delay_ms(1000);    // Wait 1 second
//             flag = 0;           // Ensure this block runs only once
//         }
//         PORTD &= ~(1<<led2);    // LED2 OFF
//         PORTD ^= (1<<led3);     // Toggle LED3
//         _delay_ms(500);         // Wait 500 ms
//     }
// }