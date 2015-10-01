using System;

class QuickSort
{
    static void Main()
    {
        int[] arr = new[] {3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48};
        Console.WriteLine(string.Join(", ", arr));

        MyQuickSort(arr,0);

        Console.WriteLine(string.Join(", ", arr));
    }

    private static void MyQuickSort(int[] arr, int p)
    {
        int pivot = arr[p];

        for (int i = p; i < arr.Length; i++)
        {
            if (pivot > arr[i])
            {
                pivot ^= arr[i];
                arr[i] ^= pivot;
                pivot ^= arr[i];

                arr[p] = pivot;
            }
        }
    }
}
