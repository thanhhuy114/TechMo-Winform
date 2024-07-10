using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models.RequestModel
{
    public class AddCrawlConfigHtmlRequirestModel
    {
        [JsonProperty("crawl_config")]
        public CrawlConfig CrawlConfigsModel { get; }

        [JsonProperty("crawl_action_details")]
        public List<CrawlActionDetails> CrawlActionDetailsModels { get; }

        [JsonProperty("crawl_details")]
        public List<CrawlDetails> CrawlDetailsModels { get; }

        [JsonProperty("crawl_option_details")]
        public List<CrawlOptionDetails> CrawlOptionDetailsModels { get; }

        public AddCrawlConfigHtmlRequirestModel(
            CrawlConfig crawlConfigsModel,
            List<CrawlActionDetails> crawlActionDetailsModels,
            List<CrawlDetails> crawlDetailsModels,
            List<CrawlOptionDetails> crawlOptionDetailsModels)
        {
            CrawlConfigsModel = crawlConfigsModel;
            CrawlActionDetailsModels = crawlActionDetailsModels;
            CrawlDetailsModels = crawlDetailsModels;
            CrawlOptionDetailsModels = crawlOptionDetailsModels;
        }
    }
}
