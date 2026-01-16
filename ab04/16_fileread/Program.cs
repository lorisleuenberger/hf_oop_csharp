internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("[error] Missing required parameter: filename");
            return;
        }

        string filename = args[0];
        string filecontent = "";
        int linecount;

        try
        {
            filecontent = File.ReadAllText(filename);
        } catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("[error] File not found: " + filename);
            return;
        }

        if(args.Length == 1)
        {
            Console.Write(filecontent);
            return;
        }

        if (args.Length == 2 || args[1] != "TOP" || !int.TryParse(args[2], out linecount))
        {
            Console.WriteLine("[error] Invalid optional parameters, expected format: filename TOP [int number of lines]");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        for(int i = 0; i < linecount; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}