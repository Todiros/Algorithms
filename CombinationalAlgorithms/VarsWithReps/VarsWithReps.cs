using System;
using System.Linq;

class VarsWithReps
{
    const int k = 3;
    const int n = 4;

    private static readonly string[] nums = new string[n]
    { "banana", "apple", "pineapple", "orange"};

    static void Main()
    {
        int[] variations = new int[n];
        GenerateVarsWithRepsRecursive(0, variations);
    }

    static void GenerateVarsWithRepsRecursive(int index, int[] vars)
    {
        if (index >= k)
        {
            PrintVariation(vars);
        }
        else
        {
            for (int i = 0; i < vars.Length; i++)
            {
                vars[index] = i;
                GenerateVarsWithRepsRecursive(index + 1, vars);
            }
        }
    }

    static void PrintVariation(int[] vars)
    {
        Console.WriteLine("{0} --> [{1}]",
            string.Join(", ", vars),
            string.Join(", ", vars.Select(i => nums[i])));
    }
}
