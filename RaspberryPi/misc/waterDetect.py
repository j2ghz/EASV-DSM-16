from time import sleep, asctime
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
LOW=4
MID=5
HIGH=13
LLOW=16
LMID=20
LHIGH=21

GPIO.setup(LOW, GPIO.IN)
GPIO.setup(MID, GPIO.IN)
GPIO.setup(HIGH, GPIO.IN)
GPIO.setup(LLOW, GPIO.OUT)
GPIO.setup(LMID, GPIO.OUT)
GPIO.setup(LHIGH, GPIO.OUT)

def on(n):
    GPIO.output(n, True)
    print(n)
def off(n):
    GPIO.output(n, False)

while True:
    print(asctime())
    if GPIO.input(HIGH) == 1:
        on(LHIGH)
    else:
        off(LHIGH)
    if GPIO.input(MID) == 1:
        on(LMID)
    else:
        off(LMID)
    if GPIO.input(LOW) == 1:
        on(LLOW)
    else:
        off(LLOW)
    sleep(1)
