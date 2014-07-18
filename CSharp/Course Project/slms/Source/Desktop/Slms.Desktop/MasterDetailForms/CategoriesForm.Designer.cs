namespace Slms.Desktop.MasterDetailForms
{
    public partial class CategoriesForm
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
            this.MasterCategoryGridView = new System.Windows.Forms.DataGridView();
            this.DetailsBooksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MasterCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterCategoryGridView
            // 
            this.MasterCategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterCategoryGridView.Location = new System.Drawing.Point(46, 54);
            this.MasterCategoryGridView.Name = "MasterCategoryGridView";
            this.MasterCategoryGridView.Size = new System.Drawing.Size(882, 157);
            this.MasterCategoryGridView.TabIndex = 1;
            // 
            // DetailsBooksGridView
            // 
            this.DetailsBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsBooksGridView.Location = new System.Drawing.Point(46, 235);
            this.DetailsBooksGridView.Name = "DetailsBooksGridView";
            this.DetailsBooksGridView.Size = new System.Drawing.Size(882, 142);
            this.DetailsBooksGridView.TabIndex = 2;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 422);
            this.Controls.Add(this.DetailsBooksGridView);
            this.Controls.Add(this.MasterCategoryGridView);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasterCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MasterCategoryGridView;
        private System.Windows.Forms.DataGridView DetailsBooksGridView;
    }
}