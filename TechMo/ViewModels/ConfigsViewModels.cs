using Librarys;
using TechMo.Models;
using TechMo.Models.ResponseModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TechMo.ViewModels
{
    public class ConfigsViewModels
    {
        public ConfigsViewModels()
        {
            _restClient = new RestClient(Constants.BaseAPI);
            _crawlConfig = new List<CrawlConfig>();
        }
        private readonly RestClient _restClient;
        private List<CrawlConfig> _crawlConfig;

        public List<CrawlConfig> GetCrawlConfigs => _crawlConfig;

        public async Task<List<AllCrawlConfigResponseModel>> GetCrawlConfigsFromApiAsync()
        {
            try
            {
                var request = new RestRequest("/crawl-config/get-all", Method.Get);
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Program.Logger.Debug(JToken.Parse(response.Content).ToString(Formatting.Indented));

                    List<AllCrawlConfigResponseModel> allCrawlConfigResponseModels = JsonConvert.DeserializeObject<List<AllCrawlConfigResponseModel>>(response.Content);

                    return allCrawlConfigResponseModels;                  
                }
                else
                {
                    Program.Logger.Error(response.ErrorMessage);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Program.Logger.Error(ex.Message.ToString());
                return null;
            }


        }
    }
}
