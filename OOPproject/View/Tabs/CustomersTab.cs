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

namespace OOPproject.View.Tabs
{
    public partial class CustomersTab : Form
    {
        List<Customer> _customers = new();

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void OnAddButtonPressed(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (!IsValidItem())
            {
                return; // Выходим, если данные не валидны
            }

            Customer stackedCustomer = new Customer(FullnameTextBox.Text);

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

                IdTextBox.Text = selectedCustomer.ToString();
                FullnameTextBox.Text = selectedCustomer.Fullname;
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
        }

        private void ClearTextBoxes()
        {
            FullnameTextBox.Clear();
        }
    }
}
