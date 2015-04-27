namespace SimpleBookStore.Web.Mvc.Providers.Contracts
{
    using System.Collections.Generic;

    using SimpleBookStore.Web.Mvc.Providers.Models;

    public interface INewsProvider
    {
        IEnumerable<News> FetchNews();
    }
}
