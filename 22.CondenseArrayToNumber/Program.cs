namespace _22.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();


            while (inputList.Count > 1)
            {
                List<int> outputList = new List<int>();

                for (int i = 0; i < inputList.Count - 1; i++)
                {
                    int number1 = inputList[i];
                    int number2 = inputList[i + 1];
                    int sum = number1 + number2;
                    outputList.Add(sum);
                }

                inputList = outputList;
            }
            Console.WriteLine(inputList[0]);
        }
    }
}