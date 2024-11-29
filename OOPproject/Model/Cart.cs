using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Cart
    {
        private List<Item> _items = new();
        public List<Item> Items { 
            get { return _items; }
            set { _items = value; }
        }

        public decimal Amount {
            get {
                if (_items.Count == 0) {
                    return 0;
                }

                decimal _amount = 0;
                foreach (Item e in _items) { 
                    _amount += e.Cost;
                } 
                return _amount;
            }
        }
    }
}
