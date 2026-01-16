internal class Akkuschrauber: Geraet
{
    public int DrehmomentNm {get;set;}
    public bool HatSchlagfunktion {get;set;}
    public Akkuschrauber (
        string seriennummer,
        string hersteller,
        int baujahr,
        GeraetKategorie kategorie,
        Zustand zustand,
        int drehmomentNm,
        bool hatSchlagfunktion): base(seriennummer, hersteller, baujahr, kategorie, zustand)
    {
        DrehmomentNm = drehmomentNm;
        HatSchlagfunktion = hatSchlagfunktion;
    }
}