using System;
//5.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class CalculateFactoriels2
{
    static void Main()
    {
        Console.Write("Enter N: ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        decimal k = decimal.Parse(Console.ReadLine());
        if ((n > 1) && (k > n))
        {
            decimal differenceKN = k - n; //Finds (K-N)!
            decimal counterKN = 1;
            decimal kmFactoriel = 1;
            while (counterKN <= differenceKN)
            {
                kmFactoriel *= counterKN;
                counterKN++;
            }
            decimal counterN = 1;     //Finds N!
            decimal nFactoriel = 1;
            while (counterN <= n)      
            {
                nFactoriel *= counterN;
                counterN++;
            }
            decimal kFactoriel = 1;   //Finds K!
            decimal counterK = 1;
            while (counterK <= k)
            {
                kFactoriel *= counterK;
                counterK++;
            }
            decimal expression = (nFactoriel * kFactoriel) / (kmFactoriel);
            Console.WriteLine(expression);
        }
        else
        {
            Console.WriteLine("Error! Valuse must be 1<N<K");
        }
    }
}
