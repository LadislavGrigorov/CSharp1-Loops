using System;
//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class MinAndMaxValue
{
    static void Main()
    {
        Console.Write("How many integer numbers do you want to enter? ");
        int numberOfNumber = int.Parse(Console.ReadLine());
        int value;
        int minValue = int.MaxValue;
        int maxValue = 0;
        for (int i = 0; i < numberOfNumber; i++)
        {
            value = int.Parse(Console.ReadLine());
            if (value>maxValue)
            {
                maxValue = value;
            }
             if (value<minValue)
            {
                minValue = value;
            }
        }
        Console.WriteLine("Minimal value = {0}", minValue);
        Console.WriteLine("Maximal value = {0}", maxValue);
    }
}
