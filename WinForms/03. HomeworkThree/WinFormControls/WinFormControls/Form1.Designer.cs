namespace WinFormControls
{
    partial class BaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountLabael = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.newSale = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.finishAllSales = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grandTotal = new System.Windows.Forms.TextBox();
            this.grandDiscount = new System.Windows.Forms.TextBox();
            this.numberOfSales = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grandDiscountlLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Article = new System.Windows.Forms.ComboBox();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.salesHistory = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Articles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantities = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discounts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalAmounts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleDateFiled = new System.Windows.Forms.DateTimePicker();
            this.SaleDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.GradTotalEn = new System.Windows.Forms.TextBox();
            this.BGNlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // discountLabael
            // 
            this.discountLabael.AutoSize = true;
            this.discountLabael.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabael.Location = new System.Drawing.Point(54, 148);
            this.discountLabael.Name = "discountLabael";
            this.discountLabael.Size = new System.Drawing.Size(61, 13);
            this.discountLabael.TabIndex = 3;
            this.discountLabael.Text = "Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Amount:";
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(119, 94);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(100, 20);
            this.unitPrice.TabIndex = 6;
            this.toolTip3.SetToolTip(this.unitPrice, "Unit price - postive intiger");
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(119, 121);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 7;
            this.toolTip5.SetToolTip(this.quantity, "Quantity - must be postive integer");
            // 
            // discount
            // 
            this.discount.Enabled = false;
            this.discount.Location = new System.Drawing.Point(119, 148);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(100, 20);
            this.discount.TabIndex = 8;
            // 
            // totalAmount
            // 
            this.totalAmount.Enabled = false;
            this.totalAmount.Location = new System.Drawing.Point(119, 176);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(100, 20);
            this.totalAmount.TabIndex = 9;
            // 
            // newSale
            // 
            this.newSale.Enabled = false;
            this.newSale.Location = new System.Drawing.Point(303, 65);
            this.newSale.Name = "newSale";
            this.newSale.Size = new System.Drawing.Size(122, 23);
            this.newSale.TabIndex = 10;
            this.newSale.Text = "New Sale";
            this.newSale.UseVisualStyleBackColor = true;
            this.newSale.Click += new System.EventHandler(this.newSale_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(303, 92);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(122, 23);
            this.total.TabIndex = 11;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // finishAllSales
            // 
            this.finishAllSales.Location = new System.Drawing.Point(303, 137);
            this.finishAllSales.Name = "finishAllSales";
            this.finishAllSales.Size = new System.Drawing.Size(122, 23);
            this.finishAllSales.TabIndex = 12;
            this.finishAllSales.Text = "Finish All Sales";
            this.finishAllSales.UseVisualStyleBackColor = true;
            this.finishAllSales.Click += new System.EventHandler(this.finishAllSales_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(303, 165);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(122, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(32, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
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
            // Article
            // 
            this.Article.FormattingEnabled = true;
            this.Article.Location = new System.Drawing.Point(119, 62);
            this.Article.Name = "Article";
            this.Article.Size = new System.Drawing.Size(100, 21);
            this.Article.TabIndex = 15;
            this.toolTip2.SetToolTip(this.Article, "Choose an article");
            // 
            // Currency
            // 
            this.Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Currency.FormattingEnabled = true;
            this.Currency.Location = new System.Drawing.Point(226, 94);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(59, 21);
            this.Currency.TabIndex = 16;
            this.toolTip4.SetToolTip(this.Currency, "Currency");
            // 
            // salesHistory
            // 
            this.salesHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Articles,
            this.UnitPrices,
            this.Quantities,
            this.Discounts,
            this.TotalAmounts});
            this.salesHistory.Location = new System.Drawing.Point(32, 355);
            this.salesHistory.Name = "salesHistory";
            this.salesHistory.Size = new System.Drawing.Size(429, 97);
            this.salesHistory.TabIndex = 17;
            this.salesHistory.UseCompatibleStateImageBehavior = false;
            this.salesHistory.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Articles
            // 
            this.Articles.Text = "Articles";
            // 
            // UnitPrices
            // 
            this.UnitPrices.Text = "Unit Prices";
            this.UnitPrices.Width = 72;
            // 
            // Quantities
            // 
            this.Quantities.Text = "Quantities";
            // 
            // Discounts
            // 
            this.Discounts.Text = "Discounts";
            this.Discounts.Width = 76;
            // 
            // TotalAmounts
            // 
            this.TotalAmounts.Text = "Total Amounts";
            this.TotalAmounts.Width = 95;
            // 
            // SaleDateFiled
            // 
            this.SaleDateFiled.CustomFormat = "";
            this.SaleDateFiled.Location = new System.Drawing.Point(119, 36);
            this.SaleDateFiled.Name = "SaleDateFiled";
            this.SaleDateFiled.Size = new System.Drawing.Size(100, 20);
            this.SaleDateFiled.TabIndex = 18;
            this.toolTip1.SetToolTip(this.SaleDateFiled, "Sale Date");
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSize = true;
            this.SaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDate.Location = new System.Drawing.Point(73, 42);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(38, 13);
            this.SaleDate.TabIndex = 19;
            this.SaleDate.Text = "Date:";
            // 
            // GradTotalEn
            // 
            this.GradTotalEn.Location = new System.Drawing.Point(271, 74);
            this.GradTotalEn.Name = "GradTotalEn";
            this.GradTotalEn.Size = new System.Drawing.Size(100, 20);
            this.GradTotalEn.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "USD";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 501);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.SaleDateFiled);
            this.Controls.Add(this.salesHistory);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Article);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.finishAllSales);
            this.Controls.Add(this.total);
            this.Controls.Add(this.newSale);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountLabael);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaseForm";
            this.Text = "Infromation System \"Sales\"";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discountLabael;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitPrice;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Button newSale;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Button finishAllSales;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox grandTotal;
        private System.Windows.Forms.TextBox grandDiscount;
        private System.Windows.Forms.TextBox numberOfSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grandDiscountlLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Article;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.ListView salesHistory;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Articles;
        private System.Windows.Forms.ColumnHeader UnitPrices;
        private System.Windows.Forms.ColumnHeader Quantities;
        private System.Windows.Forms.ColumnHeader Discounts;
        private System.Windows.Forms.ColumnHeader TotalAmounts;
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
    }
}

