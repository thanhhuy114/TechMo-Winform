using Librarys;
using TechMo.Models;
using TechMo.Models.RequestModel;
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
    public class ConfigsDetailViewModels
    {
        public ConfigsDetailViewModels()
        {
            _restClient = new RestClient(Constants.BaseAPI);
        }
        private readonly RestClient _restClient;
        private CrawlConfig _crawlConfig;
        private List<CrawlActionDetails> _crawlActionDetails;
        private List<CrawlDetails> _crawlDetails;
        private List<CrawlOptionDetails> _crawlOptionDetails;
        public CrawlConfig GetCrawlConfig
        {
            get => _crawlConfig;
            set => _crawlConfig = value;
        }
        public List<CrawlOptionDetails> GetCrawlOptionDetails
        {
            get => _crawlOptionDetails;
            set => _crawlOptionDetails = value;
        }

        public List<CrawlDetails> GetCrawlDetails
        {
            get => _crawlDetails;
            set => _crawlDetails = value;
        }
        public List<CrawlActionDetails> GetCrawlActionDetails
        {
            get => _crawlActionDetails;
            set => _crawlActionDetails = value;
        }

        public async Task GetCrawlConfigDetailFromApiAsync(int id)
        {
            try
            {
                var request = new RestRequest($"/crawl-config/get/{id}", Method.Get);
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Program.Logger.Debug(JToken.Parse(response.Content).ToString(Formatting.Indented));

                    ConfigDetailResponseModel configDetailResponseModel = JsonConvert.DeserializeObject<ConfigDetailResponseModel>(response.Content);

                    _crawlConfig = configDetailResponseModel.CrawlConfig;
                    _crawlActionDetails = configDetailResponseModel.CrawlActionDetails;
                    _crawlOptionDetails = configDetailResponseModel.CrawlOptionDetails;
                    _crawlDetails = configDetailResponseModel.CrawlDetails;
                }
                else
                {
                    Program.Logger.Error(response.ErrorMessage);
                    _crawlConfig = null;
                }
            }
            catch (Exception ex)
            {
                Program.Logger.Error(ex.Message.ToString());
                _crawlConfig = null;
            }
        }
        

        public async Task<string> FetchDataByConfigFromApiAsync()
        {
            try
            {
                AddCrawlConfigHtmlRequirestModel requestModel = new AddCrawlConfigHtmlRequirestModel(_crawlConfig, _crawlActionDetails, _crawlDetails, _crawlOptionDetails);
                var request = new RestRequest($"/crawl/crawl-data", Method.Post);
                return "";
                request.AddBody(JsonConvert.SerializeObject(requestModel, Formatting.Indented));
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Program.Logger.Debug(JToken.Parse(response.Content).ToString(Formatting.Indented));
                    return response.Content;
                }
                else
                {
                    Program.Logger.Error(response.ErrorMessage);
                    throw new InvalidOperationException(response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Program.Logger.Error(ex.Message.ToString());
                return "";
            }
        }
    }
}
