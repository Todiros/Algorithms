using System;
using System.Collections.Generic;
using System.Linq;

class PrimeFactorization
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> factors = new List<int>();

        int divisor = 2;
        int remainder = n;

       while (remainder != 1)
        {
            if (remainder % divisor == 0)
            {
                remainder = remainder / divisor;
                factors.Add(divisor);
            }
            else
            {
                divisor++;
            }
        }

        Console.WriteLine("{0} = {1}", n, string.Join(" * ", factors));
    }
}
