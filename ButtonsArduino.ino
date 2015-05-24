/*
  DigitalReadSerial
 Reads a digital input on pin 2, prints the result to the serial monitor

 This example code is in the public domain.
 */

// digital pin 2 has a pushbutton attached to it. Give it a name:

int buttonPins[4] = { 2, 3 ,4 ,5};
int buttonState = 0;         // 
// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  // make the pushbutton's pin an input:
  for(int i=0; i < 4; i++) {
    pinMode(buttonPins[i],  INPUT);    // button as input
    digitalWrite(buttonPins[i], HIGH); // turns on pull-up re
  }
}

void loop() {
   
  for(int i=0; i < 4; i++) {
    buttonState = digitalRead(buttonPins[i]);
    if ( buttonState == LOW) {
      Serial.write(i);
    }
  }
}
