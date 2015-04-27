namespace SimpleBookStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        private ICollection<ShopingCartItem> shopingCartItems;

        public Book()
        {
            this.shopingCartItems = new HashSet<ShopingCartItem>();
        }

        [Key]
        public int Id { get; set; }

        public string BookId { get; set; }

        public int TypeId { get; set; }

        public virtual BookType Type { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsOnSale { get; set; }

        public virtual ICollection<ShopingCartItem> ShopingCartItems
        {
            get { return this.shopingCartItems; }
            set { this.shopingCartItems = value; }
        }
    }
}
