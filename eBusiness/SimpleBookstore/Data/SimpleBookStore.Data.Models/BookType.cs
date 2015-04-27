namespace SimpleBookStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class BookType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
