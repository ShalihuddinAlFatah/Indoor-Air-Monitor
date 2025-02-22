# Indoor-Air-Monitor
#How it works:
It measures temperature, humidity, and some gases in PPM (LPG, CO (carbon monoxide), and smoke). 
Print those data to the LCD and send the data to the UDP server.

*UDP server means any Windows OS computer which has support for UDP protocol

#Dashboard app:
The dashboard app has an 'advanced UI' :P. You cant move the window by dragging random stuff.
Click, hold and drag the 'L' button to move the window. Click 'M' to minimize the window.
Click 'X' to close the window.

#How to pair a UDP server (MUST BE IN THIS ORDER, to make it easier :D):
1. Open the dashboard app. Click 'Pair' and a new window will appear.
2. Enter the UDP server's local IP address.
3. Connect the device to the UDP server using a USB cable. 
4. Click 'Scan' to scan all the active COM ports on the UDP server.
5. Choose the proper COM port to which the device connects.
6. Click 'Pair' to send the UDP server's local IP address to the device.

*The device automatically enters the pairing mode every time it is powered on.
*The pairing mode lasts 30 seconds, so you must complete steps 3 to 6 within 30 seconds.
*The device must be in the same network as the UDP server.
