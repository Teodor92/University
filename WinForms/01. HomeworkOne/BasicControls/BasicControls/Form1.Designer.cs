namespace BasicControls
{
    partial class frm1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SavePersonalData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.birthCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.names = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.direction = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.facNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SavePersonalData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.birthCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.names);
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Data";
            // 
            // SavePersonalData
            // 
            this.SavePersonalData.Location = new System.Drawing.Point(44, 108);
            this.SavePersonalData.Name = "SavePersonalData";
            this.SavePersonalData.Size = new System.Drawing.Size(291, 23);
            this.SavePersonalData.TabIndex = 6;
            this.SavePersonalData.Text = "Save Personal Data";
            this.SavePersonalData.UseVisualStyleBackColor = true;
            this.SavePersonalData.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth City";
            // 
            // birthCity
            // 
            this.birthCity.Location = new System.Drawing.Point(157, 73);
            this.birthCity.Name = "birthCity";
            this.birthCity.Size = new System.Drawing.Size(197, 20);
            this.birthCity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(157, 46);
            this.phone.Mask = "(999) 000-000000 ";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(197, 20);
            this.phone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name, Last Name:";
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(157, 19);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(197, 20);
            this.names.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.direction);
            this.groupBox2.Controls.Add(this.group);
            this.groupBox2.Controls.Add(this.facNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(424, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "University Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save University Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // direction
            // 
            this.direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "Information Systems  development and design ",
            "Information Systems analysis and design"});
            this.direction.Location = new System.Drawing.Point(119, 64);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(138, 21);
            this.direction.TabIndex = 5;
            // 
            // group
            // 
            this.group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "1310",
            "1311"});
            this.group.Location = new System.Drawing.Point(119, 40);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(138, 21);
            this.group.TabIndex = 4;
            // 
            // facNumber
            // 
            this.facNumber.Location = new System.Drawing.Point(119, 18);
            this.facNumber.Mask = "000000";
            this.facNumber.Name = "facNumber";
            this.facNumber.Size = new System.Drawing.Size(138, 20);
            this.facNumber.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Direction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Facalty Number";
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.Location = new System.Drawing.Point(39, 218);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(360, 167);
            this.richTextBoxDisplay.TabIndex = 2;
            this.richTextBoxDisplay.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Red);
            this.flowLayoutPanel1.Controls.Add(this.Green);
            this.flowLayoutPanel1.Controls.Add(this.Blue);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(424, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 157);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(3, 3);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(54, 3);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 17);
            this.Green.TabIndex = 1;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(3, 26);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Change text color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear all fields";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercise 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SavePersonalData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox direction;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.MaskedTextBox facNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

