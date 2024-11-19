using OOPproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        private static int _nextId = 0;


        public Item(string name, string info, decimal cost) {
            this._id = _nextId;
            Name = name;
            Info = info;
            Cost = cost;

            _nextId++;
        }

        public int Id { 
            get { return this._id; }
        }

        public string Name { 
            get { return this._name; }
            set { ValueValidator.AssertStringOnLength(value, 200, nameof(Name)); this._name = value; }
        }

        public string Info { 
            get { return this._info; }
            set { ValueValidator.AssertStringOnLength(value, 1000, nameof(Info)); this._info = value; }
        }

        public decimal Cost { 
            get { return this._cost; }
            set { if (value >= 0 && value <= 100000) { this._cost = value; } }
        }
    }
}
