# RoomLightSwitchEventQueuer
Basic POC - Implementation of processor sending 'Events' to 'Azure Event Hub' when the room light(IoT Device) is switched on/off. 

# Technology Overview

Azure Event Hub - Azure Event Hub is a Big Data streaming platform and event ingestion service, capable of receiving and processing millions of events per second. Event Hub can process and store events, data, or telemetry produced by distributed software and devices. 

# Architecture

The architecture is very simplified where the IoT device will send signal to this repository "RoomLightSwitchEventQueuer" which again will send the event to Azure Event Hub. "RoomLightSwitchEventQueuer" is just acting as a mediator. 

In this case the IoT device sending signals are abstracted. The "Main" method in the console application is acting as IoT device sending signals when "Light" is switched on/off. In a real scenario, we could configure the IoT device to do that part. 

# Getting Started

1) You need to create an 'EventHub Container' and 'EventHub' in your 'Azure' subscription. Following Azure CLI commands will work for you:

```
az login
az group create --name RoomLightService --location northeurope
az eventhubs namespace create --name RoomLightContainer --resource-group RoomLightService -l northeurope
az eventhubs eventhub create --name "RoomLightEventHub" --resource-group RoomLightService --namespace-name RoomLightContainer
```
2) Clone this project and put in your connection strings all the places in code where `EventHubClient.CreateFromConnectionString(...)` is called and when you run the program, some 'Events' should appear in your 'Event Hub'. 
