using OOPproject.Model;
using OOPproject.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPproject.View.Tabs
{
    public partial class CustomersTab : Form
    {
        private List<Customer> _customers = new();
        private AddressControl addressControl = new AddressControl();
        //private int _previousCustomer;

        public CustomersTab()
        {
            InitializeComponent();

            addressControl.TopLevel = false;
            addressControl.FormBorderStyle = FormBorderStyle.None;
            addressControl.Dock = DockStyle.Fill;
            //TabController.TabPages[1].Controls.Add(customersTab);
            AddressFaceContainer.Controls.Add(addressControl);
            addressControl.Show();
        }

        private void OnAddButtonPressed(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (!IsValidItem() && !addressControl.IsValidItem())
            {
                return; // Выходим, если данные не валидны
            }

            Customer stackedCustomer = new Customer(FullnameTextBox.Text);

            stackedCustomer.Address = addressControl.GetAddress;

            // Если данные валидны, добавляем элемент в список
            this._customers.Add(stackedCustomer);
            CustomersListBox.Items.Add(stackedCustomer.Fullname);

            // Очищаем текстовые поля
            ClearTextBoxes();

        }

        private void OnRemoveButtonPressed(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (CustomersListBox.SelectedIndex >= 0)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                this._customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);


                IdTextBox.Clear();
                FullnameTextBox.Clear();
                addressControl.ClearBoxes();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }

        }

        private void IndexInBoxChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                ClearBackgroundColors();

                var selectedCustomer = this._customers[CustomersListBox.SelectedIndex];

                IdTextBox.Text = selectedCustomer.Id.ToString();
                FullnameTextBox.Text = selectedCustomer.Fullname;
                addressControl.SetAddress = selectedCustomer.Address;
                //_previousCustomer = CustomersListBox.SelectedIndex;
            }
        }

        private bool IsValidItem()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FullnameTextBox.Text))
            {
                FullnameTextBox.BackColor = Color.Red;
                isValid = false;
            }

            return isValid;
        }

        private void ClearBackgroundColors()
        {
            FullnameTextBox.BackColor = SystemColors.Window;
            addressControl.DecolorizeBoxes();
        }

        private void ClearTextBoxes()
        {
            FullnameTextBox.Clear();
            addressControl.ClearBoxes();
        }

        private void MouseDownInCustomerListBox(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CustomersListBox.ClearSelected();
            }
        }

        private void AddressControlLeaved(object sender, EventArgs e)
        {
            var selectedCustomer = this._customers[CustomersListBox.SelectedIndex];
            selectedCustomer.Address = addressControl.GetAddress;
        }
    }
}
