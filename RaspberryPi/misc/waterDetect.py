from time import sleep, asctime
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
LED=18
SENSOR=4
GPIO.setup(SENSOR, GPIO.IN)
GPIO.setup(LED, GPIO.OUT)

def on(n):
    GPIO.output(n, True)
def off(n):
    GPIO.output(n, False)

while True:
    if GPIO.input(SENSOR) == 1:
        print("Water warning: " + asctime())
        on(LED)
        sleep(1)
    else:
        off(LED)
        sleep(0.2)
