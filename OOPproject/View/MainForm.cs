using OOPproject.Model;
using OOPproject.View.Tabs;
using System.Drawing.Text;
using System.Windows.Forms;

namespace OOPproject
{
    public partial class MainForm : Form
    {
        private Store _store;
        private ItemsTab itemsTab = new ItemsTab();
        private CustomersTab customersTab = new CustomersTab();
        private CartsTab cartsTab = new CartsTab();
        private OrdersTab ordersTab = new OrdersTab();
        private PriorityOrdersTab priorityOrdersTab = new PriorityOrdersTab();

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Бизнес приложение \"Барабудайка\"";
            this.Size = new Size(1280, 720);
            
            itemsTab.TopLevel = false;
            itemsTab.FormBorderStyle = FormBorderStyle.None;
            itemsTab.Dock = DockStyle.Fill;
            TabController.TabPages[0].Controls.Add(itemsTab);
            itemsTab.Show();
            
            customersTab.TopLevel = false;
            customersTab.FormBorderStyle = FormBorderStyle.None;
            customersTab.Dock = DockStyle.Fill;
            TabController.TabPages[1].Controls.Add(customersTab);
            customersTab.Show();
            
            cartsTab.TopLevel = false;
            cartsTab.FormBorderStyle = FormBorderStyle.None;
            cartsTab.Dock = DockStyle.Fill;
            TabController.TabPages[2].Controls.Add(cartsTab);
            cartsTab.Show();

            ordersTab.TopLevel = false;
            ordersTab.FormBorderStyle = FormBorderStyle.None;
            ordersTab.Dock = DockStyle.Fill;
            TabController.TabPages[3].Controls.Add(ordersTab);
            ordersTab.Show();

            priorityOrdersTab.TopLevel = false;
            priorityOrdersTab.FormBorderStyle = FormBorderStyle.None;
            priorityOrdersTab.Dock = DockStyle.Fill;
            TabController.TabPages[4].Controls.Add(priorityOrdersTab);
            priorityOrdersTab.Show();

            _store = new Store();
            _store.Items = itemsTab.Items;
            _store.Customers = customersTab.Customers;

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;

            ordersTab.Customers = _store.Customers;
        }

        private void TabChanged(object sender, EventArgs e)
        {
            switch (TabController.SelectedIndex) {
                case 2: cartsTab.RefreshData(); break;
                case 3: ordersTab.DataGridInit(); break;
            }
        }
    }
}
