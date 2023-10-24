namespace _27.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> outputList1 = new List<int>();
            List<int> outputList2 = new List<int>();

            int rows = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < rows; i++)
            {
                List<int> currentInputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();
                if (i % 2 != 0)
                {
                    outputList1.Insert(i, currentInputList[0]);
                    outputList2.Insert(i, currentInputList[1]);
                }
                else
                {
                    outputList1.Insert(i, currentInputList[1]);
                    outputList2.Insert(i, currentInputList[0]);
                }

                currentInputList = new List<int>();
            }
            Console.WriteLine(string.Join(" ", outputList2));
            Console.WriteLine(string.Join(" ", outputList1));
        }
    }
}