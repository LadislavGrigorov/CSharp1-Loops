using System;
//8.Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

class GDCof2Numbers
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int greatestCommonDevisor = 1;
        for (int i = 1; i <= firstNumber; i++)
        {
            if ((firstNumber%i==0) && (secondNumber%i==0))
            {
                greatestCommonDevisor = i;
            }
        }
        Console.WriteLine("The greatest common devisor of {0} and {1} is: {2}", firstNumber, secondNumber, greatestCommonDevisor);
    }
}
