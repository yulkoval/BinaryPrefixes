using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BinaryPrefixes
{
    class Program
    {
        static void IsBinary(string str)
        {
            bool isBinary = Regex.IsMatch(str, "^[01]+$");
            if (!isBinary)
            {
                Console.WriteLine("{0} is not binary string.", str);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        static bool CheckString(string str)
        {
            int zeroCount = str.Count(x => x == '0');
            int oneCount = str.Count(x => x == '1');
            if (zeroCount == oneCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckPrefix(string prefix)
        {
            int zeroCount = prefix.Count(x => x == '0');
            int oneCount = prefix.Count(x => x == '1');
            if (zeroCount <= oneCount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not good, because number of 1's is less than the number of 0's.", prefix);
                return false;
            }       
        }

        static bool CheckPrefixes(string str)
        {
            string element = null;
            List<string> prefixes = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                element = str.Substring(0, i + 1);
                prefixes.Add(element);

                Console.WriteLine("Prefix {0}", element);

                if (!CheckPrefix(element))
                {
                    Console.WriteLine("Prefix {0} does not satisfy the second condition.", element);
                    return false;
                }

            }
            return true;
        }

        static void MainCheckMethod(string str)
        {
            IsBinary(str);
            if (CheckString(str))
            {
                Console.WriteLine("Entred number satisfies the first condition.");

                if (CheckPrefixes(str))
                {
                    Console.WriteLine("Entred number is good.");
                }
                else
                { 
                    Console.WriteLine("Entred number does not satisfy the second condition."); 
                }

            }
            else 
            { 
                Console.WriteLine("Entred number does not satisfy the first condition."); 
            }

            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            string binarySrting = Console.ReadLine();
            MainCheckMethod(binarySrting);

            Console.ReadKey();
        }

    }
}
