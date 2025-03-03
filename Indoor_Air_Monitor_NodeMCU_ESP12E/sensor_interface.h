#ifndef SENSOR_INTERFACE_H
#define SENSOR_INTERFACE_H

#include <Arduino.h>
#include <DHT.h>
#include <DHT_U.h>
#include <MQ2.h>

// DHT 
#define DHTPIN 14
#define DHTTYPE DHT22

typedef struct
{
  int temp;
  int hum;
  int lpg;
  int co;
  int smoke;  
} sensorData;

// Gas sensor
int GasSensor = A0;

// Configure all sensors
DHT dht(DHTPIN, DHTTYPE);
MQ2 mq2(GasSensor);

// Setting up and initialize all sensors
void sensorSetUp(void)
{
  pinMode(GasSensor, INPUT);
  dht.begin();
  mq2.begin();
}

// Read sensor data
void getSensorData(sensorData *mySensorData)
{
  float* values = mq2.read(false);
  mySensorData->lpg = mq2.readLPG();
  mySensorData->co = mq2.readCO();
  mySensorData->smoke = mq2.readSmoke();
  mySensorData->temp = dht.readTemperature();
  mySensorData->hum = dht.readHumidity();
}

#endif /* SENSOR_INTERFACE_H */