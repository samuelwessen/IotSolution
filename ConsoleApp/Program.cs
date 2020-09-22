using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string _conn = "HostName=ec-win20-samuelw-iothub.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=nFB8wqS2Txzu7kdBQkPL5W9ZGMh3GnTwllzcnftB6uI=";


        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);



        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.ReceiveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
