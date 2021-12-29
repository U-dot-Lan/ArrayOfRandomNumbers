using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayOfRandomNumbers
{
    public static class ArrayValues
    {
        public static void FillArray(int[] n)
        {
            Random rand = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                int value = rand.Next(1, 6);
                n[i] = value;
            }
        }

        public static  void PrintIntersectValues(int[] n1, int[] n2)
        {
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
            {
                for (int j = 0; j < n2.Length; j++)
                {
                    if (n1[i] == n2[j])
                    {
                        Console.WriteLine($"value: {n1[i]}, indexes: [{i} | {j}]");
                        sum += n1[i];
                    }
                }
            }
            Console.WriteLine("sum of ALL intersect values {0}", sum);
        }

        public static void PrintSumIntersectValues(int[] n1, int[] n2)
        {
            var values = n1.Intersect(n2);
            foreach(var i in values)
            {
                Console.WriteLine($"Intersect values: {i}");
            }
            int sum = n1.Intersect(n2).Sum();
            Console.WriteLine($"sum of intersect values: {sum}");
        }
    }
}
