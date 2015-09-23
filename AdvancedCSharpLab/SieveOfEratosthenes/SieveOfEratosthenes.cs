using System;
using System.Collections.Generic;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n++;
        
        List<int> set = Enumerable.Range(-1, n).Select(x => x + 1).ToList();
        bool[] isPrime = new bool[set.Count];

        for (int i = 2; i < isPrime.Length; i++)
        {
            isPrime[i] = true;
        }
 
        for (int i = 2; i < n; i++)
        {
            if (isPrime[i])
            {
                for (int y = i * 2; y < n; y = y + i)
                {
                    isPrime[y] = false;
                }
            }
        }

        for (int i = 0; i < set.Count; i++)
        {
            if (!(isPrime[i]))
            {
                set[i] = 0;
            }
        }

        set.RemoveAll(x => x == 0);
        Console.WriteLine(string.Join(", ", set));
    }
}
