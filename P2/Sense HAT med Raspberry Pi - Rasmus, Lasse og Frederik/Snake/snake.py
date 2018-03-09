#importing libs
import math
import time
import threading
from random import randint
from sense_hat import SenseHat
from flask import Flask, request, send_from_directory
#setting up web server
app = Flask(__name__, static_folder="public")

sense = SenseHat()

#initalize snake variables
food = [[0,2]]
snake = [[0,0], [1,1], [2,2]]
snake_speed = [1,0]
game_size = [8, 8]
paused = True

#will start the game loop
def start():
    update();

#will call it self on a new thread and up the game
def update():
    threading.Timer(0.20, update).start()
    if not paused:
        place_food(10)
        move()
        check_collision();
        sense.clear([0,0,0])
        draw_array(food, [255,0,0])
        draw_array(snake, [0,255,0])

#a small chance og spawning food at a random location
def place_food(chance):
    if (randint(0, 100) < chance):
        food.append([randint(0,game_size[0] - 1), randint(0,game_size[1] - 1)])

#will set the speed if the input is a new way
def set_speed(x, y):
    if abs(x) == abs(snake_speed[1]) and abs(y) == abs(snake_speed[0]):
        snake_speed[0] = x
        snake_speed[1] = y

#called each frame og will move the head and all the parts of the snake
def move():
    for body_part in range(len(snake) - 1, 0, -1):
        snake[body_part][0] = snake[body_part - 1][0]
        snake[body_part][1] = snake[body_part - 1][1]
    snake[0][0] += snake_speed[0]
    snake[0][1] += snake_speed[1]

#checks if the snake goes outside the map, hits itself or finds food.
def check_collision():
    if check_border(snake[0]) or collision(snake[0], snake[1:]):
        reset()
    else:
        item = collision(snake[0], food)
        if item:
            snake.append([snake[0][0], snake[0][1]])
            food.remove(item)

#resets the snake and food variables
def reset():
    snake.clear()
    snake.append([1,1])
    food.clear()
    snake_speed[0] = 0
    snake_speed[1] = 1

#take a vector and an array of vectors and checks if the single vector overlaps any in the array.
def collision(obj, arr):
    for item in arr:
        if obj[0] == item[0] and obj[1] == item[1]:
            return item
    return False

#checks if the paremeter head is putside the game.
def check_border(head):
    if head[0] >= game_size[0] or head[1] >= game_size[1] or head[0] < 0 or head[1] < 0:
        return True
    return False

#Draws all vectors in an array to the sense with the color paremter
def draw_array(arr, color):
    for pos in arr:
        sense.set_pixel(pos[0], pos[1], color)

#sets up a callback to call set_speed acording to the input
sense.stick.direction_up = lambda event: set_speed(event, 0, -1)
sense.stick.direction_down = lambda event: set_speed(event, 0, 1)
sense.stick.direction_left = lambda event: set_speed(event, -1, 0)
sense.stick.direction_right = lambda event: set_speed(event, 1, 0)

#starts the game
start()

#Routes

#default route
@app.route("/")
def main():
    return send_from_directory(app.static_folder ,"index.html")

#static route for files
@app.route("/static/<path:filename>")
def send_public(filename):
    print(filename)
    return send_from_directory(app.static_folder, filename)

#api route for posting new keypress
@app.route('/api/move', methods=['POST'])
def set_move():
    global paused
    content = request.get_json(silent=True)
    key = content["key"]
    print(key)

    if key == "ArrowUp": set_speed(0, -1)
    elif key == "ArrowRight": set_speed(1, 0)
    elif key == "ArrowDown": set_speed(0, 1)
    elif key == "ArrowLeft": set_speed(-1, 0)
    elif key == "Enter": paused = not paused

    return "Succes"

#starts web server
if __name__ == "__main__":
    app.run(port="5000", host='0.0.0.0')




