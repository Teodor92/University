namespace Slms.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Slms.Data.Contracts;

    public class Country : DeletableEntity, IIdentifiable<int>
    {
        private ICollection<Author> authors;

        public Country()
        {
            this.authors = new HashSet<Author>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Author> Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }
    }
}
