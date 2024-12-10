public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        Console.WriteLine(x); // Correct: Accessing x within its scope
    }

    //To access x outside of its scope, we should make it a class member. 
    public int xClassMember; 
    public void MyMethod2()
    {
        xClassMember = 10; 
        Console.WriteLine(xClassMember);
    }
} 