using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPproject.Model.Enums;

namespace OOPproject.View.Controls
{
    public partial class AddDiscountPopup : Form
    {
        private Category _category;

        public AddDiscountPopup()
        {
            InitializeComponent();
        }

        public Category Category { get { return this._category; } }

        private void AddDiscountPopupLoaded(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void OkButtonPressed(object sender, EventArgs e)
        {
            this._category = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonPressed(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
