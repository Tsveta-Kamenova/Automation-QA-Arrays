namespace _03.ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the array (n lines of integers)
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            // Print the elements from the last to the first
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");

        }
    }
}