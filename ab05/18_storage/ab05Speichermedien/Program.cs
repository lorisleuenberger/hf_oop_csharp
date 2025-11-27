namespace ab05Speichermedien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h1 = new HDDDrive("Seagate", 1000, 5400, 12.0);
            var h2 = new HDDDrive("WD", 2000, 7200, 12.0);
            var s1 = new SSDDrive("Samsung", 1000 , 300, "Test1234");
            var s2 = new SSDDrive("Crucial", 500, 500, "Phison E12");

            // Vor Generalisierung: gemischte Liste → object + Casting
            var devices = new List<StorageDevice> { h1, h2, s1, s2 };

            foreach (var d in devices)
            {
                    d.DisplayInfo();
                    Console.WriteLine($"Score: {d.Benchmark()}");
                    d.Format();
            }

            Console.WriteLine("→ Aktuell braucht es Typprüfungen/Casting. Nach der Generalisierung sollte das ohne gehen!");
        }
    }
}
