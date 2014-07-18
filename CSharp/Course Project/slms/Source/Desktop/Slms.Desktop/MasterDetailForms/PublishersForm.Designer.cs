namespace Slms.Desktop.MasterDetailForms
{
    partial class PublishersForm
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
            this.PublisherMasterGridView = new System.Windows.Forms.DataGridView();
            this.BookDetailsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherMasterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PublisherMasterGridView
            // 
            this.PublisherMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublisherMasterGridView.Location = new System.Drawing.Point(48, 62);
            this.PublisherMasterGridView.Name = "PublisherMasterGridView";
            this.PublisherMasterGridView.Size = new System.Drawing.Size(801, 150);
            this.PublisherMasterGridView.TabIndex = 0;
            // 
            // BookDetailsGridView
            // 
            this.BookDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDetailsGridView.Location = new System.Drawing.Point(48, 241);
            this.BookDetailsGridView.Name = "BookDetailsGridView";
            this.BookDetailsGridView.Size = new System.Drawing.Size(801, 150);
            this.BookDetailsGridView.TabIndex = 1;
            // 
            // PublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 421);
            this.Controls.Add(this.BookDetailsGridView);
            this.Controls.Add(this.PublisherMasterGridView);
            this.Name = "PublishersForm";
            this.Text = "PublishersForm";
            this.Load += new System.EventHandler(this.PublishersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PublisherMasterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PublisherMasterGridView;
        private System.Windows.Forms.DataGridView BookDetailsGridView;
    }
}