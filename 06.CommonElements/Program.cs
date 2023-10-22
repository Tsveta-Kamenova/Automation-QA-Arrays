namespace _06.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] inputArray1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] inputArray2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // Read the lengths of the arrays
            int length = inputArray1.Length;

            // Iterate through the first array
            for (int i = 0; i < length; i++)
            {
                int currentNumber = inputArray1[i];

                // If the current element exists in the second array, print it
                if (inputArray2.Contains(currentNumber))
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}