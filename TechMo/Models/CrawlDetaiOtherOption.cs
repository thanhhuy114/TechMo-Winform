using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlDetaiOtherOption : IEquatable<CrawlDetaiOtherOption>
    {
        public string Name { get; }
        public Type Type { get; }
        public string Description { get; }
        public string Key { get; }

        public CrawlDetaiOtherOption(string name, Type type, string description, string key)
        {
            Name = name;
            Type = type;
            Description = description;
            Key = key;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlDetaiOtherOption);
        }

        public bool Equals(CrawlDetaiOtherOption other)
        {
            return other != null &&
                   Name == other.Name &&
                   EqualityComparer<Type>.Default.Equals(Type, other.Type) &&
                   Description == other.Description &&
                   Key == other.Key;
        }

        public static List<CrawlDetaiOtherOption> crawlDetaiOtherOptions = new List<CrawlDetaiOtherOption>
        {
            new CrawlDetaiOtherOption(
                key: "option",
                name: "Loại lựa chọn",
                description: "",
                type: typeof(CrawlOptionTypes)
            ),
            new CrawlDetaiOtherOption(
                key: "condition",
                name: "Loại điều kiện",
                description: "",
                type: typeof(CrawlOptionConditionTypes)
            )
        };

        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
        {
            return $"CrawlDetaiOtherOption(Name: {Name}, Type: {Type}, Description: {Description}, Key: {Key})";
        }
    }
}
