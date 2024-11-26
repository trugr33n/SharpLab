using OOPproject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPproject.View.Controls
{
    public partial class AddressControl : Form
    {

        private Address _address;

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
            FillBoxes();
        }

        public Address GetAddress
        {
            get
            {
                return new Address(

                    ContentInIndexBox(),
                    CountryTextBox.Text,
                    CityTextBox.Text,
                    StreetTextBox.Text,
                    BuildingTextBox.Text,
                    ApartmentTextBox.Text);
            }
        }
        public Address SetAddress
        {
            set
            {
                _address = value;
                PostIndexTextBox.Text = _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
        }

        public void ClearBoxes()
        {
            PostIndexTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StreetTextBox.Text = string.Empty;
            BuildingTextBox.Text = string.Empty;
            ApartmentTextBox.Text = string.Empty;
        }

        public void FillBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }
        public bool IsValidItem()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(PostIndexTextBox.Text))
            {
                PostIndexTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите ваш почтовый индекс числами");
            }
            if (string.IsNullOrWhiteSpace(CountryTextBox.Text))
            {
                CountryTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите вашу страну");
            }
            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                CityTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите ваш город");
            }
            if (string.IsNullOrWhiteSpace(StreetTextBox.Text))
            {
                StreetTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите вашу улицу");
            }
            if (string.IsNullOrWhiteSpace(BuildingTextBox.Text))
            {
                BuildingTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите номер вашего дома");
            }
            if (string.IsNullOrWhiteSpace(ApartmentTextBox.Text))
            {
                ApartmentTextBox.BackColor = Color.Red;
                isValid = false;
                MessageBox.Show("Введите номер вашей квартиры");
            }

            return isValid;
        }

        public void DecolorizeBoxes()
        {
            PostIndexTextBox.BackColor = SystemColors.Window;
            CountryTextBox.BackColor = SystemColors.Window;
            CityTextBox.BackColor = SystemColors.Window;
            StreetTextBox.BackColor = SystemColors.Window;
            BuildingTextBox.BackColor = SystemColors.Window;
            ApartmentTextBox.BackColor = SystemColors.Window;
        }

        private int ContentInIndexBox()
        {
            int contented;
            if (int.TryParse(PostIndexTextBox.Text, out contented))
            {
                return contented;
            }
            else { MessageBox.Show("Введенный индекс не является числом"); return 0; }
        }
    }
}
