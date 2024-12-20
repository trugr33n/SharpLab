using OOPproject.Model.Enums;
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
        private readonly DateTime _deliveryDate;
        private readonly string _fullname;
        private Cart _cart;
        private Address _deliveryAddress;
        private decimal _totalPrice;
        private OrderStatus _status;

        private static int _nextId = 0;

        public Order(DateTime deliveryDate, Cart cart, Address deliveryAddress, string fullName) {
            this._id = _nextId;
            this._deliveryDate = deliveryDate;
            Cart = cart;
            DeliveryAddress = deliveryAddress;
            this._fullname = fullName;

            _nextId++;
        }

        /*public Order() { 
            this._id = _nextId;
            this._deliveryDate = DateTime.Now;
            Cart = new Cart();
            DeliveryAddress = new Address();
            this._fullname = "Null Name Subject";

            _nextId++;
        }*/

        public int Id { get { return this._id; } }
        public DateTime DeliveryDate { get { return this._deliveryDate; } }
        public Cart Cart { get { return this._cart; } set { this._cart = value; this._totalPrice = value.Amount; } }
        public Address DeliveryAddress { get { return this._deliveryAddress; } set { this._deliveryAddress = value; } }
        public decimal TotalPrice { get { return this._totalPrice; } }
        public OrderStatus Status { get { return this._status; } set { this._status = value; } }
        public String FullName { get { return this._fullname; } }
        

    }
}
