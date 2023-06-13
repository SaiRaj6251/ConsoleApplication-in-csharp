using System;

namespace GetInput
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Name : ");
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, there : {userName}");
        Console.WriteLine("Press any key to quit");
        Console.ReadKey();
    }
}