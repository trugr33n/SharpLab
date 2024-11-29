using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Order
    {
        private readonly int _id;
        private readonly string _deliveryDate;
        private Cart _cart;
        private Address _deliveryAddress;
        private decimal _totalPrice;

        private static int _nextId = 0;

        public Order(string deliveryDate, Cart cart, Address deliveryAddress) { 
            this._id = _nextId;
            this._deliveryDate = deliveryDate;
            Cart = cart;
            DeliveryAddress = deliveryAddress;

            _nextId++;
        }

        public int Id { get { return this._id; } }
        public string DeliveryDate { get { return this._deliveryDate; } }
        public Cart Cart { get { return this._cart; } set { this._cart = value; this._totalPrice = value.Amount; } }
        public Address DeliveryAddress { get { return this._deliveryAddress; } set { this._deliveryAddress = value; } }
        public decimal TotalPrice { get { return this._totalPrice; } }
        

    }
}
