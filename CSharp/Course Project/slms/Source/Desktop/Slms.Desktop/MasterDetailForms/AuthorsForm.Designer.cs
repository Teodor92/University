namespace Slms.Desktop.MasterDetailForms
{
    public partial class AuthorsForm
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
            this.AuthorMasterGridView = new System.Windows.Forms.DataGridView();
            this.DetailsBooksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorMasterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorMasterGridView
            // 
            this.AuthorMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorMasterGridView.Location = new System.Drawing.Point(46, 43);
            this.AuthorMasterGridView.Name = "AuthorMasterGridView";
            this.AuthorMasterGridView.Size = new System.Drawing.Size(745, 147);
            this.AuthorMasterGridView.TabIndex = 0;
            // 
            // DetailsBooksGridView
            // 
            this.DetailsBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsBooksGridView.Location = new System.Drawing.Point(46, 223);
            this.DetailsBooksGridView.Name = "DetailsBooksGridView";
            this.DetailsBooksGridView.Size = new System.Drawing.Size(745, 139);
            this.DetailsBooksGridView.TabIndex = 1;
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 432);
            this.Controls.Add(this.DetailsBooksGridView);
            this.Controls.Add(this.AuthorMasterGridView);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorMasterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorMasterGridView;
        private System.Windows.Forms.DataGridView DetailsBooksGridView;

    }
}