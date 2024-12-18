namespace OOPproject.View.Tabs
{
    partial class OrdersTab
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
            groupBox1 = new GroupBox();
            CustomersOrderList = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddressPanel = new Panel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IdTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            ItemsListBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            PriceLabel = new Label();
            IdInfo = new DataGridViewTextBoxColumn();
            CreatedInfo = new DataGridViewTextBoxColumn();
            OrderStatusInfo = new DataGridViewTextBoxColumn();
            CustomerFullnameInfo = new DataGridViewTextBoxColumn();
            CustomerAddressInfo = new DataGridViewTextBoxColumn();
            AmountInfo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersOrderList).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomersOrderList);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orders";
            // 
            // CustomersOrderList
            // 
            CustomersOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersOrderList.Columns.AddRange(new DataGridViewColumn[] { IdInfo, CreatedInfo, OrderStatusInfo, CustomerFullnameInfo, CustomerAddressInfo, AmountInfo });
            CustomersOrderList.Dock = DockStyle.Fill;
            CustomersOrderList.Location = new Point(3, 21);
            CustomersOrderList.MultiSelect = false;
            CustomersOrderList.Name = "CustomersOrderList";
            CustomersOrderList.Size = new Size(286, 426);
            CustomersOrderList.TabIndex = 0;
            CustomersOrderList.CellContentClick += OnCustomersOrderListDoubleClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(AddressPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(504, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AddressPanel
            // 
            AddressPanel.Dock = DockStyle.Fill;
            AddressPanel.Location = new Point(3, 115);
            AddressPanel.Name = "AddressPanel";
            AddressPanel.Size = new Size(498, 106);
            AddressPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 106);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Order";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7955093F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.20449F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(IdTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(CreatedTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(StatusComboBox, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 21);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(492, 82);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 27);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(66, 27);
            label2.TabIndex = 1;
            label2.Text = "Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // IdTextBox
            // 
            IdTextBox.Dock = DockStyle.Fill;
            IdTextBox.Location = new Point(75, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(414, 25);
            IdTextBox.TabIndex = 3;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Dock = DockStyle.Fill;
            CreatedTextBox.Location = new Point(75, 30);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(414, 25);
            CreatedTextBox.TabIndex = 4;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Dock = DockStyle.Fill;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(75, 57);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(414, 25);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBoxIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ItemsListBox);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(3, 227);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 106);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 17;
            ItemsListBox.Location = new Point(3, 21);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(492, 82);
            ItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(PriceLabel, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 339);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Size = new Size(498, 108);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(419, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 27);
            label4.TabIndex = 0;
            label4.Text = "Amount:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Dock = DockStyle.Right;
            PriceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(345, 27);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(150, 81);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "PriceLabel";
            // 
            // IdInfo
            // 
            IdInfo.HeaderText = "Id";
            IdInfo.Name = "IdInfo";
            // 
            // CreatedInfo
            // 
            CreatedInfo.HeaderText = "Created";
            CreatedInfo.Name = "CreatedInfo";
            // 
            // OrderStatusInfo
            // 
            OrderStatusInfo.HeaderText = "Order Status";
            OrderStatusInfo.Name = "OrderStatusInfo";
            // 
            // CustomerFullnameInfo
            // 
            CustomerFullnameInfo.HeaderText = "Customer Full Name";
            CustomerFullnameInfo.Name = "CustomerFullnameInfo";
            // 
            // CustomerAddressInfo
            // 
            CustomerAddressInfo.HeaderText = "Customer Address";
            CustomerAddressInfo.Name = "CustomerAddressInfo";
            // 
            // AmountInfo
            // 
            AmountInfo.HeaderText = "Amount";
            AmountInfo.Name = "AmountInfo";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Text = "OrdersTab";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersOrderList).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private DataGridView CustomersOrderList;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel AddressPanel;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IdTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private GroupBox groupBox3;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label PriceLabel;
        private DataGridViewTextBoxColumn IdInfo;
        private DataGridViewTextBoxColumn CreatedInfo;
        private DataGridViewTextBoxColumn OrderStatusInfo;
        private DataGridViewTextBoxColumn CustomerFullnameInfo;
        private DataGridViewTextBoxColumn CustomerAddressInfo;
        private DataGridViewTextBoxColumn AmountInfo;
    }
}