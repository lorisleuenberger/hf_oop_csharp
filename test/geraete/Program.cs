internal class Program
{
    private static void Main(string[] args)
    {
        List<Geraet> geraete = new List<Geraet>();
        geraete.Add(new Computer("abc123", "ASUS", 2025, GeraetKategorie.Computer, Zustand.Gut, 16, 256));
        geraete.Add(new Multimeter("test1234", "Meterfirma", 1990, GeraetKategorie.Messgeraet, Zustand.Defekt, false, 4));
        geraete.Add(new Akkuschrauber("qwerty32", "Bosch", 2016, GeraetKategorie.Werkzeug, Zustand.Neu, 5000, false));
        
        foreach (Geraet geraet in geraete)
        {
            Console.Write("");
        }
    }
}