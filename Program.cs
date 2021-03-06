// Team Juliet: Laura Warneke, Tyler Colon, Scott Hafetz, Nicole Donley, Jordan Bradley, Garrett Knobel 
// Team Bela Problem 

using System;

public class Bela_Group_Proj
{
    public static void Main(string[] args)
    {
        // Read line to see how many hands and multiply by 4 
        string input = Console.ReadLine();
        int space = input.IndexOf(' ');
        int hands = int.Parse(input.Substring(0, space)) * 4;
        char suit = input[space + 1];
        int total = 0;

        //  Loop and determine if suit is dominant or non dominant and add to total 
        for (int x = 0; x < hands; x++)
        {
            string s = Console.ReadLine();
            switch (s[0])
            {
                case 'A':
                    total += 11;
                    break;
                case 'K':
                    total += 4;
                    break;
                case 'Q':
                    total += 3;
                    break;
                case 'J':
                    if (s[1] == suit)
                        total += 20;
                    else
                        total += 2;
                    break;
                case 'T':
                    total += 10;
                    break;
                case '9':
                    if (s[1] == suit)
                        total += 14;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(total);
    }
}
