using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    public class _3_IngredientBurrito : _2_IngredientBurrito
    {
        public _3_IngredientBurrito()
        {
            base._defaultPrice = 5.99m;
        }

        public Toppings Topping { get; set; }

        public override decimal Price
        {
            get
            {
                if (Salsa == Salsa.Queso)
                {
                    _defaultPrice += 1.50m;
                }
                if (Topping == Toppings.Guacomole)
                {
                    _defaultPrice += 1.25m;
                }

                return _defaultPrice;
            }
        }

        public override string ToString()
        {
            return base.ToString() +", " + Topping.ToString();
        }
    }
}
