internal class Intensivkurs: Kurs
{
    public int Trainerstunden {get;set;}
    public Intensivkurs(string titel, int dauerStunden, decimal grundgebuehr, int trainerstunden): base(titel, dauerStunden, grundgebuehr)
    {
        Trainerstunden = trainerstunden;
    }
    public override decimal BerechneGebuehr(int teilnehmer)
    {
        decimal geb = base.BerechneGebuehr(teilnehmer);
        geb += Trainerstunden * (decimal) 15;
        if(Trainerstunden < DauerStunden)
        {
            geb = geb * (decimal) 0.9;
        }
        return geb;
    }
    public override void Anzeigen()
    {
        Console.WriteLine($"{Titel}: {DauerStunden}h, Grundgebühr { Grundgebuehr} CHF, Trainerstunden: {Trainerstunden}");
    }
}