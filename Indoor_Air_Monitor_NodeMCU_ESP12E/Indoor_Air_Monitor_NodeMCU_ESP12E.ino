#include <EEPROM.h>

#include <LiquidCrystal_I2C.h>

#include <DHT.h>
#include <DHT_U.h>
#include <MQ2.h>

#include <ESP8266WiFi.h>
#include <WiFiUdp.h>

//#define DEBUG

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

// LCD init 16x2
int lcdColumns = 16;
int lcdRows = 2;
LiquidCrystal_I2C lcd(0x27, lcdColumns, lcdRows);  

// WiFi and UDP
const char* ssid = "Your WiFi SSID";
const char* password = "Your WiFi Password";

// Temporary UDP server for debugging purpose
// Replace it with your UDP server address
#ifdef DEBUG
  const char* receiverip = "192.168.0.9";
#endif

char ipCharArray[16];
WiFiUDP Udp;
uint16_t sendPort = 63000;
char dataUDP[100];

// EEPROM setting 
const int EEPROM_SIZE = 16;

// Configure all sensors
DHT dht(DHTPIN, DHTTYPE);
MQ2 mq2(GasSensor);
sensorData mySensorData;

// === Function prototypes ===

// Connect to WiFi
void connectToWIFI(void);

// Pairing process with the PC
void pairUDPConnection(void);

// Save paired IP address to EEPROM
void savePairedIP(void); 

// Read paired IP address from EEPROM
void readPairedIP(void);

// Read sensor data then put them into dataUDP
void getSensorData(void);

// Display sensor data on the LCD
void displaySensorData(void);

// Send UDP data
void sendUDPData(const char* ipAddress, uint16_t sendPort, char* dataUDP);

void setup() 
{
  // Initialize all sensors
  pinMode(GasSensor, INPUT);
  dht.begin();
  mq2.begin();
  
  // Initialize LCD
  lcd.init();                   
  lcd.backlight();

  // Initialize EEPROM
  EEPROM.begin(EEPROM_SIZE);
  
  Serial.begin(115200);
  Serial.println();

  connectToWIFI();
  pairUDPConnection();
}

void loop() 
{
  getSensorData();
  displaySensorData();
  
  // UDP data debug
  #ifdef DEBUG
    Serial.println(dataUDP);
    sendUDPData(receiverip, sendPort, dataUDP);
  #endif

  sendUDPData(ipCharArray, sendPort, dataUDP);
}

void connectToWIFI(void)
{
  Serial.printf("Connecting to %s ", ssid);
  //WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    //Serial.print(".");
    Serial.println(WiFi.status());
  }
  Serial.println("Connected");
}

void pairUDPConnection(void)
{
  String ipAddress = "";

  unsigned int startTime = millis();
  bool isPairingDone = 0;

  #ifdef DEBUG
    Serial.println("Pairing start...");
  #endif
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Pairing...");

  while( (millis() - startTime) < 30000 )
  {
    if(Serial.available() > 0) 
    {
      // Read the incoming data as a string
      ipAddress = Serial.readStringUntil('\n');  // Reads until newline character

      // Trim any extra whitespace or newline characters
      ipAddress.trim();

      // Convert the String to a char array
      ipAddress.toCharArray(ipCharArray, 16);

      // Print the IP address as a char array to confirm
      Serial.print("Paired: ");
      Serial.println(ipCharArray);
    }

    if(ipAddress != "")
    {
      isPairingDone = 1;
      break;
    }
  }

  if(isPairingDone == 1)
  {
    #ifdef DEBUG
      Serial.println("Pairing success...");
    #endif
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Paired");
    lcd.setCursor(0,1);
    lcd.print(ipAddress);
    savePairedIP();
  }

  else
  {
    #ifdef DEBUG
      Serial.println(ipAddress);
      Serial.println("Timeout...");
    #endif
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Timeout...");
    readPairedIP();
  }

  // Stop the UDP receiver
  Udp.stop();
}

void savePairedIP(void)
{
  for (int i = 0; i < EEPROM_SIZE; i++) 
  {
    EEPROM.write(i, ipCharArray[i]);  // Write each byte to EEPROM
  }

  EEPROM.commit();         // Save changes to flash
}

void readPairedIP(void)
{
  for (int i = 0; i < EEPROM_SIZE; i++) 
  {
    ipCharArray[i] = EEPROM.read(i);
  }
  
  ipCharArray[EEPROM_SIZE - 1] = '\0';  // Ensure null termination for safety
}

void getSensorData(void)
{
  // Gas sensor debug
  #ifdef DEBUG
    float* values = mq2.read(true);
  #endif
  
  float* values = mq2.read(false);
  mySensorData.lpg = mq2.readLPG();
  mySensorData.co = mq2.readCO();
  mySensorData.smoke = mq2.readSmoke();
  mySensorData.temp = dht.readTemperature();
  mySensorData.hum = dht.readHumidity();
  sprintf(dataUDP, "%d,%d,%d,%d,%d\n", mySensorData.lpg, mySensorData.co, mySensorData.smoke, mySensorData.temp, mySensorData.hum);
}

void displaySensorData(void)
{
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("LPG:");
  lcd.print(mySensorData.lpg);
  lcd.print(" CO:");
  lcd.print(mySensorData.co);
  lcd.setCursor(0,1);
  lcd.print("SMOKE:");
  lcd.print(mySensorData.smoke);
  lcd.print(" PPM");
  delay(2500);
  lcd.clear();
  lcd.print("TEMP:");
  lcd.print(mySensorData.temp);
  lcd.print(" oC");
  lcd.setCursor(0,1);
  lcd.print("HUM:");
  lcd.print(mySensorData.hum);
  lcd.print(" %");
  delay(2000);
}

void sendUDPData(const char* ipAddress, uint16_t sendPort, char* dataUDP)
{
  Udp.beginPacket(ipAddress, sendPort);   //Your computer/server IP address and UDP port
  Udp.write(dataUDP);
  Udp.endPacket();
}
