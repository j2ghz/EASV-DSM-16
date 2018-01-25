import RPi.GPIO as GPIO

GPIO.setmode(GPIO.BCM)
GPIO.setup(18,GPIO.OUT)

com=raw_input("Input command\n")
if com=="ON":
	GPIO.output(18,True)
else:
	GPIO.output(18,False)
