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
        private string _address;

        private static int _nextId = 0;

        public Customer(string fullname, string address) {
            this._id = _nextId;
            Fullname = fullname;
            Address = address;

            _nextId++;
        }

        public int Id { get { return this._id; } }
        public string Fullname {
            set { ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname)); this._fullname = value; }
            get { return this._fullname; }
        }
        public string Address {
            set { ValueValidator.AssertStringOnLength(value, 500, nameof(Address)); this._address = value; }
            get { return this._address; }
        }
    }
}
