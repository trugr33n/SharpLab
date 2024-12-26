namespace OOPproject.View.Tabs
{
    partial class CartsTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            ItemsListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddToCartButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            CustomerComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            CartListBox = new ListBox();
            label2 = new Label();
            PriceLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            DiscountsCheckedListBox = new CheckedListBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            DiscountPriceLabel = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            TotalPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 270;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(270, 450);
            splitContainer2.SplitterDistance = 394;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 17;
            ItemsListBox.Location = new Point(3, 21);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(264, 370);
            ItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(AddToCartButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(270, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(3, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(115, 46);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButtonPressed;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(PriceLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.80442F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8041611F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.34077549F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.67964125F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.74111F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6299229F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9999685F));
            tableLayoutPanel2.Size = new Size(526, 450);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.73077F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.26923F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(CustomerComboBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(520, 38);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 38);
            label1.TabIndex = 0;
            label1.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Dock = DockStyle.Fill;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(90, 3);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(427, 23);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBoxIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CartListBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(3, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 96);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cart";
            // 
            // CartListBox
            // 
            CartListBox.Dock = DockStyle.Fill;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(3, 19);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(514, 74);
            CartListBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(461, 146);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Dock = DockStyle.Right;
            PriceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(373, 170);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(150, 34);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "PriceLabel";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(CreateOrderButton, 0, 0);
            tableLayoutPanel4.Controls.Add(RemoveItemButton, 2, 0);
            tableLayoutPanel4.Controls.Add(ClearCartButton, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 207);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(520, 37);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Dock = DockStyle.Fill;
            CreateOrderButton.Location = new Point(3, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(98, 31);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButtonPressed;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(315, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(98, 31);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButtonPressed;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Dock = DockStyle.Fill;
            ClearCartButton.Location = new Point(419, 3);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(98, 31);
            ClearCartButton.TabIndex = 2;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButtonPressed;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(3, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(520, 136);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discounts";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(DiscountsCheckedListBox, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 21);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(514, 112);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.BackColor = SystemColors.Menu;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.Dock = DockStyle.Fill;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(3, 3);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(379, 106);
            DiscountsCheckedListBox.TabIndex = 0;
            DiscountsCheckedListBox.SelectedValueChanged += DiscountsCheckedListBoxValueChanged;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(DiscountPriceLabel, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(388, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel6.Size = new Size(123, 106);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 0;
            label3.Text = "Discount Amount:";
            // 
            // DiscountPriceLabel
            // 
            DiscountPriceLabel.AutoSize = true;
            DiscountPriceLabel.Dock = DockStyle.Right;
            DiscountPriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountPriceLabel.Location = new Point(54, 15);
            DiscountPriceLabel.Name = "DiscountPriceLabel";
            DiscountPriceLabel.Size = new Size(66, 91);
            DiscountPriceLabel.TabIndex = 1;
            DiscountPriceLabel.Text = "D.P.L.";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(TotalPriceLabel, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 392);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.Size = new Size(520, 55);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(457, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 0;
            label4.Text = "TOTAL:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Dock = DockStyle.Right;
            TotalPriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalPriceLabel.Location = new Point(330, 22);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(187, 33);
            TotalPriceLabel.TabIndex = 1;
            TotalPriceLabel.Text = "TotalPriceLabel";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "CartsTab";
            Text = "CartsTab";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddToCartButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private ComboBox CustomerComboBox;
        private GroupBox groupBox2;
        private ListBox CartListBox;
        private Label label2;
        private Label PriceLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckedListBox DiscountsCheckedListBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private Label DiscountPriceLabel;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private Label TotalPriceLabel;
    }
}