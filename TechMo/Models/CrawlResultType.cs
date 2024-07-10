using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlResultTypes : IEquatable<CrawlResultTypes>
    {
        public int Id { get; }
        public string Type { get; }
        public string Key { get; }
        public string Description { get; }
        public bool IsTextField { get; }

        public CrawlResultTypes(int id, string type, string key, string description, bool isTextField)
        {
            Id = id;
            Type = type;
            Key = key;
            Description = description;
            IsTextField = isTextField;
        }

        public bool Equals(CrawlResultTypes other)
        {
            if (other == null) return false;
            return Id == other.Id && Type == other.Type && Key == other.Key && Description == other.Description && IsTextField == other.IsTextField;
        }

        public override bool Equals(object obj)
        {
            if (obj is CrawlResultTypes other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
        {
            return $"{Type} ({Key}): {Description} - IsTextField: {IsTextField}";
        }


        public static List<CrawlResultTypes> crawlResultTypesMockup = new List<CrawlResultTypes>
        {
           new CrawlResultTypes(
            id: 1,
            type: "single",
            key: "single",
            description: "Lựa chọn này sẽ trả về kết quả kiểu 1 item",
            isTextField: false
        ),
        new CrawlResultTypes(
            id: 2,
            type: "multi",
            key: "multi",
            description: "Lựa chọn này sẽ trả về kết quả là danh sách các item",
            isTextField: true
        )
        };

        public static CrawlResultTypes GetResultType(int id)
        {
            return crawlResultTypesMockup.FirstOrDefault(e => e.Id == id) ?? crawlResultTypesMockup[0];
        }
    }
}
