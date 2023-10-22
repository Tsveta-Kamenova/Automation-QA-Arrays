namespace _04.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sumEvens = 0;
            int sumOdds = 0;


            foreach (int number in inputArray)
            {
                if (number % 2 ==  0) 
                    sumEvens += number;
                else 
                    sumOdds += number;
            }

            int result = sumEvens - sumOdds;

            Console.WriteLine($"{result}");
        }
    }
}