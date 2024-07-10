using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{

    public class CrawlDetails : IEquatable<CrawlDetails>
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("crawl_config_id")]
        public int CrawlConfigID { get; set; }

        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("data_type_id")]
        public int DataTypeID { get; set; }

        public CrawlDetails(int id, string name, int crawlConfigID, string selector, string attribute, int dataTypeID)
        {
            Id = id;
            Name = name;
            CrawlConfigID = crawlConfigID;
            Selector = selector;
            Attribute = attribute;
            DataTypeID = dataTypeID;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlDetails);
        }

        public bool Equals(CrawlDetails other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&
                   CrawlConfigID == other.CrawlConfigID &&
                   Selector == other.Selector &&
                   Attribute == other.Attribute &&
                   DataTypeID == other.DataTypeID;
        }


        public override int GetHashCode()
        {
            return 1;
        }
    }
}
