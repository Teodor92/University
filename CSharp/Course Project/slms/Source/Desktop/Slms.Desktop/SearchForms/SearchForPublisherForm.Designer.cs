namespace Slms.Desktop.SearchForms
{
    partial class SearchForPublisherForm
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
            this.PublisherNameLabel = new System.Windows.Forms.Label();
            this.PublisherNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultDataGridView
            // 
            this.SearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultDataGridView.Location = new System.Drawing.Point(52, 100);
            this.SearchResultDataGridView.Name = "SearchResultDataGridView";
            this.SearchResultDataGridView.Size = new System.Drawing.Size(836, 298);
            this.SearchResultDataGridView.TabIndex = 0;
            // 
            // PublisherNameLabel
            // 
            this.PublisherNameLabel.AutoSize = true;
            this.PublisherNameLabel.Location = new System.Drawing.Point(52, 58);
            this.PublisherNameLabel.Name = "PublisherNameLabel";
            this.PublisherNameLabel.Size = new System.Drawing.Size(81, 13);
            this.PublisherNameLabel.TabIndex = 1;
            this.PublisherNameLabel.Text = "Publisher Name";
            // 
            // PublisherNameTextBox
            // 
            this.PublisherNameTextBox.Location = new System.Drawing.Point(154, 58);
            this.PublisherNameTextBox.Name = "PublisherNameTextBox";
            this.PublisherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PublisherNameTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(288, 58);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 445);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PublisherNameTextBox);
            this.Controls.Add(this.PublisherNameLabel);
            this.Controls.Add(this.SearchResultDataGridView);
            this.Name = "SearchForPublisherForm";
            this.Text = "SearchForPublisherForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultDataGridView;
        private System.Windows.Forms.Label PublisherNameLabel;
        private System.Windows.Forms.TextBox PublisherNameTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}