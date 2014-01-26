using System;
//4. Write a program that calculates N!/K! for given N and K (1<K<N).
class CalculateFactoriels
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        ulong k = ulong.Parse(Console.ReadLine());
        if ((1<k)&&(k<n))
        {        
            ulong counterN = 1;
            ulong nFactoriel = 1;
            while (counterN <= n)
            {
                nFactoriel *= counterN;
                counterN++;
            }
            ulong kFactoriel = 1;
            ulong counterK = 1;
            while (counterK <= k)
            {
                kFactoriel *= counterK;
                counterK++;
            }
            decimal divideFactoriels = nFactoriel / kFactoriel;
            Console.WriteLine(divideFactoriels);
        }
        else
        {
            Console.WriteLine("Error! 1<K<N");
        }
    }
}
