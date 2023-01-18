namespace ConsoleApp1.Problems;

public class Numerics
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (var i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    } 
}

public struct NumStruct : INum
{
    public void DoThing()
    {
        Console.WriteLine("doing a thing");
    }
}

public interface INum
{
    
}