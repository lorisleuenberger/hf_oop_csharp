internal class Computer: Geraet
{
    public int ArbeitsspeicherGb {get;set;}
    public int SpeicherplatzGb {get;set;}
    public Computer (
        string seriennummer,
        string hersteller,
        int baujahr,
        GeraetKategorie kategorie,
        Zustand zustand,
        int arbeitsspeicherGb,
        int speicherplatzGb): base(seriennummer, hersteller, baujahr, kategorie, zustand)
    {
        ArbeitsspeicherGb = arbeitsspeicherGb;
        SpeicherplatzGb = speicherplatzGb;        
    }
}