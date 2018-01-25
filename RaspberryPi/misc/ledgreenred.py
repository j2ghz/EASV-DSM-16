import RPi.GPIO as GPIO

GPIO.setmode(GPIO.BCM)
GPIO.setup(23,GPIO.OUT)
GPIO.setup(18,GPIO.OUT)

while True:
	com=raw_input("r/g: ")
	if com=="r":
		r=True
		g=False
	elif com=="g":
		g=True
		r=False
	else:
		g=False
		r=False
	GPIO.output(23,r)
	GPIO.output(18,g)
