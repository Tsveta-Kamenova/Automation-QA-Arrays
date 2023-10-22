namespace _11.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();

            string commandGiven = Console.ReadLine() ?? "Delete 5";

            while (commandGiven != "end")
            {
                string[] commandParts = commandGiven.Split(" ");

                string commandName = commandParts[0];
                int element = int.Parse(commandParts[1]);
                

                //if (commandGiven.StartsWith("Add"))
                //{
                //    int numberToAdd = int.Parse(commandGiven.Split(" ")[1]);
                //    inputList.Add(numberToAdd);
                //}

                if (commandName == "Delete")
                {
                    inputList.RemoveAll(number => number == element);
                }
                else if (commandName == "Insert")
                {
                    int position = int.Parse(commandParts[2]);
                    inputList.Insert(position, element);
                }
                commandGiven = Console.ReadLine() ?? "Delete 5";
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}