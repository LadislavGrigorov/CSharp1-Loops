using System;
//11.Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

class DeckOf52Cards
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            switch (i)
            {
                case 1: Console.WriteLine("Clubs");
                    break;
                case 2: Console.WriteLine("Diamods");
                    break;
                case 3: Console.WriteLine("Heats");
                    break;
                case 4: Console.WriteLine("Spides");
                    break;
            }
            for (int j = 1; j <= 13; j++)
            {                
                switch (j)
                {
                    case 1: Console.WriteLine("Ace");
                        break;
                    case 2: Console.WriteLine("2");
                        break;
                    case 3: Console.WriteLine("3");
                        break;
                    case 4: Console.WriteLine("4");
                        break;
                    case 5: Console.WriteLine("5");
                        break;
                    case 6: Console.WriteLine("6");
                        break;
                    case 7: Console.WriteLine("7");
                        break;
                    case 8: Console.WriteLine("8");
                        break;
                    case 9: Console.WriteLine("9");
                        break;
                    case 10: Console.WriteLine("10");
                        break;
                    case 11: Console.WriteLine("Jack");
                        break;
                    case 12: Console.WriteLine("Queen");
                        break;
                    case 13: Console.WriteLine("King");
                        break;

                }
            }
        }
    }
}
