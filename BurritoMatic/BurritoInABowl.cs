using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    public class BurritoInABowl : BaseBurrito
    {
        public BurritoInABowl()
        {
            _torilla = false;
            base._defaultPrice = 3.99m;
        }        

        public Meat Meat { get; set; }

        public Salsa Salsa { get; set; }

        public override decimal Price
        {
            get           
            {               
                if (Salsa == Salsa.Queso )
                {
                    _defaultPrice += 1.50m;
                }
               
                return _defaultPrice;
            }
        }

        public override string ToString()
        {
            return (base._torilla ? "Tortilla, " : "") + (base.Rice ? "Rice, " : "") + Meat.ToString() + ", " + (Salsa == Salsa.Queso ? "Queso" : Salsa.ToString() + " Salsa");
        }
    }
}
