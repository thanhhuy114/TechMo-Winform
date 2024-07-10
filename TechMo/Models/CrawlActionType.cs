using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlActionTypes : IEquatable<CrawlActionTypes>
    {
        public int Id { get; }
        public string Type { get; }
        public string Key { get; }
        public string Description { get; }
        public bool IsTextField { get; }

        public CrawlActionTypes(int id, string type, string key, string description, bool isTextField)
        {
            Id = id;
            Type = type;
            Key = key;
            Description = description;
            IsTextField = isTextField;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlActionTypes);
        }

        public bool Equals(CrawlActionTypes other)
        {
            return other != null &&
                   Id == other.Id &&
                   Type == other.Type &&
                   Key == other.Key &&
                   Description == other.Description &&
                   IsTextField == other.IsTextField;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public static List<CrawlActionTypes> crawlCrawlActionTypesMockup = new List<CrawlActionTypes>
        {
           new CrawlActionTypes(
            id: 1,
            type: "Click when appear",
            key: "click_when_appear",
            description: "Ấn mỗi khi phần tử này xuất hiện trên màn hình",
            isTextField: true
        ),
         new CrawlActionTypes(
            id: 2,
            type: "Show all",
            key: "show_all",
            description: "Ấn liên tục vào phần tử này cho đến khi tất cả dữ liệu hiện ra hoặc phần tử này không còn xuất hiện nữa rồi mới thực hiện lấy dữ liệu",
            isTextField: true
            ),
        };

        public static CrawlActionTypes GetCrawlActionType(int id)
        {
            return crawlCrawlActionTypesMockup.FirstOrDefault(e => e.Id == id) ?? crawlCrawlActionTypesMockup[0];
        }
    }

}
