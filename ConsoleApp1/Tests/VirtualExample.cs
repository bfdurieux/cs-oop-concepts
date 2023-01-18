namespace ConsoleApp1.Tests;
/*
 * Virtual keyword allows a method or property to be overriden
 */
public class VirtualExample
{
    public virtual string overridable { get; set; }

    public virtual void overridableMethod()
    {
        Console.WriteLine("in virtual");
    }
    
}

public class DerivedVirtualExample : VirtualExample
{
    private string _overridable = ""; 
    public override string overridable
    {
        get => _overridable;
        set
        {
            _overridable = value;
            _overridable = "you have bene overriden!";
        }
    }

    public override void overridableMethod()
    {
        _overridable = "new val";
        Console.WriteLine(_overridable);
    }
}


class A
{
    public void F() {Console.WriteLine("A");}
    public virtual void G(){Console.WriteLine("B");}
}

class B : A
{
    new public void F() { Console.WriteLine("C");}
    public override void G() { Console.WriteLine("D");}
}