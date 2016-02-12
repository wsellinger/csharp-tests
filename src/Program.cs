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
    }
}
