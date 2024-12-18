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
    public partial class CartsTab : Form
    {
        private List<Customer> _customers;
        private List<Item> _items;
        private Customer _currentCustomer;
        private Store _store = new Store();

        public CartsTab()
        {
            InitializeComponent();
        }

        private Customer CurrentCustomer
        {
            get { return this._currentCustomer; }
            set { this._currentCustomer = value; }
        }
        public List<Customer> Customers
        {
            get { return this._customers; }
            set { this._customers = value; }
        }
        public List<Item> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        private void ItemsInit()
        {
            ItemsListBox.Items.Clear();
            if (Items != null)
            {
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
            }
        }
        private void ItemsUpdate()
        {
            if (CurrentCustomer != null)
            {
                CartListBox.Items.Clear();
                foreach (var cstmItems in CurrentCustomer.Cart.Items)
                {
                    CartListBox.Items.Add(cstmItems.Name);
                }
                PriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }
        private void CustomersInit()
        {
            CustomerComboBox.Items.Clear();
            if (Customers != null)
            {
                foreach (var cstmr in _customers)
                {
                    CustomerComboBox.Items.Add(cstmr.Fullname);
                }
            }
        }

        public void RefreshData()
        {
            ItemsListBox.SelectedIndex = -1;
            PriceLabel.Text = "0";
            CustomersInit();
            ItemsInit();
        }

        private void CustomerComboBoxIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
                ItemsUpdate();
            }
        }

        private void AddToCartButtonPressed(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                if (_currentCustomer != null)
                {
                    CurrentCustomer.Cart.Items.Add(_items[ItemsListBox.SelectedIndex]);
                    ItemsUpdate();
                }
            }
            else { return; }
        }

        private void CreateOrderButtonPressed(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CartListBox.Items.Count != 0)
            {
                Cart cart = new Cart();
                foreach (var item in CurrentCustomer.Cart.Items)
                {
                    cart.Items.Add((Item)item);
                }
                Order newOrder = new Order(DateTime.Now, cart, CurrentCustomer.Address, CurrentCustomer.Fullname);
                CurrentCustomer.Order.Add(newOrder);
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
                CustomerComboBox.SelectedIndex = -1;
                PriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else { return; }
        }

        private void RemoveItemButtonPressed(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                if (_currentCustomer != null)
                {
                    CurrentCustomer.Cart.Items.Remove(_items[CartListBox.SelectedIndex]);
                    ItemsUpdate();
                }
            }
        }

        private void ClearCartButtonPressed(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
                PriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else { return; }
        }
    }
}
