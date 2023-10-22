using System.Data;

namespace _15.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = (Console.ReadLine()?? "1").Split(" ").Select(int.Parse).ToList();
            string input = Console.ReadLine() ?? "1";
            bool isFiltered = false;


            while (input != "end")
            {
                string[] commandParts = (input ?? "1").Split(" ");
                string commandName = commandParts[0];

                if (commandName == "Contains")
                {
                    int containedNumber = int.Parse(commandParts[1]);
                    if (numbers.Contains(containedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandName == "PrintEven")
                {
                    for (int index = 1; index <= numbers.Count - 1; index++)
                    {
                        int currentNumber = numbers[index];
                        if (currentNumber % 2 == 0)
                        {
                            Console.Write(currentNumber + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (commandName == "PrintOdd")
                {
                    for (int index = 0; index < numbers.Count - 1; index++)
                    {
                        int currentNumber = numbers[index];
                        if (currentNumber % 2 != 0)
                        {
                            Console.Write(currentNumber + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (commandName == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (commandName == "Filter")
                {
                    isFiltered = true;
                    List<int> filteredNum = new List<int>();
                    for (int index = 0; index <= numbers.Count - 1; index++)
                    {
                        if (commandParts[1] == ">")
                        {
                            if (numbers[index] > int.Parse(commandParts[2]))
                            {
                                filteredNum.Add(numbers[index]);
                            }
                        }
                        else if (commandParts[1] == "<")
                        {
                            if (numbers[index] < int.Parse(commandParts[2]))
                            {
                                filteredNum.Add(numbers[index]);
                            }
                        }
                        if (commandParts[1] == ">=")
                        {
                            if (numbers[index] >= int.Parse(commandParts[2]))
                            {
                                filteredNum.Add(numbers[index]);
                            }
                        }
                        if (commandParts[1] == "<=")
                        {
                            if (numbers[index] <= int.Parse(commandParts[2]))
                            {
                                filteredNum.Add(numbers[index]);
                            }
                        }
                    }
                    Console.WriteLine(string.Join(" ", filteredNum));
                }
                input = Console.ReadLine();
            }
            if (!isFiltered)
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}