import RPi.GPIO as GPIO

GPIO.setmode(GPIO.BCM)
GPIO.setup(5, GPIO.OUT)
GPIO.setup(6, GPIO.OUT)
GPIO.setup(13, GPIO.OUT)
R = 6
G = 13
B = 5
GPIO.output(R, False)
GPIO.output(G, False)
GPIO.output(B, False)

def led_on(pin):
    GPIO.output(pin, True)

while True:
    C = raw_input("Input command\n")
    if C == "R":
        led_on(R)
    elif C == "G":
        led_on(G)
    elif C == "B":
        led_on(B)
    else:
        raise ValueError("Invalid input")
