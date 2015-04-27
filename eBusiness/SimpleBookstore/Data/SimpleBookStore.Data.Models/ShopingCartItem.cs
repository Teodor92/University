namespace SimpleBookStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ShopingCartItem
    {
        [Key]
        public int Id { get; set; }

        public string OrderId { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
