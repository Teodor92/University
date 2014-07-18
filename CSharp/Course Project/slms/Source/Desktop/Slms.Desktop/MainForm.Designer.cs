namespace Slms.Desktop
{
    public partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesMenuIItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TagsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublishersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComplexBooksSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchForBooksByTagAndCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountrySearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublisherSearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorSearchComplexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.другиToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.ExitAppMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorsMenuItem,
            this.CategoriesMenuIItem,
            this.TagsMenuItem,
            this.PublishersMenuItem,
            this.BooksMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // AuthorsMenuItem
            // 
            this.AuthorsMenuItem.Name = "AuthorsMenuItem";
            this.AuthorsMenuItem.Size = new System.Drawing.Size(131, 22);
            this.AuthorsMenuItem.Text = "Автори";
            this.AuthorsMenuItem.Click += new System.EventHandler(this.AuthorsMenuItem_Click);
            // 
            // CategoriesMenuIItem
            // 
            this.CategoriesMenuIItem.Name = "CategoriesMenuIItem";
            this.CategoriesMenuIItem.Size = new System.Drawing.Size(131, 22);
            this.CategoriesMenuIItem.Text = "Категории";
            this.CategoriesMenuIItem.Click += new System.EventHandler(this.CategoriesMenuIItem_Click);
            // 
            // TagsMenuItem
            // 
            this.TagsMenuItem.Name = "TagsMenuItem";
            this.TagsMenuItem.Size = new System.Drawing.Size(131, 22);
            this.TagsMenuItem.Text = "Тагове";
            this.TagsMenuItem.Click += new System.EventHandler(this.TagsMenuItem_Click);
            // 
            // PublishersMenuItem
            // 
            this.PublishersMenuItem.Name = "PublishersMenuItem";
            this.PublishersMenuItem.Size = new System.Drawing.Size(131, 22);
            this.PublishersMenuItem.Text = "Издатели";
            this.PublishersMenuItem.Click += new System.EventHandler(this.PublishersMenuItem_Click);
            // 
            // BooksMenuItem
            // 
            this.BooksMenuItem.Name = "BooksMenuItem";
            this.BooksMenuItem.Size = new System.Drawing.Size(131, 22);
            this.BooksMenuItem.Text = "Книги";
            this.BooksMenuItem.Click += new System.EventHandler(this.BooksMenuItem_Click);
            // 
            // другиToolStripMenuItem
            // 
            this.другиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountriesMenuItem});
            this.другиToolStripMenuItem.Name = "другиToolStripMenuItem";
            this.другиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.другиToolStripMenuItem.Text = "Други";
            // 
            // CountriesMenuItem
            // 
            this.CountriesMenuItem.Name = "CountriesMenuItem";
            this.CountriesMenuItem.Size = new System.Drawing.Size(114, 22);
            this.CountriesMenuItem.Text = "Страни";
            this.CountriesMenuItem.Click += new System.EventHandler(this.CountriesMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorSearchMenuItem,
            this.ComplexBooksSearchMenuItem,
            this.SearchForBooksByTagAndCategoryMenuItem,
            this.CountrySearchMenuItem,
            this.PublisherSearchMenuItem,
            this.AuthorSearchComplexMenuItem});
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
            // 
            // AuthorSearchMenuItem
            // 
            this.AuthorSearchMenuItem.Name = "AuthorSearchMenuItem";
            this.AuthorSearchMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AuthorSearchMenuItem.Text = "Търсене по автор";
            this.AuthorSearchMenuItem.Click += new System.EventHandler(this.AuthorSearchMenuItem_Click);
            // 
            // ComplexBooksSearchMenuItem
            // 
            this.ComplexBooksSearchMenuItem.Name = "ComplexBooksSearchMenuItem";
            this.ComplexBooksSearchMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ComplexBooksSearchMenuItem.Text = "Книги - сложно";
            this.ComplexBooksSearchMenuItem.Click += new System.EventHandler(this.ComplexBooksSearchMenuItem_Click);
            // 
            // SearchForBooksByTagAndCategoryMenuItem
            // 
            this.SearchForBooksByTagAndCategoryMenuItem.Name = "SearchForBooksByTagAndCategoryMenuItem";
            this.SearchForBooksByTagAndCategoryMenuItem.Size = new System.Drawing.Size(219, 22);
            this.SearchForBooksByTagAndCategoryMenuItem.Text = "Кинги - по таг и категория";
            this.SearchForBooksByTagAndCategoryMenuItem.Click += new System.EventHandler(this.SearchForBooksByTagAndCategoryMenuItem_Click);
            // 
            // CountrySearchMenuItem
            // 
            this.CountrySearchMenuItem.Name = "CountrySearchMenuItem";
            this.CountrySearchMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CountrySearchMenuItem.Text = "Държави";
            this.CountrySearchMenuItem.Click += new System.EventHandler(this.CountrySearchMenuItem_Click);
            // 
            // PublisherSearchMenuItem
            // 
            this.PublisherSearchMenuItem.Name = "PublisherSearchMenuItem";
            this.PublisherSearchMenuItem.Size = new System.Drawing.Size(219, 22);
            this.PublisherSearchMenuItem.Text = "Издатели";
            this.PublisherSearchMenuItem.Click += new System.EventHandler(this.PublisherSearchMenuItem_Click);
            // 
            // AuthorSearchComplexMenuItem
            // 
            this.AuthorSearchComplexMenuItem.Name = "AuthorSearchComplexMenuItem";
            this.AuthorSearchComplexMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AuthorSearchComplexMenuItem.Text = "Автор - сложно";
            this.AuthorSearchComplexMenuItem.Click += new System.EventHandler(this.AuthorSearchComplexMenuItem_Click);
            // 
            // ExitAppMenuItem
            // 
            this.ExitAppMenuItem.Name = "ExitAppMenuItem";
            this.ExitAppMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ExitAppMenuItem.Text = "Изход";
            this.ExitAppMenuItem.Click += new System.EventHandler(this.ExitAppMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 436);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesMenuIItem;
        private System.Windows.Forms.ToolStripMenuItem TagsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublishersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComplexBooksSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchForBooksByTagAndCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountrySearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublisherSearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorSearchComplexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitAppMenuItem;
    }
}