namespace Shop
{
    internal class Warenkorb
    {
        private List<Produkt> produkte;

        public Warenkorb()
        {
            produkte = new List<Produkt>();
        }
        
        public void Hinzufuegen(Produkt produkt)
        {
            produkte.Add(produkt);
        }
        public void Entfernen(string artikelnummer)
        {
            produkte.RemoveAll(p => p.Artikelnummer.Equals(artikelnummer));
        }
        public void Anzeigen(bool mitPreisen = true)
        {
            Console.WriteLine("Produkte: ");
            foreach(Produkt produkt in produkte)
            {
                Console.WriteLine(
                    "Produkt: " + produkt.Artikelnummer +
                    ", Name: " + produkt.Name +
                    ", Kategorie: " + produkt.Kategorie +
                    ((mitPreisen) ? ", Preis: " + produkt.Preis : ""));
            }
        }
        public decimal Totalpreis()
        {
            decimal total = 0m;
            foreach(Produkt produkt in produkte)
            {
                total += produkt.Preis;
            }
            return total;
        }
        public void RabattGeben(decimal prozent)
        {
            produkte.ForEach(p => p.Preis -= p.Preis * (prozent / 100));
        }
        public void PruefeLagerbestand()
        {
            foreach(Produkt produkt in produkte)
            {
                if (!produkt.IstVerfuegbar())
                {
                    Console.WriteLine(produkt.Name + " nicht verfügbar");
                }
            }
        }
        public void LoescheNichtAnLager()
        {
            produkte.RemoveAll(p => !p.IstVerfuegbar());
        }
        public void SendungAusloesen()
        {
            produkte.ForEach(p => p.VerringereBestand());
        }
    }
}