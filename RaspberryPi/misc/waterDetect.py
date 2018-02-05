from time import sleep, asctime
import RPi.GPIO as GPIO
GPIO.setmode(GPIO.BCM)
LOW=4
MID=5
HIGH=13

GPIO.setup(LOW, GPIO.IN)
GPIO.setup(MID, GPIO.IN)
GPIO.setup(HIGH, GPIO.IN)

log = open("log.txt","a")
log.wri

while True:
    print(asctime())
    if GPIO.input(HIGH) == 1:
        print("High")
    if GPIO.input(MID) == 1:
        print("Mid")
    if GPIO.input(LOW) == 1:
        print("Low")
    sleep(1)
