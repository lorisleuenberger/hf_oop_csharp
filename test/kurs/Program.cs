internal class Program
{
    private static void Main(string[] args)
    {
        List<Kurs> kurse = new List<Kurs>();
        kurse.Add(new Praesenzkurs("Fotografie", 10, 150, true));
        kurse.Add(new Onlinekurs("C# Grundlagen", 8, 80, true));
        kurse.Add(new Intensivkurs("Projektleitung", 20, 300, 80));
        
        foreach(Kurs kurs in kurse)
        {
            kurs.Anzeigen();
            int teilnehmende = 5;
            Console.WriteLine($"Gebühr für {teilnehmende} Teilnehmende: {kurs.BerechneGebuehr(teilnehmende)} CHF");
        }
    }
}