namespace Slms.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Slms.Data.Contracts;

    public class Author : DeletableEntity, IIdentifiable<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
