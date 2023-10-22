namespace _05.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] inputArray2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool areIdentical = true;

            for (int i = 0; i < inputArray1.Length; i++)
            {
                if (inputArray1[i] != inputArray2[i])
                {
                    areIdentical = false;
                    break;
                }
            }
            
            if (areIdentical)
                Console.WriteLine("Arrays are identical.");
            else
                Console.WriteLine("Arrays are not identical.");


        }
    }       
}