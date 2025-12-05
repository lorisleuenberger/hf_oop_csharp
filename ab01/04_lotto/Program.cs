internal class Program
{
    private static void Main(string[] args)
    {
        const int amountOfTips = 6;
        int[] tips = new int[amountOfTips];
        int[] results = new int[amountOfTips];


        Console.WriteLine("Bitte geben Sie ihre Tipps ab (1-45)");
        for(int i = 0; i < amountOfTips; i++)
        {
            tips[i] = ReadTip(i);
        }
        
        Random rng = new Random();
        for(int i = 0; i < amountOfTips; i++)
        {
            results[i] = rng.Next(1, 45);
        }

        for(int i = 0; i < tips.Count(); i++)
        {
            if(tips[i] == results[i])
            {
                Console.WriteLine("asdf");
            }
        }
    }
    
    private static int ReadTip(int index)
    {
        Console.Write("Tipp " + (index + 1) + ": ");
        int tip;
        string input = Console.ReadLine();
        if (int.TryParse(input, out tip))
        {
            return tip;
        }
        Console.WriteLine("Error: Seems like you didn't write a number. Let's try again.");
        return ReadTip(index);
    }
}