namespace ConsoleApp1.Tests;
/*
 * works same as type Object
 * assumed to support any operation
 */
public class DynamicExample
{
    private dynamic _config;

    public DynamicExample(dynamic config)
    {
        _config = config;
    }

    public void getFilename()
    {
        Console.WriteLine(_config.Filename + _config.Extension);
    }
}