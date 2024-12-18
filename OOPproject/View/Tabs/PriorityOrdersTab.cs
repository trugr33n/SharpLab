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

        public PriorityOrdersTab()
        {
            InitializeComponent();
            AddressControlInit();
        }

        private void AddressControlInit() {
            _addressControl.TopLevel = false;
            _addressControl.FormBorderStyle = FormBorderStyle.None;
            _addressControl.Dock = DockStyle.Fill;
            DeliverAddressTemplatePanel.Controls.Add( _addressControl );
            _addressControl.Show();
        }
    }
}
