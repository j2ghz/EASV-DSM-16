import socket

TCP_IP = '10.176.132.17'
TCP_PORT = 9999

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM) #create a server using IPv4 and TCP
s.bind((TCP_IP, TCP_PORT)) # listen on this IP and PORT
s.listen(1) # start listening

conn, addr = s.accept() # acceppt a connection
print 'Client connected from:', addr
while 1:
    data = conn.recv(1024) # receive data
    if not data: break #if no more data, stop loop
    print "received data:", data #print received data
    conn.send(data)  # send the same message back to client
conn.close() # close the connection