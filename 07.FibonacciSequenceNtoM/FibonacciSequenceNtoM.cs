using System;
/*.Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the              first two) is a sum of the previous two members.
*/

class FibonacciSequenceNtoM
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int secondMeber = 1;
        int newMember;
        int sum = 1;
        for (int i = 0; i < (n - 2); i++) //(n-2) because we know the sum of the first two members
        {
            newMember = firstMember + secondMeber;
            firstMember = secondMeber;
            secondMeber = newMember;
            sum += newMember;
        }
        Console.WriteLine("The sum of the fist {0} members is: {1}", n, sum);
    }
}
