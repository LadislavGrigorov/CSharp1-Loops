using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        ulong n = ulong.Parse(Console.ReadLine());
        if (n >= 0)
        {

            ulong nFactoriel = 1;          //finds N!
            ulong counterN = n;
            do
            {
                nFactoriel *= counterN;
                counterN--;
            } while (counterN > 0);
            ulong n2Factoriel = 1;          //finds (2n)!
            ulong counterN2 = 2 * n;
            do
            {
                n2Factoriel *= counterN2;
                counterN2--;
            } while (counterN2 > 0);
            ulong n1Factoriel = 1;          //finds (n+1)!
            ulong counterN1 = n + 1;
            do
            {
                n1Factoriel *= counterN1;
                counterN1--;
            } while (counterN1 > 0);
            ulong cnumber = n2Factoriel / (n1Factoriel * nFactoriel);
            Console.WriteLine("The {0} catalan number is {1}", n, cnumber);
        }
        else
        {
            Console.WriteLine("Error! N>=0!");
        }
    }
}
