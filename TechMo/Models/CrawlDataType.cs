using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlDataTypes : IEquatable<CrawlDataTypes>
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int CrawlConfigID { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public bool IsTextField { get; set; }

        public CrawlDataTypes(int id, string type, int crawlConfigID, string key, string description, bool isTextField)
        {
            Id = id;
            Type = type;
            CrawlConfigID = crawlConfigID;
            Key = key;
            Description = description;
            IsTextField = isTextField;
        }

        public bool Equals(CrawlDataTypes other)
        {
            return other != null &&
                   Id == other.Id &&
                   Type == other.Type &&
                   CrawlConfigID == other.CrawlConfigID &&
                   Key == other.Key &&
                   Description == other.Description &&
                   IsTextField == other.IsTextField;
        }

        

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlDataTypes);
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public static List<CrawlDataTypes> crawlCrawlDataTypesMockup = new List<CrawlDataTypes>
        {
          new CrawlDataTypes(
            id: 1,
            type: "content",
            crawlConfigID: 1,
            key: "content",
            description: "Lấy nội dung của thẻ",
            isTextField: false
        ),
        new CrawlDataTypes(
            id: 2,
            type: "count",
            crawlConfigID: 2,
            key: "count",
            description: "Đếm số lượng thẻ này",
            isTextField: false
        ),
        new CrawlDataTypes(
            id: 3,
            type: "attribute",
            crawlConfigID: 3,
            key: "attribute",
            description: "Lấy nội dung của một thuộc tính trong thẻ",
            isTextField: true
        )
        };

        public static CrawlDataTypes GetCrawlDataType(int id)
        {
            return crawlCrawlDataTypesMockup.FirstOrDefault(e => e.Id == id) ?? crawlCrawlDataTypesMockup[0];
        }

        public override string ToString()
        {
            return $"CrawlDataTypes {{ Id = {Id}, Type = {Type}, CrawlConfigID = {CrawlConfigID}, Key = {Key}, Description = {Description}, IsTextField = {IsTextField} }}";
        }
    }
}
