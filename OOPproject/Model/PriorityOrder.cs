using OOPproject.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class PriorityOrder : Order {

        public DateTime WishDate { get; set; }
        public Wishdate WishTime { get; set; }


        public PriorityOrder(DateTime deliveryDate, Cart cart, Address deliveryAddress, string fullname, DateTime wishDate, Wishdate wishTime) : 
            base(deliveryDate, cart, deliveryAddress, fullname) { 
            WishDate = wishDate;
            WishTime = wishTime;
        }

    }
}
