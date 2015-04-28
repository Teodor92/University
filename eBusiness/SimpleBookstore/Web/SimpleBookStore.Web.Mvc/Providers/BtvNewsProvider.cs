namespace SimpleBookStore.Web.Mvc.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using SimpleBookStore.Web.Mvc.Providers.Common;
    using SimpleBookStore.Web.Mvc.Providers.Models;

    public class BtvNewsProvider : BaseNewsProvider
    {
        private const string BtvUrl = "http://btvnovinite.bg/lbin/rss.php";
        private const string BtvEncoding = "utf-8";

        public override IEnumerable<News> FetchNews()
        {
            var document = this.GetXmlDocument(BtvUrl, BtvEncoding);

            var items = document
                .Element("rss")
                .Element("channel")
                .Descendants("item")
                .Select(x => new News
                {
                    Source = x.Element("link").Value,
                    Author = "BTV",
                    Title = x.Element("title").Value,
                    Content = x.Element("description").Value,
                    CreatedOn = DateTime.Parse(x.Element("pubDate").Value)
                })
                         .ToList();

            return items;
        }
    }
}