using PizzaCalories.Models;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string[] doughtInfo = Console.ReadLine().Split();
                string pizzaName = pizzaInfo[1];
                Dough dough = new Dough(doughtInfo[1], doughtInfo[2], double.Parse(doughtInfo[3]));
                Pizza pizza = new Pizza(pizzaName, dough);
                string toppings = Console.ReadLine();
                while(toppings != "END")
                {
                    string[] toppingInfo = toppings.Split();
                    Topping topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                    pizza.AddTopping(topping);
                    toppings = Console.ReadLine();                   
                }
                Console.WriteLine(pizza);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}