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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPproject.View.Tabs
{
    public partial class ItemsTab : Form
    {
        List<Item> _items = new();

        public ItemsTab()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category.StoreCategory));
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (!IsValidItem())
            {
                return; // Выходим, если данные не валидны
            }

            Item stackedItem = new Item(NameTextBox.Text, DescripTextBox.Text, Convert.ToDecimal(CostTextBox.Text));

            stackedItem.ItemCategory = (Category.StoreCategory)CategoryComboBox.SelectedItem;

            // Если данные валидны, добавляем элемент в список
            this._items.Add(stackedItem);
            ItemsListBox.Items.Add(stackedItem.Name);

            // Очищаем текстовые поля
            ClearTextBoxes();


        }

        private void OnRemoveButtonPressed(object sender, EventArgs e)
        {
            ClearBackgroundColors();

            if (ItemsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                this._items.RemoveAt(selectedIndex);
                ItemsListBox.Items.RemoveAt(selectedIndex);

                IdTextBox.Clear();
                NameTextBox.Clear();
                DescripTextBox.Clear();
                CostTextBox.Clear();
                CategoryComboBox.SelectedIndex = -1;
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
                ClearBackgroundColors();

                var selectedItem = this._items[ItemsListBox.SelectedIndex];

                IdTextBox.Text = Convert.ToString(selectedItem.Id);
                NameTextBox.Text = selectedItem.Name;
                DescripTextBox.Text = selectedItem.Info;
                CostTextBox.Text = Convert.ToString(selectedItem.Cost);
                CategoryComboBox.SelectedItem = selectedItem.ItemCategory;
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
            CategoryComboBox.SelectedIndex = -1;
        }

        private void CategoryComboBoxIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                var selectedItem = this._items[ItemsListBox.SelectedIndex];
                selectedItem.ItemCategory = (Category.StoreCategory)CategoryComboBox.SelectedItem;
            }
        }

        private void MouseDownInItemsListBox(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ItemsListBox.ClearSelected();
            }
        }
    }
}
