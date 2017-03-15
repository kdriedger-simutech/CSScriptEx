public static class CsiAliases
{
    public static string[] dir(string directory = null)
    {
        return System.IO.Directory.GetFiles(directory ?? System.Environment.CurrentDirectory);
    }

    public static void cat(string tx) => System.Console.WriteLine(tx);
    
    public static void type(params string[] texts) 
    { 
        foreach (var txt in texts)
        {
            System.Console.WriteLine(txt); 
            System.Console.WriteLine("-------------"); 
        }
    }
    
    public static string cd(string directory) => System.Environment.CurrentDirectory = directory;
}
