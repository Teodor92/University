namespace CentralLoanRegister
{
    public partial class Credit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveBorrowerInformation;
        private System.Windows.Forms.TextBox textBoxGuarantorName;
        private System.Windows.Forms.TextBox textBoxMonthlyIncome;
        private System.Windows.Forms.TextBox textBoxWorkAddress;
        private System.Windows.Forms.TextBox textBoxHomeAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEGN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSaveLoanInformation;
        private System.Windows.Forms.TextBox textBoxYearlyCostInterest;
        private System.Windows.Forms.TextBox textBoxOverdueInterest;
        private System.Windows.Forms.TextBox textBoxMonthlyTaxes;
        private System.Windows.Forms.TextBox textBoxLoanCost;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.TextBox textBoxMonthlyInterest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveBorrowerInformation = new System.Windows.Forms.Button();
            this.textBoxGuarantorName = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyIncome = new System.Windows.Forms.TextBox();
            this.textBoxWorkAddress = new System.Windows.Forms.TextBox();
            this.textBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEGN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSaveLoanInformation = new System.Windows.Forms.Button();
            this.textBoxYearlyCostInterest = new System.Windows.Forms.TextBox();
            this.textBoxOverdueInterest = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyTaxes = new System.Windows.Forms.TextBox();
            this.textBoxLoanCost = new System.Windows.Forms.TextBox();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyInterest = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveBorrowerInformation);
            this.groupBox1.Controls.Add(this.textBoxGuarantorName);
            this.groupBox1.Controls.Add(this.textBoxMonthlyIncome);
            this.groupBox1.Controls.Add(this.textBoxWorkAddress);
            this.groupBox1.Controls.Add(this.textBoxHomeAddress);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.textBoxEGN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данни за кредитополучателя";
            // 
            // buttonSaveBorrowerInformation
            // 
            this.buttonSaveBorrowerInformation.Location = new System.Drawing.Point(195, 295);
            this.buttonSaveBorrowerInformation.Name = "buttonSaveBorrowerInformation";
            this.buttonSaveBorrowerInformation.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveBorrowerInformation.TabIndex = 14;
            this.buttonSaveBorrowerInformation.Text = "Запис";
            this.buttonSaveBorrowerInformation.UseVisualStyleBackColor = true;
            this.buttonSaveBorrowerInformation.Click += new System.EventHandler(this.buttonSaveBorrowerInformation_Click);
            // 
            // textBoxGuarantorName
            // 
            this.textBoxGuarantorName.Location = new System.Drawing.Point(127, 268);
            this.textBoxGuarantorName.Name = "textBoxGuarantorName";
            this.textBoxGuarantorName.Size = new System.Drawing.Size(143, 20);
            this.textBoxGuarantorName.TabIndex = 13;
            // 
            // textBoxMonthlyIncome
            // 
            this.textBoxMonthlyIncome.Location = new System.Drawing.Point(127, 233);
            this.textBoxMonthlyIncome.Name = "textBoxMonthlyIncome";
            this.textBoxMonthlyIncome.Size = new System.Drawing.Size(143, 20);
            this.textBoxMonthlyIncome.TabIndex = 12;
            // 
            // textBoxWorkAddress
            // 
            this.textBoxWorkAddress.Location = new System.Drawing.Point(127, 190);
            this.textBoxWorkAddress.Name = "textBoxWorkAddress";
            this.textBoxWorkAddress.Size = new System.Drawing.Size(143, 20);
            this.textBoxWorkAddress.TabIndex = 11;
            // 
            // textBoxHomeAddress
            // 
            this.textBoxHomeAddress.Location = new System.Drawing.Point(127, 145);
            this.textBoxHomeAddress.Name = "textBoxHomeAddress";
            this.textBoxHomeAddress.Size = new System.Drawing.Size(143, 20);
            this.textBoxHomeAddress.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(127, 100);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(143, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(127, 58);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(143, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxEGN
            // 
            this.textBoxEGN.Location = new System.Drawing.Point(127, 24);
            this.textBoxEGN.Name = "textBoxEGN";
            this.textBoxEGN.Size = new System.Drawing.Size(143, 20);
            this.textBoxEGN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Име на поръчителя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Месечен доход:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Служебен адрес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Домашен адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЕНГ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.buttonSaveLoanInformation);
            this.groupBox2.Controls.Add(this.textBoxYearlyCostInterest);
            this.groupBox2.Controls.Add(this.textBoxOverdueInterest);
            this.groupBox2.Controls.Add(this.textBoxMonthlyTaxes);
            this.groupBox2.Controls.Add(this.textBoxLoanCost);
            this.groupBox2.Controls.Add(this.textBoxDeadline);
            this.groupBox2.Controls.Add(this.textBoxMonthlyInterest);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данни за кредита";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Годишен % на разходите:";
            // 
            // buttonSaveLoanInformation
            // 
            this.buttonSaveLoanInformation.Location = new System.Drawing.Point(195, 295);
            this.buttonSaveLoanInformation.Name = "buttonSaveLoanInformation";
            this.buttonSaveLoanInformation.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveLoanInformation.TabIndex = 15;
            this.buttonSaveLoanInformation.Text = "Запис";
            this.buttonSaveLoanInformation.UseVisualStyleBackColor = true;
            this.buttonSaveLoanInformation.Click += new System.EventHandler(this.buttonSaveLoanInformation_Click);
            // 
            // textBoxYearlyCostInterest
            // 
            this.textBoxYearlyCostInterest.Location = new System.Drawing.Point(147, 237);
            this.textBoxYearlyCostInterest.Name = "textBoxYearlyCostInterest";
            this.textBoxYearlyCostInterest.Size = new System.Drawing.Size(123, 20);
            this.textBoxYearlyCostInterest.TabIndex = 13;
            // 
            // textBoxOverdueInterest
            // 
            this.textBoxOverdueInterest.Location = new System.Drawing.Point(147, 190);
            this.textBoxOverdueInterest.Name = "textBoxOverdueInterest";
            this.textBoxOverdueInterest.Size = new System.Drawing.Size(123, 20);
            this.textBoxOverdueInterest.TabIndex = 12;
            // 
            // textBoxMonthlyTaxes
            // 
            this.textBoxMonthlyTaxes.Location = new System.Drawing.Point(147, 145);
            this.textBoxMonthlyTaxes.Name = "textBoxMonthlyTaxes";
            this.textBoxMonthlyTaxes.Size = new System.Drawing.Size(123, 20);
            this.textBoxMonthlyTaxes.TabIndex = 11;
            // 
            // textBoxLoanCost
            // 
            this.textBoxLoanCost.Location = new System.Drawing.Point(147, 104);
            this.textBoxLoanCost.Name = "textBoxLoanCost";
            this.textBoxLoanCost.Size = new System.Drawing.Size(123, 20);
            this.textBoxLoanCost.TabIndex = 10;
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Location = new System.Drawing.Point(147, 62);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.Size = new System.Drawing.Size(123, 20);
            this.textBoxDeadline.TabIndex = 9;
            // 
            // textBoxMonthlyInterest
            // 
            this.textBoxMonthlyInterest.Location = new System.Drawing.Point(147, 28);
            this.textBoxMonthlyInterest.Name = "textBoxMonthlyInterest";
            this.textBoxMonthlyInterest.Size = new System.Drawing.Size(123, 20);
            this.textBoxMonthlyInterest.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Лихва за просрочване:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Месечни такси:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Стойност на кредита:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Срок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Месечна лихва:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}