namespace Slms.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Slms.Data.Contracts;

    public class Tag : DeletableEntity, IIdentifiable<int>
    {
        private ICollection<Book> books;

        public Tag()
        {
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
