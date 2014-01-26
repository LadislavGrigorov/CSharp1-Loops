using System;
//1. Write a program that prints all the numbers from 1 to N.
class Print1toN
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter<=number)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}
