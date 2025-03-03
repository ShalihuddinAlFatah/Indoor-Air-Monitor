The new Arduino sketch contain 4 files:
1. "Indoor_Air_Monitor_NodeMCU_ESP12E.ino" is the main file.
2. "communication_interface.h" contains WiFi connection implementation. 
    If you want to use another data transfer method, you can modify this file.
3. "nonvolatile_memory_interface.h" contains EEPROM code to save and read server IP address to the EEPROM. 
    If you want to use another non-volatile memory type, you can modify this file.
4. "sensor_interface.h" contains code to initialize and read data from the sensor. 
    I am using DHT22 and MQ2 sensor in this project.
    If you want to use another sensor, you can modify this file. 
