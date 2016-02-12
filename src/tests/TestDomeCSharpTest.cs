using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tests.src.tests
{
    class TestDomeCSharpTest
    {
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
