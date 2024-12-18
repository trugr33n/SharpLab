namespace OOPproject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabController = new TabControl();
            ItemPage = new TabPage();
            CustomerPage = new TabPage();
            CartPage = new TabPage();
            OrdersPage = new TabPage();
            PriorityOrderPage = new TabPage();
            TabController.SuspendLayout();
            SuspendLayout();
            // 
            // TabController
            // 
            TabController.Controls.Add(ItemPage);
            TabController.Controls.Add(CustomerPage);
            TabController.Controls.Add(CartPage);
            TabController.Controls.Add(OrdersPage);
            TabController.Controls.Add(PriorityOrderPage);
            TabController.Dock = DockStyle.Fill;
            TabController.Location = new Point(0, 0);
            TabController.Name = "TabController";
            TabController.SelectedIndex = 0;
            TabController.Size = new Size(800, 450);
            TabController.TabIndex = 0;
            TabController.SelectedIndexChanged += TabChanged;
            // 
            // ItemPage
            // 
            ItemPage.Location = new Point(4, 24);
            ItemPage.Name = "ItemPage";
            ItemPage.Padding = new Padding(3);
            ItemPage.Size = new Size(792, 422);
            ItemPage.TabIndex = 0;
            ItemPage.Text = "Items";
            ItemPage.UseVisualStyleBackColor = true;
            // 
            // CustomerPage
            // 
            CustomerPage.Location = new Point(4, 24);
            CustomerPage.Name = "CustomerPage";
            CustomerPage.Size = new Size(792, 422);
            CustomerPage.TabIndex = 1;
            CustomerPage.Text = "Customers";
            CustomerPage.UseVisualStyleBackColor = true;
            // 
            // CartPage
            // 
            CartPage.Location = new Point(4, 24);
            CartPage.Name = "CartPage";
            CartPage.Padding = new Padding(3);
            CartPage.Size = new Size(792, 422);
            CartPage.TabIndex = 2;
            CartPage.Text = "Cart";
            CartPage.UseVisualStyleBackColor = true;
            // 
            // OrdersPage
            // 
            OrdersPage.Location = new Point(4, 24);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Size = new Size(792, 422);
            OrdersPage.TabIndex = 3;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrderPage
            // 
            PriorityOrderPage.Location = new Point(4, 24);
            PriorityOrderPage.Name = "PriorityOrderPage";
            PriorityOrderPage.Padding = new Padding(3);
            PriorityOrderPage.Size = new Size(792, 422);
            PriorityOrderPage.TabIndex = 4;
            PriorityOrderPage.Text = "Prority Order";
            PriorityOrderPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabController);
            Name = "MainForm";
            Text = "Form1";
            TabController.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabController;
        private TabPage ItemPage;
        private TabPage CustomerPage;
        private TabPage CartPage;
        private TabPage OrdersPage;
        private TabPage PriorityOrderPage;
    }
}
