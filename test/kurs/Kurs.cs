class Kurs
{
    public string Titel { get; set; }
    public int DauerStunden { get; set; }
    public decimal Grundgebuehr { get; set; }
    public Kurs(string titel, int dauerStunden, decimal grundgebuehr)
    {
        Titel = titel;
        DauerStunden = dauerStunden;
        Grundgebuehr = grundgebuehr;
    }
    public virtual decimal BerechneGebuehr(int teilnehmer)
    {
        return Grundgebuehr;
    }
    public virtual void Anzeigen()
    {
        Console.WriteLine($"{Titel}: {DauerStunden}h, Grundgebühr { Grundgebuehr} CHF");
    }
}