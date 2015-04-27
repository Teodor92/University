﻿namespace OJS.Web.Areas.Administration.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using SimpleBookStore.Web.Mvc.Providers.Common;
    using SimpleBookStore.Web.Mvc.Providers.Models;

    public class InfoManNewsProvider : BaseNewsProvider
    {
        private const string ContentUrl = "http://infoman.musala.com/feeds/";
        private const string ContentEncoding = "utf-8";

        public override IEnumerable<News> FetchNews()
        {
            var document = this.GetHtmlDocument(ContentUrl, ContentEncoding);

            var nodes = document.DocumentNode.SelectNodes("//rss//channel//item");

            var currentListOfNews = new List<News>();

            foreach (var node in nodes)
            {
                var title = node.ChildNodes.First(n => n.Name == "title").InnerHtml;
                var description = node.ChildNodes.First(n => n.Name == "description").InnerHtml;
                var date = node.ChildNodes.First(n => n.Name == "pubdate").InnerHtml;
                var linkAddress = node.ChildNodes.First(n => n.Name == "guid").InnerHtml;
                var link = "<a href='" + linkAddress + "'>" + linkAddress + "</a>";

                var decodedDescription = HttpUtility.HtmlDecode(description);
                
                var parsedDate = DateTime.Parse(date);

                currentListOfNews.Add(new News
                {
                    Title = title,
                    Content = this.ConvertLinks(decodedDescription, "http://infoman.musala.com/") + "<br />" + link,
                    Author = "ИнфоМан",
                    Source = "http://infoman.musala.com/",
                    CreatedOn = parsedDate
                });
            }

            return currentListOfNews;
        }
    }
}