using System;
class DestDemo
{
   
    public DestDemo()
    {
        Console.WriteLine("Instance is created.");
       

    }
    public void print(string name)
    {
        Console.WriteLine(name);
    }
    ~DestDemo()
    {
       Console.WriteLine("Instance is destroyed.");
    }
    static void Main()
    {
        DestDemo d1 = new DestDemo();
        DestDemo d2 = new DestDemo();
        DestDemo d3 = new DestDemo();
        d1 = null;
        GC.Collect(); // (Write all the 3 statements in the same line with comments).
        //d1.print("shrikant");
        Console.ReadLine();
    }
}

