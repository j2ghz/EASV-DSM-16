import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setup(5,GPIO.OUT)
GPIO.setup(6,GPIO.OUT)
GPIO.setup(12,GPIO.OUT)
GPIO.setup(20,GPIO.OUT)
GPIO.setup(21,GPIO.OUT)
GPIO.setup(26,GPIO.OUT)

def on(n):
        GPIO.output(n,True)
	return
def off(n):
        GPIO.output(n,False)
	return

while True:
	on(5)
	on(26)
	time.sleep(3)
	off(26)
	on(21)
	time.sleep(1)
	on(12)
	off(5)
	off(21)
	on(20)
	time.sleep(3)
	off(12)
	on(6)
	time.sleep(1)
	off(6)
	off(20)
	on(26)
