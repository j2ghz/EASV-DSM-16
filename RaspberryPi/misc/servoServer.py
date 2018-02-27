import socket
import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)

GPIO.setup(26, GPIO.OUT)

p = GPIO.PWM(26, 50)

p.start(7.5)

TCP_IP = '0.0.0.0'
TCP_PORT = 9997

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM) #create a server using IPv4 and TCP
s.bind((TCP_IP, TCP_PORT)) # listen on this IP and PORT
s.listen(1) # start listening
while True:
    # Wait for a connection
    print 'waiting for a connection'
    connection, client_address = s.accept()
    try:
        print 'connection from', client_address

        # Receive the data in small chunks and retransmit it
        while True:
            data = connection.recv(16)
            print 'received "%s"' % data
            if data:
                if data=="l":
                    p.ChangeDutyCycle(2.5)
                if data=="r":
                    p.ChangeDutyCycle(12.5)
            else:
                print 'no more data from', client_address
                break
            
    finally:
        # Clean up the connection
        connection.close()
