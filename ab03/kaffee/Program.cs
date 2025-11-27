namespace Kaffee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Kaffeemaschine kaffeemaschine = new Kaffeemaschine();
            Console.WriteLine("Hello, World!");

            kaffeemaschine.AktuellerStand();

            kaffeemaschine.WasserAuffuellen();
            kaffeemaschine.BohnenAuffuellen();
            kaffeemaschine.SatzbehaelterLeeren();

            kaffeemaschine.AktuellerStand();
            
            for(int i = 0; i < 11; i++)
            {
                kaffeemaschine.KaffeeZubereiten();
                kaffeemaschine.AktuellerStand();
            }
            kaffeemaschine.WasserAuffuellen();
            kaffeemaschine.SatzbehaelterLeeren();
            kaffeemaschine.KaffeeZubereiten();
        }
    }
}