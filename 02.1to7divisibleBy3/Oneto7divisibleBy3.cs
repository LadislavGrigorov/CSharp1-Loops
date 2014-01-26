using System;
//2.Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.


class Oneto7divisibleBy3
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter<=number)
        {
            if ((counter%3!=0)||(counter%7!=0))
	        {
		        Console.WriteLine(counter);
                counter++;
	        }
            else
	        {
                counter++;
	        }
            
        }
    }
}
