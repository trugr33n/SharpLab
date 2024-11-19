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
    public partial class ItemsTab : Form
    {
        List<Item> _items = new();

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (!IsValidItem())
            {
                return; // Выходим, если данные не валидны
            }

            Item stackedItem = new Item(NameTextBox.Text, DescripTextBox.Text, Convert.ToDecimal(CostTextBox.Text));

            // Если данные валидны, добавляем элемент в список
            this._items.Add(stackedItem);
            ItemsListBox.Items.Add(stackedItem.Name);

            // Очищаем текстовые поля
            ClearTextBoxes();


        }

        private void OnRemoveButtonPressed(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                this._items.RemoveAt(selectedIndex);
                ItemsListBox.Items.RemoveAt(selectedIndex);

                IdTextBox.Clear();
                NameTextBox.Clear();
                DescripTextBox.Clear();
                CostTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }

        private void IndexInBoxChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                IdTextBox.Text = Convert.ToString(this._items[ItemsListBox.SelectedIndex].Id);
                NameTextBox.Text = this._items[ItemsListBox.SelectedIndex].Name;
                DescripTextBox.Text = this._items[ItemsListBox.SelectedIndex].Info;
                CostTextBox.Text = Convert.ToString(_items[ItemsListBox.SelectedIndex].Cost);
            }
        }

        private bool IsValidItem()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(DescripTextBox.Text))
            {
                DescripTextBox.BackColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(CostTextBox.Text))
            {
                CostTextBox.BackColor = Color.Red;
                isValid = false;
            }

            return isValid;
        }

        private void ClearBackgroundColors()
        {
            NameTextBox.BackColor = SystemColors.Window;
            DescripTextBox.BackColor = SystemColors.Window;
            CostTextBox.BackColor = SystemColors.Window;
        }

        private void ClearTextBoxes()
        {
            NameTextBox.Clear();
            DescripTextBox.Clear();
            CostTextBox.Clear();
        }
    }
}
