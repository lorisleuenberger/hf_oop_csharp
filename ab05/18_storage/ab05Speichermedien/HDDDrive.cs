using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab05Speichermedien
{
    public class HDDDrive: StorageDevice
    {
        // HDD-spezifisch
        public int Rpm { get; set; } // Rotationen pro Minute, Bsp: 5400, 7200
        public double SeekTimeMs { get; set; } // Suchzeit in Millisekunden, Bsp: 12.0

        public HDDDrive(string manufacturer, int capacityGB, int rpm, double SeekTimeMs): base(manufacturer, capacityGB)
        {
            Rpm = rpm;
            CapacityGB = capacityGB;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"HDD {Manufacturer} {CapacityGB}GB");
            Console.WriteLine($"Read/Write: {ReadSpeedMBps}/{WriteSpeedMBps} MB/s");
            Console.WriteLine($"RPM: {Rpm}, Seek: {SeekTimeMs} ms");
        }
    }
}
