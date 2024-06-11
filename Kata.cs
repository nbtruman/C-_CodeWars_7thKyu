using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_CodeWars_7thKyu
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] subtractedArray = a.Where(i => !b.Contains(i)).ToArray();

            return subtractedArray;
        }

        //Define a function that takes an integer argument and returns a logical value true or false depending on if the integer is a prime.

        //Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            int i = 5;
            while (i * i < n) {
                Console.WriteLine(i);
                if (n % i == 0 || n % (i + 2) == 0) return false;
                i = i + 6;
            }

            return true; // TODO
        }
    }
}
