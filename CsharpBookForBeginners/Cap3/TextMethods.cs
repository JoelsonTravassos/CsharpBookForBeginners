using static System.Console;
using System;
using System.Linq;

namespace CsharpBookForBeginners
{
    class TextMethods
    {
        static void Main(string[] args)
        {
            WriteLine("----Text Methods----");
            string company = " Microsoft Corporation ";

            WriteLine("TRIM - remove the empty spaces before and after the expression");
            WriteLine($"Name without spaces: {company.Trim()}");

            WriteLine("Lenght - returns the number of characters");
            WriteLine($"Lenght of the Text: {company.Length}");

            company = company.Trim();
            WriteLine($"Number of chars after trim(): {company.Length}");
        }
    }
}