namespace Slms.Desktop.SearchForms
{
    partial class SearchForAuthorComplexForm
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
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultDataGridView
            // 
            this.SearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultDataGridView.Location = new System.Drawing.Point(58, 110);
            this.SearchResultDataGridView.Name = "SearchResultDataGridView";
            this.SearchResultDataGridView.Size = new System.Drawing.Size(722, 260);
            this.SearchResultDataGridView.TabIndex = 0;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(58, 32);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.AuthorNameLabel.TabIndex = 1;
            this.AuthorNameLabel.Text = "Author Name";
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(58, 66);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(74, 13);
            this.CountryNameLabel.TabIndex = 2;
            this.CountryNameLabel.Text = "Country Name";
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.Location = new System.Drawing.Point(148, 32);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorNameTextBox.TabIndex = 3;
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.Location = new System.Drawing.Point(148, 66);
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountryNameTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(300, 66);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForAuthorComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 428);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CountryNameTextBox);
            this.Controls.Add(this.AuthorNameTextBox);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.SearchResultDataGridView);
            this.Name = "SearchForAuthorComplexForm";
            this.Text = "SearchForAuthorComplexForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultDataGridView;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.TextBox CountryNameTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}