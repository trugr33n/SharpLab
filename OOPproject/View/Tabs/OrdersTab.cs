using OOPproject.Model;
using OOPproject.Model.Enums;
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
    public partial class OrdersTab : Form
    {
        private AddressControl _addressControl = new AddressControl();
        private List<Customer> _customers = new();
        private List<Order> _orders = new();

        public OrdersTab()
        {
            InitializeComponent();
            AddressControlInit();
            ComboBoxInit();
        }

        public List<Customer> Customers { get { return this._customers; } set { this._customers = value; } }

        public void DataGridInit()
        {

            foreach (var thing in Customers)
            {
                foreach (var orderThing in thing.Order)
                {
                    _orders.Add(orderThing);
                }
            }

            if (_orders.Count > 0)
            {
                CustomersOrderList.Rows.Clear();

                for (int i = 0; i < _orders.Count; i++)
                {
                    DataGridViewRow interimRow = new DataGridViewRow();
                    interimRow.CreateCells(CustomersOrderList);

                    interimRow.Cells[0].Value = _orders[i].Id;
                    interimRow.Cells[1].Value = _orders[i].DeliveryDate;
                    interimRow.Cells[2].Value = _orders[i].Status;
                    interimRow.Cells[3].Value = _orders[i].FullName;
                    interimRow.Cells[4].Value = _orders[i].DeliveryAddress.City + "," + _orders[i].DeliveryAddress.Street + "," + _orders[i].DeliveryAddress.Building;
                    interimRow.Cells[5].Value = _orders[i].Cart.Amount;

                    CustomersOrderList.Rows.Add(interimRow);
                }
            }
        }

        private void AddressControlInit()
        {
            _addressControl.TopLevel = false;
            _addressControl.FormBorderStyle = FormBorderStyle.None;
            _addressControl.Dock = DockStyle.Fill;
            AddressPanel.Controls.Add(_addressControl);
            _addressControl.Show();
        }

        private void ComboBoxInit()
        {
            foreach (OrderStatus thing in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(thing);
            }
        }

        private void OnCustomersOrderListDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            int currentCellIndex = CustomersOrderList.CurrentCell.RowIndex;
            if (_orders.Count - 1 >= currentCellIndex)
            {
                IdTextBox.Text = _orders[currentCellIndex].Id.ToString();
                StatusComboBox.SelectedIndex = currentCellIndex;
                CreatedTextBox.Text = _orders[currentCellIndex].DeliveryDate.ToString();
                _addressControl.SetAddress = _orders[currentCellIndex].DeliveryAddress;
                PriceLabel.Text = _orders[currentCellIndex].Cart.Amount.ToString();

                ItemsListBox.Items.Clear();
                for (int i = 0; i < _orders[currentCellIndex].Cart.Items.Count; i++)
                {
                    ItemsListBox.Items.Add(_orders[currentCellIndex].Cart.Items[i].Name + " with price: " + _orders[currentCellIndex].Cart.Items[i].Cost.ToString());
                }
            }
        }

        private void StatusComboBoxIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex != -1) {
                int currentCellIndex = CustomersOrderList.CurrentCell.RowIndex;
                _orders[currentCellIndex].Status = (OrderStatus)StatusComboBox.Items[StatusComboBox.SelectedIndex];
            }
        }
    }
}
