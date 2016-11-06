using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// 5 1 19 12 3 6 10 2
// 0 -1 0 -1 -1 0 -2 3 -1 -3 5 -1

class InsertionSort
{
    static void Main()
    {
        List<int> set =
            Console.ReadLine().Split((char[]) null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Stopwatch counter = new Stopwatch();
        counter.Start();

        int size = set.Count;
        for (int y = 0; y < size; y++)
        {
            for (int i = 1; i < size; i++)
            {
                if (set[i - 1] > set[i])
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (set[j - 1] >= set[j])
                        {
                            int number = set[i];
                            set.RemoveAt(i);
                            set.Insert(j - 1, number);
                            break;
                        }
                    }
                    //InsertElement(set,i); -- a lot slower
                }
            }
        }

        counter.Stop();
        Console.WriteLine(string.Join(" ", set));
        Console.WriteLine(counter.Elapsed);
    }

    static void InsertElement(List<int> set, int i)
    {
        for (int j = i; j >= 0; j--)
        {
            if (set[j - 1] >= set[j])
            {
                int number = set[i];
                set.RemoveAt(i);
                set.Insert(j - 1, number);
                break;
            }
        }
    }
}
