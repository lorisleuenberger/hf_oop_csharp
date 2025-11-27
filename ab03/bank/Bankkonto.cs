namespace bank
{
    internal class Bankkonto
    {
        private decimal saldo;
        public Bankkonto(decimal saldo)
        {
            this.saldo = saldo;
        }
        public void Einzahlen(decimal betrag)
        {
            if(betrag > 0)
            {
                this.saldo += betrag;
                Console.WriteLine("Der Betrag " + betrag.ToString() + " wurde auf das Konto eingezahlt. Aktualisierter Kontostand: " + this.saldo.ToString());
            } else
            {
                Console.WriteLine("Einzahlung abgeleht, Betrag muss über null sein.");
            }
        }
        public void Auszahlen(decimal betrag)
        {
            if(this.saldo > betrag)
            {
                this.saldo -= betrag;
                Console.WriteLine("Der Betrag " + betrag.ToString() + " wurde vom Konto ausgezahlt. Aktualisierter Kontostand: " + this.saldo.ToString());
            } else
            {
                Console.WriteLine("Auszahlung abgeleht, Saldo reicht nicht aus.");
            }
        }
        public void SaldoAnzeigen()
        {
            Console.WriteLine("Aktueller Saldo: " + this.saldo.ToString());
        }
        public void ZinsGutschrift(decimal zinssatzProzent)
        {
            this.saldo = this.saldo + this.saldo * (zinssatzProzent / 100);
            Console.WriteLine("Zinsgutschrift angewendet. Neuer Saldo: " + this.saldo.ToString());
        }
    }
}