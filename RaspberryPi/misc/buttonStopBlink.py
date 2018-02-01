from time import sleep
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
GPIO.setup(18, GPIO.IN, pull_up_down=GPIO.PUD_UP)
GPIO.setup(26, GPIO.OUT)
GPIO.setup(21, GPIO.OUT)

def on(n):
    GPIO.output(n, True)
def off(n):
    GPIO.output(n, False)

t=0.05

while True:
    off(21)
    on(26)    
    sleep(t)
    while not GPIO.input(18):
        sleep(t)
    off(26)
    on(21)
    sleep(t)
    while not GPIO.input(18):
        sleep(t)
