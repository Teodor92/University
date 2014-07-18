namespace Slms.Desktop.SearchForms
{
    partial class SearchForCountryForm
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
            this.SearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.CountryNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultDataGridView
            // 
            this.SearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultDataGridView.Location = new System.Drawing.Point(52, 106);
            this.SearchResultDataGridView.Name = "SearchResultDataGridView";
            this.SearchResultDataGridView.Size = new System.Drawing.Size(859, 279);
            this.SearchResultDataGridView.TabIndex = 0;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(52, 53);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(74, 13);
            this.CountryNameLabel.TabIndex = 1;
            this.CountryNameLabel.Text = "Country Name";
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.Location = new System.Drawing.Point(143, 53);
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryNameTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(265, 53);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 435);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CountryNameTextBox);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.SearchResultDataGridView);
            this.Name = "SearchForCountryForm";
            this.Text = "SearchForCountryForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultDataGridView;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.TextBox CountryNameTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}