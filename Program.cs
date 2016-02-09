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
            bool results;

            //Run Test
            results = AnagramTest("momdad", "dadmom");

            Console.WriteLine("Test results: " + results);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static bool AnagramTest(string stringA, string stringB)
        {
            foreach (char character in stringA)
            {
                if (stringB.Contains(character.ToString()))
                {
                    stringB = stringB.Remove(stringB.IndexOf(character), 1);
                }
                else
                {
                    return false;
                }
            }

            if (stringB.Length > 0)
            {
                return false;
            }

            return true;
        }
    }
}
