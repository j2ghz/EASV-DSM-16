import RPi.GPIO as GPIO
import time as time
RED = 5
GREEN = 6
GPIO.setmode(GPIO.BCM)
GPIO.setup(RED, GPIO.OUT)
GPIO.setup(GREEN, GPIO.OUT)
POW_R = GPIO.PWM(RED, 500)
POW_G = GPIO.PWM(GREEN, 500)
POW_R.start(100)
POW_G.start(100)

while True:
    for i in range(0, 100):
        POW_R.ChangeDutyCycle(i)
        POW_G.ChangeDutyCycle(100 - i)
        time.sleep(0.01)
    for i in range(0, 100):
        POW_R.ChangeDutyCycle(100 - i)
        POW_G.ChangeDutyCycle(i)
        time.sleep(0.01)
