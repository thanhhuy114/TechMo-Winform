using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models.ResponseModel
{
    internal class ConfigDetailResponseModel
    {
        public ConfigDetailResponseModel(CrawlConfig crawlConfig, List<CrawlActionDetails> crawlActionDetails, List<CrawlDetails> crawlDetails, List<CrawlOptionDetails> crawlOptionDetails)
        {
            CrawlConfig = crawlConfig;
            CrawlActionDetails = crawlActionDetails;
            CrawlDetails = crawlDetails;
            CrawlOptionDetails = crawlOptionDetails;
        }

        [JsonProperty("crawl_config")]
        public CrawlConfig CrawlConfig { get; }

        [JsonProperty("crawl_action_details")]
        public List<CrawlActionDetails> CrawlActionDetails { get; }

        [JsonProperty("crawl_details")]
        public List<CrawlDetails> CrawlDetails { get; }

        [JsonProperty("crawl_option_details")]
        public List<CrawlOptionDetails> CrawlOptionDetails { get; }
    }
}
