internal class Praesenzkurs: Kurs
{
    public bool HatMaterial {get;set;}
    public Praesenzkurs(string titel, int dauerStunden, decimal grundgebuehr, bool hatMaterial): base(titel, dauerStunden, grundgebuehr)
    {
        HatMaterial = hatMaterial;
    }
    public override decimal BerechneGebuehr(int teilnehmer)
    {
        decimal geb = base.BerechneGebuehr(teilnehmer);
        if(HatMaterial)
        {
            geb += 30;
        }
        if(teilnehmer - 10 > 0)
        {
            geb += (teilnehmer - 10) * 5;
        }
        return geb;
    }
    public override void Anzeigen()
    {
        Console.WriteLine($"{Titel}: {DauerStunden}h, Grundgebühr { Grundgebuehr} CHF, HatMaterial: {HatMaterial}");
    }
}