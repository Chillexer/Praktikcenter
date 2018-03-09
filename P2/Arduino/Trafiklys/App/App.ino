//    LIGHT PINS:
//   ===============================================
//    | POSITION & TYPE | RED | CAR YELLOW/ PED BLUE | GREEN |
//    | LEFT CAR LIGHT   |  A0   |                    4                     |      5      |
//    | LEFT PED LIGHT   |   6    |                    1                     |      7      |
//    | RIGHT CAR LIGHT |  13   |                   12                    |      11     |
//    | RIGHT PED LIGHT |   9    |                  10                     |      8      |
//   ===============================================
//    BUTTON PINS:
//   ==============
//    | POSITION | PIN |
//    |     LEFT    |   2   |
//    |    RIGHT   |   3   |
//   ==============


const int lights[4][3] = {{A0,4,5},{6,1,7}, {13,12,11}, {9,10,8}};
const int delays[2] = {10000, 2500};

void setup(){
  for(int item = 0; item < 4; item++){
    for(int obj = 0; obj < 3; obj++){
      if(obj == 0)  digitalWrite(lights[item][obj], HIGH);
      pinMode(lights[item][obj], OUTPUT);
    }
  }
  attachInterrupt(digitalPinToInterrupt(2), left_btn_pressed, CHANGE);
  attachInterrupt(digitalPinToInterrupt(3), right_btn_pressed, CHANGE);
}

void loop(){
  turn_green(lights[0], lights[1]);
  turn_red(lights[0], lights[1]);
  turn_green(lights[2], lights[3]);
  turn_red(lights[2], lights[3]);
}

void turn_green(int lights[3], int pedlights[3]){
    digitalWrite(lights[1], HIGH);
    delay(delays[1]);
    if(digitalRead(pedlights[1]) == HIGH){
      digitalWrite(pedlights[0], LOW);
      digitalWrite(pedlights[1], LOW);
      digitalWrite(pedlights[2], HIGH);
    }
    digitalWrite(lights[0], LOW);
    digitalWrite(lights[1], LOW);
    digitalWrite(lights[2], HIGH);
    delay(delays[0]);
}

void turn_red(int lights[3], int pedlights[3]){
    digitalWrite(lights[2], LOW);
    digitalWrite(pedlights[2], LOW);
    digitalWrite(pedlights[0], HIGH);
    digitalWrite(lights[1], HIGH);
    delay(delays[1]);
    digitalWrite(lights[1], LOW);
    digitalWrite(lights[0], HIGH);
    digitalWrite(lights[2], LOW);
}

void left_btn_pressed(){
   digitalWrite(1, HIGH);
}

void right_btn_pressed(){
  digitalWrite(10, HIGH);
}
