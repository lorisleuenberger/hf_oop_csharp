using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab05Speichermedien
{
    public class SSDDrive: StorageDevice
    {
        public int Tbw { get; set; } // Total Bytes Written (vereinfacht), Bsp: 300
        public string Controller { get; set; } // Bsp: "Phison E12"
        public SSDDrive(string manufacturer, int capacityGB, int tbw, string controller): base(manufacturer, capacityGB)
        {
            Tbw = tbw;
            Controller = controller;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"SSD {Manufacturer} {CapacityGB}GB");
            Console.WriteLine($"Read/Write: {ReadSpeedMBps}/{WriteSpeedMBps} MB/s");
            Console.WriteLine($"TBW: {Tbw}, Controller: {Controller}");
        }
    }
}
