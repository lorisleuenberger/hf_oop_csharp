namespace Shop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var warenkorb = new Warenkorb();

            var buch = new Produkt("B001", "Clean Code", 42.50m, "Bücher", 5);
            var kabel = new Produkt("E999", "USB-C Kabel", 9.90m, "Elektronik",
            0);
            var stecker = new Produkt("S222", "Qi Stecker", 19.50m,
            "Elektronik", 4);

            warenkorb.Hinzufuegen(buch);
            warenkorb.Hinzufuegen(kabel);
            warenkorb.Hinzufuegen(stecker);
            warenkorb.Anzeigen(); // Zeigt alle Artikel mit Preisen
            warenkorb.PruefeLagerbestand(); // zeigt: Kabel nicht verfügbar
            warenkorb.LoescheNichtAnLager(); // entfernt das Kabel
            warenkorb.Entfernen("S222"); // entfernt den Stecker
            warenkorb.RabattGeben(10); // 10% auf alles
            warenkorb.Anzeigen(); // Zeigt alle Artikel mit Preisen
            warenkorb.SendungAusloesen(); // reduziert Lager und leert Warenkorb
        }
    }
}