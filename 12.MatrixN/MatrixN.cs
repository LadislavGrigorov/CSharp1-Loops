using System;
//12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

class MatrixN
{
    static void Main()
    {
        Console.Write("Enter N<20:");
        int n = int.Parse(Console.ReadLine());
        for (int rows = 0; rows < n; rows++)
        {
            Console.WriteLine();
            for (int columns = 1; columns <= n; columns++)
            {
                Console.Write("{0,-3}",columns+rows);
            }
            
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
