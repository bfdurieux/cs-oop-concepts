namespace ConsoleApp1.Tests;
/*
 * Abstract classes are used for inheritance and can include implementation
 * Unlike interfaces, which only serve as a contract that requires implementation
 * from the inheritor.
 */
public abstract class AbstractExample
{

    public abstract void AbstractFn(Func<string, string> fn);
}


/*
 * Sealed classes on the other hand, cannot be inherited
 */
public sealed class AbstractSealedExample
{
    private int myProperty { get; set; }
    
    public void NonAbstractFn(Func<string, string> fn)
    {
        fn("ye");
    }
}