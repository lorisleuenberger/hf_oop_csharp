using System.Runtime.CompilerServices;

namespace Kaffee
{
    internal class Kaffeemaschine
    {
        private const decimal maxWasser = 2.0m;
        private const int maxBohnen = 250;
        private const int maxSatz = 10;
        private const decimal wasserProKaffee = 0.2m;
        private const int bohnenProKaffee = 10;
        
        private decimal wasser;
        private int bohnen;
        private int satz;
        private int kaffeCount;

        public Kaffeemaschine()
        {
            wasser = 0.0m;
            bohnen = 0;
            satz = 0;
            kaffeCount = 0;
        }
        
        public void AktuellerStand()
        {
            Console.WriteLine("Wasserstand: " + wasser + ", Bohnenstand: " + bohnen + ", Satzbehälter: " + satz);
        }

        public void KaffeeZubereiten()
        {
            List<string> errors = new List<string>();

            if (wasser < wasserProKaffee)
            {
                errors.Add("Wasserstand zu niedrig, bitte nachfüllen.");
            }
            if (bohnen < bohnenProKaffee)
            {
                errors.Add("Bohnenstand zu niedrig, bitte nachfüllen.");
            }
            if (satz >= maxSatz)
            {
                errors.Add("Kaffesatzbehälter voll, bitte leeren.");
            }

            if (errors.Count > 0)
            {
                errors.ForEach(Console.WriteLine);
                return;
            }

            wasser -= wasserProKaffee;
            bohnen -= bohnenProKaffee;
            satz++;
            kaffeCount++;
            Console.WriteLine("Hier ist ihr Kaffe. (Kaffees zubereitet: " + kaffeCount + ")");
        }

        public void WasserAuffuellen()
        {
            wasser = maxWasser;
        }
        public void BohnenAuffuellen()
        {
            bohnen = maxBohnen;
        }
        public void SatzbehaelterLeeren()
        {
            satz = 0;
        }
    }
}