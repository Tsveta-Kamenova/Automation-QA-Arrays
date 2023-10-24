namespace _28.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();
            int rotationsCount = int.Parse(Console.ReadLine()?? "1");

            for (int i = 0; i < rotationsCount; i++)
            {
                int currentNum = inputList[0];
                inputList.RemoveAt(0);
                inputList.Add(currentNum);
            }

            //for (int i = 1; i <= inputList.Count; i++)
            //{
            //    while (rotationsCount > 0)
            //    {
            //        int temp = inputList[0];

            //        inputList.RemoveAt(0);
            //        inputList.Add(temp);
            //        rotationsCount -- ;
            //        temp = 0;
            //    }


            //}

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}