from time import sleep
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
GPIO.setup(18, GPIO.IN, pull_up_down=GPIO.PUD_UP)
GPIO.setup(26, GPIO.OUT)
GPIO.setup(21, GPIO.OUT)
GPIO.setup(20, GPIO.OUT)
GPIO.setup(16, GPIO.OUT)

def on(n):
    GPIO.output(n, True)
def off(n):
    GPIO.output(n, False)


def check():
    t = 0
    if not GPIO.input(18):
        t = 0.08
    else:
        t = 0.15
    sleep(t)

while True:
    
    off(16)
    on(26)    
    check()
    off(26)
    on(21)
    check()
    off(21)
    on(20)
    check()
    off(20)
    on(16)
    check()
