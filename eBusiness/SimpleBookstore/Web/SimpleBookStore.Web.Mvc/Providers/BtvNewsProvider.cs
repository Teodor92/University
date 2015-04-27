namespace SimpleBookStore.Web.Mvc.Providers
{
    using System;
    using System.Collections.Generic;

    using SimpleBookStore.Web.Mvc.Providers.Common;
    using SimpleBookStore.Web.Mvc.Providers.Models;

    public class BtvNewsProvider : BaseNewsProvider
    {
        public override IEnumerable<News> FetchNews()
        {
            throw new NotImplementedException();
        }
    }
}