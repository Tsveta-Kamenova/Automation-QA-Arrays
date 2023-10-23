namespace _21.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();
            List<int> outputList = new List<int>();

            bool isMiddle = false;

            if (inputList.Count % 2 != 0)
            {
                isMiddle = true;
            }

            int index = inputList.Count - 1;

            for (int i = 0; i < inputList.Count / 2; i++)
            {
                int currentNewNumber = inputList[i] + inputList[index];
                index--;
                outputList.Add(currentNewNumber);
            }

            Console.Write(string.Join(" ",outputList));

            if (isMiddle)
            {
                Console.Write(" " + inputList[inputList.Count / 2]);
            }
        }
    }
}