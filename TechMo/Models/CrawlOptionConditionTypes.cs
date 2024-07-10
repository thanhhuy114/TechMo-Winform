using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{

    public class CrawlOptionConditionTypes : IEquatable<CrawlOptionConditionTypes>
    {
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("key")]
        public string Key { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("is_text_field")]
        public bool IsTextField { get; }

        public CrawlOptionConditionTypes(int id, string type, string key, string description, bool isTextField)
        {
            Id = id;
            Type = type;
            Key = key;
            Description = description;
            IsTextField = isTextField;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlOptionConditionTypes);
        }

        public bool Equals(CrawlOptionConditionTypes other)
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

        public override string ToString()
        {
            return $"CrawlOptionConditionTypes(Id: {Id}, Type: {Type}, Key: {Key}, Description: {Description}, IsTextField: {IsTextField})";
        }
    }
}
