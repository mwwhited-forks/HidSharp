using HidSharp;
using HidSharp.Platform.Windows;
using System;

namespace BinaryDataDecoders.Xslt.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            //NativeMethods.EnumerateDevices()

            //NativeMethods.EnumerateDevices(NativeMethods.GuidForUsbTmc, (deviceInfoSet, deviceInfoData, deviceID) =>
            //{
            //    Console.WriteLine(string.Join(',', deviceInfoSet, deviceInfoData, deviceID));
            //});

            // {a9fdbb24-128a-11d5-9961-00108335e361}

            var devices = DeviceList.Local.GetAllDevices();
        }
    }
}
