internal class Multimeter: Geraet
{
    public bool IstDigital {get;set;}
    public int MaxSpannungVolt {get;set;}
    public Multimeter (
        string seriennummer,
        string hersteller,
        int baujahr,
        GeraetKategorie kategorie,
        Zustand zustand,
        bool istDigital,
        int maxSpannungVolt): base(seriennummer, hersteller, baujahr, kategorie, zustand)
    {
        IstDigital = istDigital;
        MaxSpannungVolt = maxSpannungVolt;        
    }
}