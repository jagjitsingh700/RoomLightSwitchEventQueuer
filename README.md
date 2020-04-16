# RoomLightSwitchEventQueuer
Basic POC - Implementation of processor sending 'Events' to 'Azure Event Hub' when the room light(IoT Device) is switched on/off. 

# Technology Overview

Following technologies are explored in this project:

Azure Event Hub - Azure Event Hub is a Big Data streaming platform and event ingestion service, capable of receiving and processing millions of events per second. Event Hub can process and store events, data, or telemetry produced by distributed software and devices. 

# Architecture

The architecture is very simplified where the IoT device will send signal to this repository "RoomLightSwitchEventQueuer" which again will send the event to Azure Event Hub. "RoomLightSwitchEventQueuer" is just acting as a mediator. 
