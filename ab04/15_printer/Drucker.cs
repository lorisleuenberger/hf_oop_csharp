internal class Drucker
{
    public static int DruckDelayMs {get;set;} = 2000;
    public static DateTime LetzterDruck {get;set;}
    public string Name {get;set;}

    public Drucker(string name)
    {
        this.Name = name;
        LetzterDruck = DateTime.Now;
    }

    public void Drucke(string docname)
    {
        if(LetzterDruck.AddMilliseconds(DruckDelayMs) < DateTime.Now)
        {
            Console.WriteLine($"Spooler ist noch gesperrt, \"{docname}\" kann nicht starten.");
        }
        LetzterDruck = DateTime.Now;
        Console.WriteLine($"Starte Druck von \"{docname}\"");
    }
}