from time import sleep
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
GPIO.setup(18, GPIO.IN, pull_up_down=GPIO.PUD_UP)
GPIO.setup(26, GPIO.OUT)
GPIO.setup(21, GPIO.OUT)
GPIO.setup(20, GPIO.OUT)

def on(n):
    GPIO.output(n, True)
def off(n):
    GPIO.output(n, False)

t=0.1

while True:
    off(20)
    on(26)    
    sleep(t)
    off(26)
    on(21)
    sleep(t)
    off(21)
    on(20)
    sleep(t)
    if not GPIO.input(18):
        t = 0.9 * t
