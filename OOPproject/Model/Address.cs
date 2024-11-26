using OOPproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject.Model
{
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public Address(int index, string country, string city, string street, string building, string apartment) { 
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public Address() { 
            Index = 0;
            Country = "Empty";
            City = "Empty";
            Street = "Empty";
            Building = "Empty";
            Apartment = "Empty";
        }

        public int Index { 
            set { if (value > 0 && value <= 999_999) { this._index = value; } }
            get { return this._index; }
        }
        public string Country {
            set { ValueValidator.AssertStringOnLength(value, 51, nameof(Country)); this._country = value; }
            get { return this._country; }
        }
        public string City {
            set { ValueValidator.AssertStringOnLength(value, 51, nameof(City)); this._city = value; }
            get { return this._city; }
        }
        public string Street {
            set { ValueValidator.AssertStringOnLength(value, 101, nameof(Street)); this._street = value; }
            get { return this._street; }
        }
        public string Building {
            set { ValueValidator.AssertStringOnLength(value, 11, nameof(Building)); this._building = value; }
            get { return this._building; }
        }
        public string Apartment
        {
            set { ValueValidator.AssertStringOnLength(value, 11, nameof(Apartment)); this._apartment = value; }
            get { return this._apartment; }
        }
    }
}
