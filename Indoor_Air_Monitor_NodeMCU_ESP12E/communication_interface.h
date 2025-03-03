#ifndef COMMUNICATION_INTERFACE_H
#define COMMUNICATION_INTERFACE_H

// #include <Arduino.h>
#include <ESP8266WiFi.h>
#include <WiFiUdp.h>

// WiFi and UDP
const char* ssid = "Your_WiFi_SSID";
const char* password = "Your_WiFi_Password";

WiFiUDP Udp;

// Connect to network
int connectToNetwork(void)
{
  //WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
  }
  return (int)WiFi.status();
}

// Send data to server
void sendDataToServer(const char* serverIpAddress, uint16_t* sendPort, char* data)
{
  Udp.beginPacket(serverIpAddress, *sendPort);   //Your computer/server IP address and UDP port
  Udp.write(data);
  Udp.endPacket();
}

#endif /* COMMUNICATION_INTERFACE_H */