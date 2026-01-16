internal class Program
{
    static void Main(string[] args)
    {
        Drucker d1 = new Drucker("Drucker A");
        Drucker d2 = new Drucker("Drucker B");
        d1.Drucke("Dok1.pdf");
        d2.Drucke("Dok2.pdf");
        // Startet sofort
        // Wird blockiert (zu früh)
        // Warten wir etwas...
        System.Threading.Thread.Sleep(2500);
        d2.Drucke("Dok2.pdf");
    }
}