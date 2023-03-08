// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{

    static void Main(string[] args)
    {
        int[] arr = { 4, 1, 6, 5, 2, 3 };
        InsertionSort(arr);
    }

    public static void InsertionSort(int[] arr)
    {

        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }

        Console.WriteLine("Hasil");
        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }
    }
}
