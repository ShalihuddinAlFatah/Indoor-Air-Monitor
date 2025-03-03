#include <LiquidCrystal_I2C.h>

#include "sensor_interface.h"
#include "communication_interface.h"
#include "nonvolatile_memory_interface.h"

//#define DEBUG

// LCD init 16x2
int lcdColumns = 16;
int lcdRows = 2;
LiquidCrystal_I2C lcd(0x27, lcdColumns, lcdRows);  

// Temporary UDP server for debugging purpose
// Replace it with your UDP server address
#ifdef DEBUG
  const char* receiverip = "192.168.0.9";
#endif

// Server IP address container
char serverIpAddress[16];
uint16_t serverPort = 63000;

// Sensor data to transmit
char dataUDP[100];

// Sensor data container
sensorData mainSensorData;

// === Function prototypes ===

// Pairing process with the PC
void pairUDPConnection(void);

// Display sensor data on the LCD
void displaySensorData(void);

// Error handling
void errorHandler(void);

void setup() 
{
  Serial.begin(115200);
  Serial.println();

  sensorSetUp();
  
  // Initialize LCD
  lcd.init();                   
  lcd.backlight();

  myMemoryInit();
  
  int netStatus = connectToNetwork();
  #ifdef DEBUG
    Serial.println(netStatus);
  #endif
  // netStatus == 3 is connected
  if(netStatus != 3)
  {
    // Cant connect to network
    errorHandler();
  }

  pairUDPConnection();
}

void loop() 
{
  getSensorData(&mainSensorData);
  sprintf(dataUDP, "%d,%d,%d,%d,%d\n", mainSensorData.lpg, mainSensorData.co, mainSensorData.smoke, mainSensorData.temp, mainSensorData.hum);
  displaySensorData();
  
  // UDP data debug
  #ifdef DEBUG
    Serial.println(dataUDP);
    sendDataToServer(receiverip, &serverPort, dataUDP);
  #endif

  sendDataToServer(serverIpAddress, &serverPort, dataUDP);
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
      ipAddress.toCharArray(serverIpAddress, 16);

      // Print the IP address as a char array to confirm
      Serial.print("Paired: ");
      Serial.println(serverIpAddress);
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
    saveToMemory(serverIpAddress);
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
    readFromMemory(serverIpAddress);
  }
}

void displaySensorData(void)
{
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("LPG:");
  lcd.print(mainSensorData.lpg);
  lcd.print(" CO:");
  lcd.print(mainSensorData.co);
  lcd.setCursor(0,1);
  lcd.print("SMOKE:");
  lcd.print(mainSensorData.smoke);
  lcd.print(" PPM");
  delay(2500);
  lcd.clear();
  lcd.print("TEMP:");
  lcd.print(mainSensorData.temp);
  lcd.print(" oC");
  lcd.setCursor(0,1);
  lcd.print("HUM:");
  lcd.print(mainSensorData.hum);
  lcd.print(" %");
  delay(2000);
}

void errorHandler(void)
{
  while(1)
  {

  }
}
