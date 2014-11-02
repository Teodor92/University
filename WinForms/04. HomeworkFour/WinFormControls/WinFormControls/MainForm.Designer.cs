namespace WinFormControls
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BGNlabel = new System.Windows.Forms.Label();
            this.GradTotalEn = new System.Windows.Forms.TextBox();
            this.grandTotal = new System.Windows.Forms.TextBox();
            this.grandDiscount = new System.Windows.Forms.TextBox();
            this.numberOfSales = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grandDiscountlLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.SaleDateFiled = new System.Windows.Forms.DateTimePicker();
            this.SaleDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomenclaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChangingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.ArticleColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QunatityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BGNlabel);
            this.groupBox1.Controls.Add(this.GradTotalEn);
            this.groupBox1.Controls.Add(this.grandTotal);
            this.groupBox1.Controls.Add(this.grandDiscount);
            this.groupBox1.Controls.Add(this.numberOfSales);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.grandDiscountlLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(33, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "USD";
            // 
            // BGNlabel
            // 
            this.BGNlabel.AutoSize = true;
            this.BGNlabel.Location = new System.Drawing.Point(378, 46);
            this.BGNlabel.Name = "BGNlabel";
            this.BGNlabel.Size = new System.Drawing.Size(30, 13);
            this.BGNlabel.TabIndex = 7;
            this.BGNlabel.Text = "BGN";
            // 
            // GradTotalEn
            // 
            this.GradTotalEn.Enabled = false;
            this.GradTotalEn.Location = new System.Drawing.Point(271, 74);
            this.GradTotalEn.Name = "GradTotalEn";
            this.GradTotalEn.Size = new System.Drawing.Size(100, 20);
            this.GradTotalEn.TabIndex = 6;
            // 
            // grandTotal
            // 
            this.grandTotal.Enabled = false;
            this.grandTotal.Location = new System.Drawing.Point(271, 46);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(100, 20);
            this.grandTotal.TabIndex = 5;
            // 
            // grandDiscount
            // 
            this.grandDiscount.Enabled = false;
            this.grandDiscount.Location = new System.Drawing.Point(146, 46);
            this.grandDiscount.Name = "grandDiscount";
            this.grandDiscount.Size = new System.Drawing.Size(100, 20);
            this.grandDiscount.TabIndex = 4;
            // 
            // numberOfSales
            // 
            this.numberOfSales.Enabled = false;
            this.numberOfSales.Location = new System.Drawing.Point(21, 47);
            this.numberOfSales.Name = "numberOfSales";
            this.numberOfSales.Size = new System.Drawing.Size(100, 20);
            this.numberOfSales.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Grand Total:";
            // 
            // grandDiscountlLabel
            // 
            this.grandDiscountlLabel.AutoSize = true;
            this.grandDiscountlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandDiscountlLabel.Location = new System.Drawing.Point(143, 31);
            this.grandDiscountlLabel.Name = "grandDiscountlLabel";
            this.grandDiscountlLabel.Size = new System.Drawing.Size(99, 13);
            this.grandDiscountlLabel.TabIndex = 1;
            this.grandDiscountlLabel.Text = "Grand Discount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number Of Sales:";
            // 
            // Currency
            // 
            this.Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Currency.FormattingEnabled = true;
            this.Currency.Location = new System.Drawing.Point(87, 127);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(59, 21);
            this.Currency.TabIndex = 16;
            this.toolTip4.SetToolTip(this.Currency, "Currency");
            // 
            // SaleDateFiled
            // 
            this.SaleDateFiled.CustomFormat = "";
            this.SaleDateFiled.Location = new System.Drawing.Point(87, 89);
            this.SaleDateFiled.Name = "SaleDateFiled";
            this.SaleDateFiled.Size = new System.Drawing.Size(201, 20);
            this.SaleDateFiled.TabIndex = 18;
            this.toolTip1.SetToolTip(this.SaleDateFiled, "Sale Date");
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSize = true;
            this.SaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDate.Location = new System.Drawing.Point(43, 89);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(38, 13);
            this.SaleDate.TabIndex = 19;
            this.SaleDate.Text = "Date:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.nomenclaturesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSaleToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // newSaleToolStripMenuItem
            // 
            this.newSaleToolStripMenuItem.Name = "newSaleToolStripMenuItem";
            this.newSaleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.newSaleToolStripMenuItem.Text = "New Sale";
            this.newSaleToolStripMenuItem.Click += new System.EventHandler(this.newSaleToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesListToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesListToolStripMenuItem
            // 
            this.salesListToolStripMenuItem.Name = "salesListToolStripMenuItem";
            this.salesListToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.salesListToolStripMenuItem.Text = "Sales List";
            this.salesListToolStripMenuItem.Click += new System.EventHandler(this.salesListToolStripMenuItem_Click);
            // 
            // nomenclaturesToolStripMenuItem
            // 
            this.nomenclaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem});
            this.nomenclaturesToolStripMenuItem.Name = "nomenclaturesToolStripMenuItem";
            this.nomenclaturesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.nomenclaturesToolStripMenuItem.Text = "Nomenclatures";
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.articlesToolStripMenuItem.Text = "Articles";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorChangingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // colorChangingToolStripMenuItem
            // 
            this.colorChangingToolStripMenuItem.Name = "colorChangingToolStripMenuItem";
            this.colorChangingToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.colorChangingToolStripMenuItem.Text = "Color Changing";
            this.colorChangingToolStripMenuItem.Click += new System.EventHandler(this.colorChangingToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 495);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CustomerTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SaleDate);
            this.tabPage1.Controls.Add(this.SaleDateFiled);
            this.tabPage1.Controls.Add(this.Currency);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer:";
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Location = new System.Drawing.Point(87, 51);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(457, 20);
            this.CustomerTextBox.TabIndex = 21;
            this.CustomerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerTextBox_Validating);
            this.CustomerTextBox.Validated += new System.EventHandler(this.CustomerTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Currency:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SalesGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SalesGridView
            // 
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleColumn,
            this.UnitPriceColumn,
            this.QunatityColumn,
            this.DiscountColumn,
            this.TotalAmountColumn});
            this.SalesGridView.Location = new System.Drawing.Point(25, 21);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.Size = new System.Drawing.Size(682, 300);
            this.SalesGridView.TabIndex = 0;
            this.SalesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellEndEdit);
            // 
            // ArticleColumn
            // 
            this.ArticleColumn.HeaderText = "Article";
            this.ArticleColumn.Name = "ArticleColumn";
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            // 
            // QunatityColumn
            // 
            this.QunatityColumn.HeaderText = "Quantity";
            this.QunatityColumn.Name = "QunatityColumn";
            // 
            // DiscountColumn
            // 
            this.DiscountColumn.HeaderText = "Discount";
            this.DiscountColumn.Name = "DiscountColumn";
            // 
            // TotalAmountColumn
            // 
            this.TotalAmountColumn.HeaderText = "Total Amount";
            this.TotalAmountColumn.Name = "TotalAmountColumn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Infromation System \"Sales\"";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox grandTotal;
        private System.Windows.Forms.TextBox grandDiscount;
        private System.Windows.Forms.TextBox numberOfSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grandDiscountlLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.DateTimePicker SaleDateFiled;
        private System.Windows.Forms.Label SaleDate;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BGNlabel;
        private System.Windows.Forms.TextBox GradTotalEn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomenclaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorChangingToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn ArticleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QunatityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

