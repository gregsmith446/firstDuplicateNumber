using System;
using System.Collections.Generic;
using System.Linq;

namespace firstDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFinder run = new NumberFinder();

            int[] sampleData = new int[] { 2, 3, 3, 1, 5, 2 };

            var result = run.FirstDuplicateNumber(sampleData);

            Console.WriteLine("Expected result is: 3");
            Console.WriteLine("Actual result is: {0}", result);
        }
    }

    class NumberFinder
    {
        public int FirstDuplicateNumber(int[] array)
        {

            var tracker = new Dictionary<int, int>();

            int index = 0;

            while (index < array.Length - 1)
            {
                for (int i = index + 1; i < array.Length; i++)
                {
                    if (array[index] == array[i])
                    {
                        tracker.Add(array[i], i);
                    }
                }
                index++;
            }

            var ordered = tracker.OrderBy(items => items.Value);

            if (tracker.Count > 0)
            {
                return ordered.First().Key;
            }

            return -1;
        }
    }
}

    