using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6};
            int[] array2 = { 2, 3, 4 };
            int[] result = Kata.ArrayDiff(array1, array2);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    int[] subtractedArray = a.Where( i => !b.Contains(i)).ToArray();
    
    return subtractedArray;
  }    
}

