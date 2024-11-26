using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        public Store() {
            _items = new();
            _customers = new();
        }

        public List<Item> Items {
            get { return _items; }
            set { _items = value; }
        }

        public List<Customer> Customers { 
            get { return _customers; }
            set { _customers = value; }
        }
    }
}
