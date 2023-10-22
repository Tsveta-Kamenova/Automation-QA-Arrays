using System.Xml.Linq;

namespace _13.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = (Console.ReadLine() ?? "1").Split(" ").Select(int.Parse).ToList();

            inputList.RemoveAll(number => number < 0);

            if (inputList.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputList.Reverse();
                Console.WriteLine(string.Join(" ", inputList));
            }
        }
    }
}