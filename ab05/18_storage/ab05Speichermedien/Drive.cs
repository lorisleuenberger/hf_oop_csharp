using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab05Speichermedien
{
    // Begründung: Abstract weil ich denke StorageDevice dient als Plan
    // und sollte nie selbst instanziert werden. Auch ist es so möglich in Zukunft
    // einfach abstrakte Methoden zu implementieren. Aktuell ist dies aber nicht der Fall.
    public abstract class StorageDevice
    {
        public string Manufacturer { get; set; }
        public int CapacityGB { get; set; }
        public int ReadSpeedMBps { get; set; }
        public int WriteSpeedMBps { get; set; }

        public StorageDevice(string manufacturer, int capacityGB)
        {
            Manufacturer = manufacturer;
            CapacityGB = capacityGB;
            ReadSpeedMBps = 180;
            WriteSpeedMBps = 160;
        }

        public void Format()
        {
            Console.WriteLine($"HDD formatiert ({CapacityGB} GB) …");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"HDD {Manufacturer} {CapacityGB}GB");
            Console.WriteLine($"Read/Write: {ReadSpeedMBps}/{WriteSpeedMBps} MB/s");
        }

        public int Benchmark()
        {
            // naive Mini-„Benchmark“
            return (ReadSpeedMBps + WriteSpeedMBps) / 2;
        }
    }
}
