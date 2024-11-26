using OOPproject.Model;
using OOPproject.View.Tabs;
using System.Drawing.Text;
using System.Windows.Forms;

namespace OOPproject
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Бизнес приложение \"Барабудайка\"";
            this.Size = new Size(1280, 720);

            ItemsTab itemsTab = new ItemsTab();
            itemsTab.TopLevel = false;
            itemsTab.FormBorderStyle = FormBorderStyle.None;
            itemsTab.Dock = DockStyle.Fill;
            TabController.TabPages[0].Controls.Add(itemsTab);
            itemsTab.Show();

            CustomersTab customersTab = new CustomersTab();
            customersTab.TopLevel = false;
            customersTab.FormBorderStyle = FormBorderStyle.None;
            customersTab.Dock = DockStyle.Fill;
            TabController.TabPages[1].Controls.Add(customersTab);
            customersTab.Show();

            _store = new Store();
            _store.Items = itemsTab.Items;
            _store.Customers = customersTab.Customers;
        }
    }
}
