namespace SimpleBookStore.Web.Mvc.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using HtmlAgilityPack;

    using SimpleBookStore.Web.Mvc.Providers.Common;
    using SimpleBookStore.Web.Mvc.Providers.Models;

    public class SoftUniNewsProvider : BaseNewsProvider
    {
        private const string SoftUniUrl = "https://softuni.bg/feed/news";
        private const string SoftUniEncoding = "utf-8";

        public override IEnumerable<News> FetchNews()
        {
            var document = this.GetXmlDocument(SoftUniUrl, SoftUniEncoding);

            var atomNamespace = XNamespace.Get("http://www.w3.org/2005/Atom");

            var items = document
                .Element("rss")
                .Element("channel")
                .Descendants("item")
                .Select(x => new News
                         {
                             Source = x.Element("link").Value,
                             Author = "Software University",
                             Title = x.Element("title").Value,
                             Content = this.FixLinks(x.Element("description").Value),
                             CreatedOn = DateTime.Parse(x.Element(atomNamespace + "updated").Value)
                         })
                         .ToList();

            return items;
        }

        private string FixLinks(string input)
        {
            var document = new HtmlDocument();
            document.LoadHtml(input);
            var imageNodes = document.DocumentNode.SelectNodes("//img");

            if (imageNodes != null)
            {
                foreach (var imageNode in imageNodes)
                {
                    var originalValue = imageNode.Attributes["src"].Value;
                    var newValue = "https://softuni.bg" + originalValue;
                    imageNode.SetAttributeValue("src", newValue);
                }
            }

            return document.DocumentNode.OuterHtml;
        }
    }
}