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

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
