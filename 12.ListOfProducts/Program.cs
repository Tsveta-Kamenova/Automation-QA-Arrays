namespace _12.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine() ?? "1");
            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string currentProduct = Console.ReadLine() ?? "Apple";
                listOfProducts.Add(currentProduct);
            }
            listOfProducts.Sort();

            for (int i = 1; i <= listOfProducts.Count; i++)
            {
                Console.WriteLine(i + "." + listOfProducts[i-1]);
            }


            //int n = int.Parse(Console.ReadLine()); //брой на продуктите

            //List<string> products = new List<string>(); //продукти

            //for (int i = 1; i <= n; i++)
            //{
            //    string product = Console.ReadLine();
            //    products.Add(product);
            //}

            ////пълен списък с продуктите
            ////{"Potatoes", "Tomatoes", "Onions", "Apples"}
            ////сортиране по азбучен ред (ascending order -> A - Z)
            //products.Sort();
            ////{"Apples", "Onions", "Potatoes", "Tomatoes"}

            //int number = 1; //поредния номер на продукта
            //foreach (string product in products)
            //{
            //    Console.WriteLine(number + "." + product);
            //    number++;
            //}
        }
    }
}