namespace SimpleBookStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string BookId { get; set; }

        public int TypeId { get; set; }

        public BookType Type { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsOnSale { get; set; }
    }
}
