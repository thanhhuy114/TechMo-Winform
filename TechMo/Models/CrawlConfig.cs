using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.Models
{
    public class CrawlConfig : IEquatable<CrawlConfig>
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("item_selector")]
        public string Selector { get; set; }

        [JsonProperty("result_type_id")]
        public int? CrawlResultTypesID { get; set; }

        [JsonProperty("crawl_type_id")]
        public int? CrawlTypesID { get; set; }

        [JsonProperty("item_type_id")]
        public int? ItemTypesID { get; set; }

        [JsonProperty("website_id")]
        public int? WebsiteID { get; set; }

        [JsonProperty("http_method_type_id")]
        public string HttpMethodTypeID { get; set; }

        [JsonProperty("body_api")]
        public string BodyApi { get; set; }

        [JsonProperty("headers_api")]
        public string HeadersApi { get; set; }

        [JsonProperty("update_at")]
        public string UpdateAT { get; set; }

        public CrawlConfig(
            int? id,
            string name,
            string description,
            string url,
            string selector,
            int? crawlResultTypesID,
            int? crawlTypesID,
            int? itemTypesID,
            int? websiteID,
            string httpMethodTypeID,
            string bodyApi,
            string headersApi,
            string updateAT)
        {
            Id = id;
            Name = name;
            Description = description;
            Url = url;
            Selector = selector;
            CrawlResultTypesID = crawlResultTypesID;
            CrawlTypesID = crawlTypesID;
            ItemTypesID = itemTypesID;
            WebsiteID = websiteID;
            HttpMethodTypeID = httpMethodTypeID;
            BodyApi = bodyApi;
            HeadersApi = headersApi;
            UpdateAT = updateAT;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CrawlConfig);
        }

        public bool Equals(CrawlConfig other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&
                   Description == other.Description &&
                   Url == other.Url &&
                   Selector == other.Selector &&
                   CrawlResultTypesID == other.CrawlResultTypesID &&
                   CrawlTypesID == other.CrawlTypesID &&
                   ItemTypesID == other.ItemTypesID &&
                   WebsiteID == other.WebsiteID &&
                   HttpMethodTypeID == other.HttpMethodTypeID &&
                   BodyApi == other.BodyApi &&
                   HeadersApi == other.HeadersApi;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
