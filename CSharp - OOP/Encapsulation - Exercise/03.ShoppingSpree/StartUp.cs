using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                string[] personInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
               
                foreach(string pair in personInfo)
                {
                    string[] nameAndMoney = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Person person = new Person(nameAndMoney[0], decimal.Parse(nameAndMoney[1]));

                    people.Add(person);
                }

                string[] productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
               
                foreach (string pair in productsInfo)
                {
                    string[] nameAndPrice = pair.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Product product = new Product(nameAndPrice[0], decimal.Parse(nameAndPrice[1]));

                    products.Add(product);
                }

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

                return;
            }

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] personAndProduct = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personAndProduct[0];
                string productName = personAndProduct[1];

                Person person = people.FirstOrDefault(x => x.Name == personName);
                Product product = products.FirstOrDefault(x => x.Name == productName);

                if(person != null && product != null)
                {
                    Console.WriteLine(person.Add(product));

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}