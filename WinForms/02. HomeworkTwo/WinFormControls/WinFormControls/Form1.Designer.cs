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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.TextBox();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.newSale = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.finishAllSales = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numberOfSales = new System.Windows.Forms.TextBox();
            this.grandDiscount = new System.Windows.Forms.TextBox();
            this.grandTotal = new System.Windows.Forms.TextBox();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount:";
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
            // article
            // 
            this.article.Location = new System.Drawing.Point(119, 65);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(100, 20);
            this.article.TabIndex = 5;
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(119, 94);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(100, 20);
            this.unitPrice.TabIndex = 6;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(119, 121);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 7;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(119, 148);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(100, 20);
            this.discount.TabIndex = 8;
            // 
            // totalAmount
            // 
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
            this.groupBox1.Controls.Add(this.grandTotal);
            this.groupBox1.Controls.Add(this.grandDiscount);
            this.groupBox1.Controls.Add(this.numberOfSales);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(32, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Grand Discount:";
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
            // numberOfSales
            // 
            this.numberOfSales.Location = new System.Drawing.Point(21, 47);
            this.numberOfSales.Name = "numberOfSales";
            this.numberOfSales.Size = new System.Drawing.Size(100, 20);
            this.numberOfSales.TabIndex = 3;
            // 
            // grandDiscount
            // 
            this.grandDiscount.Location = new System.Drawing.Point(146, 46);
            this.grandDiscount.Name = "grandDiscount";
            this.grandDiscount.Size = new System.Drawing.Size(100, 20);
            this.grandDiscount.TabIndex = 4;
            // 
            // grandTotal
            // 
            this.grandTotal.Location = new System.Drawing.Point(271, 46);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(100, 20);
            this.grandTotal.TabIndex = 5;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.finishAllSales);
            this.Controls.Add(this.total);
            this.Controls.Add(this.newSale);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.article);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaseForm";
            this.Text = "Infromation System \"Sales\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox article;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

