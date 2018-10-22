using System;
using System.Linq;

namespace CLUSTERS
{
    class Program
    {
        static int[] Process(int[] numbers)
        {
            var batchSize = 3;
            return numbers
                    .Select((Value, Index) => new { Value, Index })
                    .GroupBy(list => list.Index / batchSize)
                    .Select(group => (group.Select(p => p.Value)).Sum())
                    .OrderByDescending(sum => sum)
                    .Take(3)
                    .ToArray();
        }

        static void Main(string[] args)
        {
            var input1 = new int[] { 1, 2, 2, 5, 7, 3, 7, 8, 9, 26, 16, 1, 2, 3, 1, 4, 5, 1 };
            var input2 = new int[] { 3, 7, 9, 5, 3, 56, 8, 0, 2, 56, 7, 6, 4 };

            var result = Process(input2);

            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();
        }
    }
}
