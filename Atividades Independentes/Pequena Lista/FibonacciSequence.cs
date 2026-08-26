using System;
namespace MyProgramAgain;

class FibonacciSequence
{
    public static void Main()
    {
        int num1 = 0, num2 = 1, num3 = (num1 + num2);
        Console.WriteLine("A sequência de Fibonacci é:");
        while (num1 < 50000)
        {
            Console.WriteLine(num1);
            num1 = num2;
            num2 = num3;
            num3 = (num1 + num2);
        }
        Console.WriteLine("E assim por diante...");
    }
}
