using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlTypes : IEquatable<CrawlTypes>
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }

        public CrawlTypes(int id, string type, string key, string description)
        {
            Id = id;
            Type = type;
            Key = key;
            Description = description;
        }

        public bool Equals(CrawlTypes other)
        {
            return other != null &&
                   Id == other.Id &&
                   Type == other.Type &&
                   Key == other.Key &&
                   Description == other.Description;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlTypes);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
        {
            return $"CrawlTypes {{ Id = {Id}, Type = {Type}, Key = {Key}, Description = {Description} }}";
        }

        public static readonly CrawlTypes Html = new CrawlTypes(
          1,
          "HTML",
          "html",
          "Thu thập dữ liệu bằng cách truy xuất các selector trong trang HTML"
      );

        public static readonly CrawlTypes Api = new CrawlTypes(
            2,
            "API",
            "api",
            "Thu thập dữ liệu bằng cách truy xuất các API được trang web cung cấp"
        );

        public static readonly CrawlTypes Rss = new CrawlTypes(
            3,
            "RSS",
            "rss",
            "Thu thập dữ liệu bằng RSS"
        );

        public static readonly List<CrawlTypes> crawlTypesMockup = new List<CrawlTypes> { Html, Api, Rss };

        public static CrawlTypes GetCrawlType(int id)
        {
            return crawlTypesMockup.FirstOrDefault(e => e.Id == id) ?? crawlTypesMockup[0];
        }
    }
}
