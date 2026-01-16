internal class Klimaanlage
{
    private double zielTemperatur;
    public double AktuelleTemperatur {get;set;}
    public double ZielTemperatur {
        get
        {
            return zielTemperatur;
        }
        set
        {
            zielTemperatur = value;
            if(zielTemperatur > AktuelleTemperatur)
            {
                Modus = Modus.Kuehlen;
            } else if (zielTemperatur == AktuelleTemperatur){
                Modus = Modus.Off;
            } else if (zielTemperatur < AktuelleTemperatur){
                Modus = Modus.Heizen;
            }
        }
    }
    public Modus Modus {get;set;}
    public void StatusAnzeigen()
    {
        Console.WriteLine($"Aktuelle Temperatur: {AktuelleTemperatur}, Zieltemperatur: {ZielTemperatur}, Modus: {Modus}");
    }
}