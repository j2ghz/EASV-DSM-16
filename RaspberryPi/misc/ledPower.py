import RPi.GPIO as GPIO
led=5
GPIO.setmode(GPIO.BCM)
GPIO.setup(led,GPIO.OUT)
pwm=GPIO.PWM(led,500)
pwm.start(100)

while True:
	d=input("Brightness: ")
	pwm.ChangeDutyCycle(int(d))