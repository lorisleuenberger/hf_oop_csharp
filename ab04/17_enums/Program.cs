internal class Program
{
    private static void Main(string[] args)
    {
        Klimaanlage klimaanlage = new Klimaanlage{AktuelleTemperatur=20.0, ZielTemperatur=20.0,Modus=Modus.Off};
        klimaanlage.StatusAnzeigen();
        klimaanlage.ZielTemperatur = 25.0;
        klimaanlage.StatusAnzeigen();
        klimaanlage.ZielTemperatur = 18.0;
        klimaanlage.StatusAnzeigen();
    }
}