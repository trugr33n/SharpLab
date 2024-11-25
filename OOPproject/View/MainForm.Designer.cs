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
            TabController.SuspendLayout();
            SuspendLayout();
            // 
            // TabController
            // 
            TabController.Controls.Add(ItemPage);
            TabController.Controls.Add(CustomerPage);
            TabController.Dock = DockStyle.Fill;
            TabController.Location = new Point(0, 0);
            TabController.Name = "TabController";
            TabController.SelectedIndex = 0;
            TabController.Size = new Size(800, 450);
            TabController.TabIndex = 0;
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
    }
}
