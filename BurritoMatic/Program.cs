using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> IdList = new List<int>();
            decimal totalPrice = 0m;       
            BurritoRepository br = new BurritoRepository();
            IdList.Add(br.AddBurritoOrder(new BurritoInABowl { Meat = Meat.Chicken, Rice = true, Salsa = Salsa.Green }));
            IdList.Add(br.AddBurritoOrder(new _2_IngredientBurrito { Meat = Meat.Chicken, Rice = true, Salsa = Salsa.Queso }));
            IdList.Add(br.AddBurritoOrder(new _3_IngredientBurrito { Meat = Meat.Chicken, Rice = true, Salsa = Salsa.Green, Topping = Toppings.Guacomole }));

            foreach (int id in IdList)
            {
                decimal price = br.GetFinalPrice(id);
                totalPrice += price;
                var ingredients = br.GetAllIngredients(id);
                Console.WriteLine(ingredients + " -- Price:" + price.ToString("C"));          
            }
       
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Total Price:" + totalPrice.ToString("C"));
         
            Console.ReadKey(true);
        }
    }
}
