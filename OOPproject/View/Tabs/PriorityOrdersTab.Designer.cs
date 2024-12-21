namespace OOPproject.View.Tabs
{
    partial class PriorityOrdersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IdTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            DeliveryTimeComboBox = new ComboBox();
            DeliverAddressTemplatePanel = new Panel();
            groupBox3 = new GroupBox();
            OrderItemsListBox = new ListBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            PriceLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(DeliverAddressTemplatePanel, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 106);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Order";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(IdTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(CreatedTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(StatusComboBox, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(385, 76);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Created:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // IdTextBox
            // 
            IdTextBox.Dock = DockStyle.Fill;
            IdTextBox.Location = new Point(80, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(302, 25);
            IdTextBox.TabIndex = 3;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Dock = DockStyle.Fill;
            CreatedTextBox.Location = new Point(80, 28);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(302, 25);
            CreatedTextBox.TabIndex = 4;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Dock = DockStyle.Fill;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(80, 53);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(302, 25);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusSelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(400, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Priority Options";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(DeliveryTimeComboBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 21);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Size = new Size(385, 76);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 0;
            label4.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Dock = DockStyle.Fill;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(118, 3);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(264, 25);
            DeliveryTimeComboBox.TabIndex = 1;
            // 
            // DeliverAddressTemplatePanel
            // 
            DeliverAddressTemplatePanel.Dock = DockStyle.Fill;
            DeliverAddressTemplatePanel.Location = new Point(3, 115);
            DeliverAddressTemplatePanel.Name = "DeliverAddressTemplatePanel";
            DeliverAddressTemplatePanel.Size = new Size(794, 106);
            DeliverAddressTemplatePanel.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(OrderItemsListBox);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(3, 227);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(794, 106);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Dock = DockStyle.Fill;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 17;
            OrderItemsListBox.Location = new Point(3, 21);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(788, 82);
            OrderItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.Controls.Add(AddItemButton, 0, 0);
            tableLayoutPanel5.Controls.Add(RemoveItemButton, 1, 0);
            tableLayoutPanel5.Controls.Add(ClearOrderButton, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 406);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(794, 41);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Location = new Point(3, 3);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(113, 35);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += OnAddItemButtonPressed;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(122, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(113, 35);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += OnRemoveItemButtonPressed;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Dock = DockStyle.Fill;
            ClearOrderButton.Location = new Point(677, 3);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(114, 35);
            ClearOrderButton.TabIndex = 2;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += OnClearOrderButtonPressed;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(PriceLabel, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 339);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.Size = new Size(794, 61);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(729, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 18);
            label5.TabIndex = 0;
            label5.Text = "Amount:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Dock = DockStyle.Right;
            PriceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(641, 18);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(150, 43);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "PriceLabel";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Text = "PriorityOrdersTab";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox IdTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private ComboBox DeliveryTimeComboBox;
        private Panel DeliverAddressTemplatePanel;
        private GroupBox groupBox3;
        private ListBox OrderItemsListBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private Label PriceLabel;
    }
}