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
        }
    }
}