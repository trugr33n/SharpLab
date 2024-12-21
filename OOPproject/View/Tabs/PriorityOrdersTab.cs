using OOPproject.Model;
using OOPproject.Model.Enums;
using OOPproject.Services;
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
    public partial class PriorityOrdersTab : Form
    {
        private AddressControl _addressControl = new AddressControl();
        private PriorityOrder _priorityOrder;
        private List<Item> _items = new List<Item>();
        private Cart _cart = new Cart();
        private OrderStatus _priorityOrderStatus;
        private Address _address;


        public PriorityOrdersTab()
        {
            InitializeComponent();
            AddressControlInit();
            ComboBoxesInit();
        }

        private void AddressControlInit()
        {
            _addressControl.TopLevel = false;
            _addressControl.FormBorderStyle = FormBorderStyle.None;
            _addressControl.Dock = DockStyle.Fill;
            DeliverAddressTemplatePanel.Controls.Add(_addressControl);
            _addressControl.Show();
        }
        private void ComboBoxesInit()
        {
            foreach (OrderStatus thing in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(thing);
            }
        }

        private void UpdateListBox()
        {
            OrderItemsListBox.Items.Clear();
            foreach (var thing in _items)
            {
                OrderItemsListBox.Items.Add(thing.Name);
            }
            PriceLabel.Text = _cart.Amount.ToString();
        }

        private void OnAddItemButtonPressed(object sender, EventArgs e)
        {
            Item interimItem = ItemGenerator.GenerateItem(_items);
            _items.Add(interimItem);
            OrderItemsListBox.Items.Add(interimItem.Name);
            _cart.Items.Add(interimItem);
            PriceLabel.Text = _cart.Amount.ToString();
        }

        private void OnRemoveItemButtonPressed(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                _cart.Items.Remove(_cart.Items[OrderItemsListBox.SelectedIndex]);
                _items.Remove(_items[OrderItemsListBox.SelectedIndex]);
                UpdateListBox();
            }
        }

        private void OnClearOrderButtonPressed(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            _cart.Items.Clear();
            PriceLabel.Text = _cart.Amount.ToString();
        }

        private void StatusSelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1) {
                _priorityOrderStatus = (OrderStatus)StatusComboBox.Items[StatusComboBox.SelectedIndex];
            }
        }
    }
}
