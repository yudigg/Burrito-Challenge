using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
   public abstract class BaseBurrito
    {
        public BaseBurrito()
        {
            _id++;
            ID = _id;
        }
        private static int  _id = 0;

        public int ID { get; set; }

        protected bool _torilla { get; set; }

        public bool Rice { get; set; }

        protected decimal _defaultPrice { get; set; }

        public abstract decimal Price { get; }//private?
    }
}
