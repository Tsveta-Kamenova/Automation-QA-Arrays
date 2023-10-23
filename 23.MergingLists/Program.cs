namespace _23.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList1 = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();
            List<int> inputList2 = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();

            List<int> outputList = new List<int>();


            int longerList = Math.Max(inputList1.Count, inputList2.Count);

            for (int i = 0; i < longerList; i++)
            {

                if (i < inputList1.Count)
                {
                    outputList.Add(inputList1[i]);
                }

                if (i < inputList2.Count)
                {
                    outputList.Add(inputList2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}