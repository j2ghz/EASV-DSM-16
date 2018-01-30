import RPi.GPIO as GPIO
from random import randint
from time import sleep
GPIO.setmode(GPIO.BCM)

LU = 5
LM = 6
LL = 13
M = 26
RU = 16
RM = 20
RL = 21

GPIO.setup(LU, GPIO.OUT)
GPIO.setup(LM, GPIO.OUT)
GPIO.setup(LL, GPIO.OUT)
GPIO.setup(M, GPIO.OUT)
GPIO.setup(RU, GPIO.OUT)
GPIO.setup(RM, GPIO.OUT)
GPIO.setup(RL, GPIO.OUT)

def on(pin):
    print("ON "+ str(pin))
    GPIO.output(pin,True)

def offAll():
    for pin in {LU, LM, LL, M, RU, RM, RL}:
        GPIO.output(pin, False)

def show(n):
    offAll()
    if n != 1:
        on(LU)
        on(RL)
    if n == 6:
        on(LM)
        on(RM)
    if (n == 6) or (n == 5) or (n == 4):
        on(LL)
        on(RU)
    if (n == 1) or (n == 3) or (n == 5):
        on(M)

while True:
    show(randint(1, 6))
    sleep(1)