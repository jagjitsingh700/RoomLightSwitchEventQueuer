using System;
using System.Text;
using System.Threading;
using Microsoft.ServiceBus.Messaging;

namespace RoomLightSwitchEventQueuer
{
    public class Program
    {
        // Acting As Fake IoT Device Sending Signals(Abstraced The IoT Device)
        static void Main(string[] args)
        {
            // Acting As Fake IoT Hub Sending Signal Light Is On. 
            SendLightSwitchOnEvent();

            // Waiting 10 Seconds
            Thread.Sleep(10000);

            // Acting As Fake IoT Hub Sending Signal Light Is Off. 
            SendLightSwitchOffEvent();
        }

        /// <summary>
        /// Send 'Event' to 'Azure Event Hub' when the light is switched on.
        /// </summary>
        static void SendLightSwitchOnEvent()
        {
            var eventHubClient = EventHubClient.CreateFromConnectionString("", "");

            try
            {
                var message = "LightOn";
                Console.WriteLine("{0} > Sending message: {1}", DateTime.Now, message);
                //Sending 'ByteArray' of information
                eventHubClient.Send(new EventData(Encoding.UTF8.GetBytes(message)));
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} > Exception: {1}", DateTime.Now, exception.Message);
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Send 'Event' to 'Azure Event Hub' when the light is switched off.
        /// </summary>
        static void SendLightSwitchOffEvent()
        {
            var eventHubClient = EventHubClient.CreateFromConnectionString("", "");

             try
             {
                var message = "LightOff";
                Console.WriteLine("{0} > Sending message: {1}", DateTime.Now, message);
                //Sending 'ByteArray' of information
                eventHubClient.Send(new EventData(Encoding.UTF8.GetBytes(message)));
             }
             catch (Exception exception)
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} > Exception: {1}", DateTime.Now, exception.Message);
                Console.ResetColor();
             }

            Thread.Sleep(200);
        }
    }
}
