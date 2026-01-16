internal class Geraet
{
    public string Seriennummer {get;set;}
    public string Hersteller {get;set;}
    public int Baujahr {get;set;}
    public GeraetKategorie Kategorie {get;set;}
    public Zustand Zustand {get;set;}
    
    public Geraet (string seriennummer, string hersteller, int baujahr, GeraetKategorie kategorie, Zustand zustand) {
        Seriennummer = seriennummer;
        Hersteller = hersteller;
        Baujahr = baujahr;
        Kategorie = kategorie;
        Zustand = zustand;
    }
}