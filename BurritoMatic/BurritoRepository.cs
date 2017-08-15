using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    public class BurritoRepository
    {
        private static List<BaseBurrito> _list = new List<BaseBurrito>();

        public decimal CreateBurritoOrder(BaseBurrito burrito)
        {
            _list.Add(burrito);
            return burrito.Price;
        }

        public int AddBurritoOrder(BaseBurrito burrito)
        {
            _list.Add(burrito);
            return burrito.ID;
        }

        public decimal GetFinalPrice(int id)
        {
           return _list.Find(l => l.ID == id).Price;
        }

       public BaseBurrito GetAllIngredients(int id)
        {
            return _list.Find(l => l.ID == id);
        }
    }
}
//public List<BaseBurrito> GetAllIngredients(int[] ids)
//{
//    List<BaseBurrito> burritos = new List<BaseBurrito>();
//    foreach (int id in ids)
//    {
//        var burr = _list.Find(l => l.ID == id);
//        burritos.Add(burr);
//    }
//    return burritos;
//}