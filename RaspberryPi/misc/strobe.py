import RPi.GPIO as GPIO
from time import sleep

GPIO.setmode(GPIO.BCM)
GPIO.setup(23,GPIO.OUT)
GPIO.setup(18,GPIO.OUT)

while True:
	GPIO.output(23,True)
	sleep(0.1)
        GPIO.output(23,False)
	GPIO.output(18,True)
	sleep(0.1)
        GPIO.output(18,False)
