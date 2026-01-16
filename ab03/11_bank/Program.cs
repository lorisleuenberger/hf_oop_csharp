namespace bank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var konto = new Bankkonto(1000);
            konto.Einzahlen(200);
            // +200 CHF
            konto.Auszahlen(150);
            // -150 CHF
            konto.ZinsGutschrift(1.5m);
            // +1.5 %
            konto.SaldoAnzeigen();
            // Ausgabe: aktueller Kontostand
        }
    }
}