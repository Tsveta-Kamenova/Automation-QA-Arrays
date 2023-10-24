namespace _25.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList1 = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();
            List<int> bombList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();

            int bombNum = bombList[0];
            int bombPower = bombList[1];

            for (int i = 0; i < inputList1.Count; i++)
            {
                if (inputList1[i] == bombNum)
                {
                    int startIndex = i - bombPower;
                    int removeCount = bombPower + bombPower + 1;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex + removeCount > inputList1.Count)
                    {
                        removeCount = inputList1.Count - startIndex;
                    }

                    inputList1.RemoveRange(startIndex, removeCount);
                    i = startIndex - 1;
                }
            }
            //Console.WriteLine(string.Join(" ", inputList1));
            int sum = inputList1.Sum();
            Console.WriteLine(sum);
        }
    }
}