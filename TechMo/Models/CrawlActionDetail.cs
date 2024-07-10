using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    using Newtonsoft.Json;

    public class CrawlActionDetails : IEquatable<CrawlActionDetails>
    {
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("crawl_config_id")]
        public int CrawlConfigID { get; }

        [JsonProperty("action_type_id")]
        public int ActionTypeID { get; }

        [JsonProperty("selector")]
        public string Selector { get; }

        public CrawlActionDetails(int id, int crawlConfigID, int actionTypeID, string selector)
        {
            Id = id;
            CrawlConfigID = crawlConfigID;
            ActionTypeID = actionTypeID;
            Selector = selector;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlActionDetails);
        }

        public bool Equals(CrawlActionDetails other)
        {
            return other != null &&
                   Id == other.Id &&
                   CrawlConfigID == other.CrawlConfigID &&
                   ActionTypeID == other.ActionTypeID &&
                   Selector == other.Selector;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }


}
