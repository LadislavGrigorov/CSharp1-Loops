using System;
//6.Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
class CalculateExpression
{
    static void Main()
    {
        Console.Write("Enter N: ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        ulong x = ulong.Parse(Console.ReadLine());
        decimal sum = 1;
        for (ulong i = 1; i <= n; i++)  //loop in function of N
        {
            decimal counter = 1;         //current factoriel
            decimal nFactoriel = 1;
            while (counter <=i)
            {
                nFactoriel *= counter;
                counter++;
            }
            decimal result = 1;        //curret x^n
            for (ulong u = 0; u < i; u++)
            {
                result *= x;
            }
            sum += nFactoriel / result;    //current sum + N!/X^N
        }
        Console.WriteLine(sum);
    }
}
