import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setup(16,GPIO.OUT)
GPIO.setup(20,GPIO.OUT)
GPIO.setup(21,GPIO.OUT)

def on(n):
        GPIO.output(n,True)
	return
def off(n):
        GPIO.output(n,False)
	return

while True:
	on(16)
	time.sleep(3)
	on(20)
	time.sleep(1)
	off(16)
        off(20)
        on(21)
	time.sleep(3)
	off(21)
	on(20)
	time.sleep(1)
	off(20)
	off(21)
