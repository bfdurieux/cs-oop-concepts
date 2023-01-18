using System.CodeDom.Compiler;

namespace ConsoleApp1;

abstract class databaseService
{
    public databaseService()
    {
        Console.WriteLine("abstract");
    }
}

class concreteService : databaseService
{
    public concreteService()
    {
        Console.WriteLine("concrete");
        
    }
    
    public static async Task<string> F(int ms)
    {
        await Task.Delay(ms);
        return ms.ToString();
    }
    
}

class Text
{
    protected dynamic config;

    public Text(dynamic config)
    {
        this.config = config;
    }

    public void getFilename()
    {
        Console.WriteLine(config.Filename);
    }
}


