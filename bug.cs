public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        //This will cause an error because the variable x goes out of scope 
        //after this method is executed. However, the code may compile and run without any immediate problems.
        // This is why it is an uncommon error. 
        Console.WriteLine(x);
    }
}