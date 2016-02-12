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

        public static bool PalindromeTest(string str)
        {
            str = StringToAlphaLowerOnly(str);

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str.ElementAt(i) != str.ElementAt(str.Length - i - 1))
                {
                    return false;
                }
            }

            return true;
        }

        private static string StringToAlphaLowerOnly(string str)
        {
            const string alphaChars = "abcdefghijklmnopqrstuvwxyz";
            string culledString = "";

            str = str.ToLower();

            foreach (char character in str)
            {
                if (alphaChars.Contains(character))
                {
                    culledString += character;
                }
            }

            return culledString;
        }
    }
}
