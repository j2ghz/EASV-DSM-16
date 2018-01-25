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
	print(str(n) + " ON")
	GPIO.output(n,True)
	return
def off(n):
	print(str(n) + " OFF")
	GPIO.output(n,False)
	return

while True:
	on(5)
	on(26)
	time.sleep(3)
	off(26)	
	on(6)
	for i in range(0,20):
		time.sleep(0.05)
		on(21)
		time.sleep(0.05)
		off(21)        
		pass	
	off(6)
	off(5)
	on(12)
	on(20)
	time.sleep(3)
	off(12)	
	on(21)
	for i in range(0,20):
		time.sleep(0.05)
		on(6)
		time.sleep(0.05)
		off(6)        
		pass
	off(21)
	off(20)
	on(26)
