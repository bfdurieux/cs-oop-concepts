namespace ConsoleApp1.Tests;

public class ConcreteExample : AbstractExample
{
    public override void AbstractFn(Func<string, string> fn)
    {
        fn("concrete example works!");
    }
}
