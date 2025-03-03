#ifndef NONVOLATILE_MEMORY_INTERFACE_H
#define NONVOLATILE_MEMORY_INTERFACE_H

// #include <Arduino.h>
#include <EEPROM.h>

// EEPROM setting 
const int EEPROM_SIZE = 16;

// Initialize non-volatile memory
void myMemoryInit(void)
{
  // Initialize EEPROM
  EEPROM.begin(EEPROM_SIZE);
}

// Save data to non-volatile memory
// @param: Data to be written to memory
void saveToMemory(char* data)
{
  for (int i = 0; i < EEPROM_SIZE; i++) 
  {
    EEPROM.write(i, data[i]);  // Write each byte to EEPROM
  }

  EEPROM.commit();            // Save changes to flash
}

// Read data from non-volatile memory
// @param: Data container
void readFromMemory(char* data)
{
  for (int i = 0; i < EEPROM_SIZE; i++) 
  {
    data[i] = EEPROM.read(i);
  }
  
  data[EEPROM_SIZE - 1] = '\0';  // Ensure null termination for safety
}

#endif /* NONVOLATILE_MEMORY_INTERFACE_H */