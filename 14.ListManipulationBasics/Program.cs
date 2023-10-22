namespace _14.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();

            string commandGiven = Console.ReadLine() ?? "Add 5";

            while (commandGiven != "end")
            {
                string[] commandParts = commandGiven.Split(" ");

                string commandName = commandParts[0];
                
                //if (commandGiven.StartsWith("Add"))
                //{
                //    int numberToAdd = int.Parse(commandGiven.Split(" ")[1]);
                //    inputList.Add(numberToAdd);
                //}

                if (commandName == "Add")
                {
                    int element = int.Parse(commandParts[1]);
                    inputList.Add(element);
                }
                else if (commandName == "Remove")
                {
                    int element = int.Parse(commandParts[1]);
                    inputList.Remove(element);
                }
                else if (commandName == "RemoveAt")
                {
                    int index = int.Parse(commandParts[1]);
                    inputList.RemoveAt(index);
                }
                else if (commandName == "Insert")
                {
                    int index = int.Parse(commandParts[2]);
                    int element = int.Parse(commandParts[1]);
                    inputList.Insert(index, element);
                }

                commandGiven = Console.ReadLine() ?? "Add 5";
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}