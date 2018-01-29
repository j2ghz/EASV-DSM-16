import time
import RPi.GPIO as GPIO
RED = 5
GREEN = 6
BLUE = 13
GPIO.setmode(GPIO.BCM)
GPIO.setup(RED, GPIO.OUT)
GPIO.setup(GREEN, GPIO.OUT)
GPIO.setup(BLUE, GPIO.OUT)
POW_R = GPIO.PWM(RED, 500)
POW_G = GPIO.PWM(GREEN, 500)
POW_B = GPIO.PWM(BLUE, 500)
POW_R.start(100)
POW_G.start(100)
POW_B.start(100)

while True:
    for i in range(0, 100):
        POW_G.ChangeDutyCycle(((100 - i) / 10) ** 2)
        POW_R.ChangeDutyCycle((i/10) ** 2)
        time.sleep(0.01)
    for i in range(0, 100):
        POW_R.ChangeDutyCycle(((100 - i) / 10) ** 2)
        POW_B.ChangeDutyCycle((i/10) ** 2)
        time.sleep(0.01)
    for i in range(0, 100):
        POW_B.ChangeDutyCycle(((100 - i) / 10) ** 2)
        POW_G.ChangeDutyCycle((i/10) ** 2)
        time.sleep(0.01)
