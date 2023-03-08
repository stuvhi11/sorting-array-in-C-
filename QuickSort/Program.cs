// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    public static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 6, 5 };
        int n = arr.Length;

        quick(arr, 0, n - 1);
        Console.Write("Hasil");
        printArray(arr, n);
    }
    static void swp(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int part(int[] arr, int low, int high)
    {

        int pivot = arr[high];

        int i = (low - 1);

        for (int j = low; j <= high - 1; j++)
        {

            if (arr[j] < pivot)
            {
                i++;
                swp(arr, i, j);
            }
        }
        swp(arr, i + 1, high);
        return (i + 1);
    }

    static void quick(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = part(arr, low, high);
            quick(arr, low, pi - 1);
            quick(arr, pi + 1, high);
        }
    }

    static void printArray(int[] arr, int size)
    {
        for (int i = 0; i < size; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }
}