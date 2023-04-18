using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string names = "Tuashar Sagar Farank Tedd Mark Rahul Rohan Rohit Amir Akash";

        Console.Write("Enter a character: ");
        char ch = Console.ReadLine().FirstOrDefault();

        var result = names
            .Split(' ')
            .Where(name => name.Contains(ch))
            .GroupBy(name => name.Count(c => c == ch))
            .OrderByDescending(g => g.Key)
            .FirstOrDefault();

        if (result == null)
        {
            Console.WriteLine("No names found.");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result));
        }
        Console.ReadLine();
    }
}
