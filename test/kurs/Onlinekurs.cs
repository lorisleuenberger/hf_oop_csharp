internal class Onlinekurs: Kurs
{
    public bool HatAufzeichnung {get;set;}
    public Onlinekurs(string titel, int dauerStunden, decimal grundgebuehr, bool hatAufzeichnung): base(titel, dauerStunden, grundgebuehr)
    {
        HatAufzeichnung = hatAufzeichnung;
    }
    public override decimal BerechneGebuehr(int teilnehmer)
    {
        decimal geb = base.BerechneGebuehr(teilnehmer);
        if(HatAufzeichnung)
        {
            geb += 20;
        }
        if(teilnehmer < 5)
        {
            geb += 10;
        }
        return geb;
    }
    public override void Anzeigen()
    {
        Console.WriteLine($"{Titel}: {DauerStunden}h, Grundgebühr { Grundgebuehr} CHF, HatAufzeichnung: {HatAufzeichnung}");
    }
}