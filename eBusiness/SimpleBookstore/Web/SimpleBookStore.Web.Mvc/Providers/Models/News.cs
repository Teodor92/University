namespace SimpleBookStore.Web.Mvc.Providers.Models
{
    using System;

    public class News
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Source { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}