using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlOptionDetails : IEquatable<CrawlOptionDetails>
    {
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("crawl_detail_id")]
        public int CrawlDetailID { get; }

        [JsonProperty("option_type_id")]
        public int? OptionTypeID { get; }

        [JsonProperty("option_value")]
        public string OptionValue { get; }

        [JsonProperty("type_option_condition_id")]
        public int? OptionConditionTypeID { get; }

        [JsonProperty("condition_value")]
        public string ConditionValue { get; }

        public CrawlOptionDetails(int id, int crawlDetailID, int? optionTypeID, string optionValue, int? optionConditionTypeID, string conditionValue)
        {
            Id = id;
            CrawlDetailID = crawlDetailID;
            OptionTypeID = optionTypeID;
            OptionValue = optionValue;
            OptionConditionTypeID = optionConditionTypeID;
            ConditionValue = conditionValue;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlOptionDetails);
        }

        public bool Equals(CrawlOptionDetails other)
        {
            return other != null &&
                   Id == other.Id &&
                   CrawlDetailID == other.CrawlDetailID &&
                   OptionTypeID == other.OptionTypeID &&
                   OptionValue == other.OptionValue &&
                   OptionConditionTypeID == other.OptionConditionTypeID &&
                   ConditionValue == other.ConditionValue;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
