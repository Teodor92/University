namespace Slms.Desktop.SearchForms
{
    partial class SearchForBookComplexForm
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
            this.SearchResultDataGrid = new System.Windows.Forms.DataGridView();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultDataGrid
            // 
            this.SearchResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultDataGrid.Location = new System.Drawing.Point(65, 99);
            this.SearchResultDataGrid.Name = "SearchResultDataGrid";
            this.SearchResultDataGrid.Size = new System.Drawing.Size(777, 269);
            this.SearchResultDataGrid.TabIndex = 0;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(65, 24);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.AuthorNameLabel.TabIndex = 1;
            this.AuthorNameLabel.Text = "Author Name";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(65, 56);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(63, 13);
            this.BookNameLabel.TabIndex = 2;
            this.BookNameLabel.Text = "Book Name";
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.AcceptsReturn = true;
            this.AuthorNameTextBox.Location = new System.Drawing.Point(164, 24);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorNameTextBox.TabIndex = 3;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(164, 56);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookNameTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(312, 52);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForBookComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 440);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.AuthorNameTextBox);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.SearchResultDataGrid);
            this.Name = "SearchForBookComplexForm";
            this.Text = "SearchForBookComplexForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultDataGrid;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}