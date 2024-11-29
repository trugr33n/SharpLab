using OOPproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private Address _address;
        private Cart _cart;
        private List<Order> _order;

        private static int _nextId = 0;

        public Customer(string fullname) {
            this._id = _nextId;
            Fullname = fullname;
            Cart = new(); 
            Order = new();

            _nextId++;
        }

        public int Id { get { return this._id; } }
        public string Fullname {
            set { ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname)); this._fullname = value; }
            get { return this._fullname; }
        }
        public Address Address {
            get { return this._address;}
            set { this._address = value; } 
        }
        public Cart Cart {
            get { return this._cart; }
            set { this._cart = value; }
        }
        public List<Order> Order {
            get { return this._order; }
            set { this._order = value; }
        }
    }
}
