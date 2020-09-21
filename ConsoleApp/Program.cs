using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string _conn = "";

        private static readonly DeviceClient deviceClient = DeviceClient
            .CreateFromConnectionString(_conn, TransportType.Mqtt);



        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter(); 
        }
    }
}
