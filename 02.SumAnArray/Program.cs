namespace _02.SumAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfAllIntergers = 0;

            //////First way
            //string values = Console.ReadLine();

            //string[] items1 = values.Split(" ");
            //int[] arr1 = new int[items1.Length];

            //for (int i = 0; i < items1.Length; i++)
            //{
            //    arr1[i] = int.Parse(items1[i]);
            //    sumOfAllIntergers += arr1[i];
            //}

            ////Second way
            //string inputLine2 = Console.ReadLine();
            //string[] items2 = inputLine2.Split(" ");
            //int[] arr2 = items2.Select(int.Parse).ToArray();
            //for (int i = 0; i < items2.Length; i++)
            //{
            //    arr2[i] = int.Parse(items2[i]);
            //    sumOfAllIntergers += arr2[i];
            //}


            ////Third way
            int[] arr3 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < arr3.Length; i++)
            {
                sumOfAllIntergers += arr3[i];
            }

            Console.WriteLine(sumOfAllIntergers);

        }
    }
}