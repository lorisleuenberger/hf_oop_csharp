namespace Shop
{
    internal class Produkt
    {
        public string Artikelnummer { get; set;}
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public string Kategorie { get; set; }
        private int lagerbestand;
        
        public Produkt( string artikelnummer, string name, decimal preis, string kategorie, int lagerbestand)
        {
            Artikelnummer = artikelnummer;
            Name = name;
            Preis = preis;
            Kategorie = kategorie;
            this.lagerbestand = lagerbestand;
        }
        public bool IstVerfuegbar()
        {
            return lagerbestand > 0;
        }
        public void VerringereBestand(int anzahl = 1)
        {
            lagerbestand -= 1;
        }
    }
}