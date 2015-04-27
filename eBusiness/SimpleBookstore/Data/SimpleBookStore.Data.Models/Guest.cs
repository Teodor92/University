namespace SimpleBookStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Guest
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
