using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models.ResponseModel
{
    public class AllCrawlConfigResponseModel
    {
        public AllCrawlConfigResponseModel(CrawlConfig crawlConfig) {
            CrawlConfig = crawlConfig;
        }

        [JsonProperty("crawl_config")]
        public CrawlConfig CrawlConfig { get; }


    }
}
