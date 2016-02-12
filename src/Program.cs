using csharp_tests.src.tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tests
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Run Test
            Console.WriteLine("Anagram Test");
            Console.WriteLine("Input: " + "momdad, dadmom");
            Console.WriteLine("Results: " + TestDomeCSharpTest.AnagramTest("momdad", "dadmom"));
            Console.WriteLine("");


            Console.WriteLine("Palindrome Test");
            Console.WriteLine("Input: " + "Noel sees Leon.");
            Console.WriteLine("Results: " + TestDomeCSharpTest.PalindromeTest("Noel sees Leon."));
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
