using JsonApiSerializer;
using rivER_web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;
using Microsoft.Extensions.Options;

namespace rivER_web.Services
{
    public class RiverAPIService : IRiverAPIService
    {
        static HttpClient httpClient;
        static JsonApiSerializerSettings jsonApiSerializerSettings;

        public RiverAPIService(IOptions<RiverAPIConfiguration> options)
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(options.Value.BaseAddress)
            };

            jsonApiSerializerSettings = new JsonApiSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
            };
        }

        public async Task<IEnumerable<T>> GetRiverModelsAsync<T>(string queryParameters = null)
            where T : BaseIdentifiable, new()
        {
            var model = new T();
            var response = await httpClient.GetAsync(model.Type + queryParameters);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(content, jsonApiSerializerSettings);
        }

        public async Task<T> GetRiverModelByIdAsync<T>(string id, string queryParameters = null)
            where T : BaseIdentifiable, new()
        {
            var model = new T();
            var response = await httpClient.GetAsync($"{model.Type}/{id}" + queryParameters);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content, jsonApiSerializerSettings);
        }

        public async Task<T> PostRiverModelAsync<T>(T model)
            where T : BaseIdentifiable
        {
            var jsonContent = JsonConvert.SerializeObject(model, jsonApiSerializerSettings);
            var postContent = new StringContent(jsonContent);
            postContent.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.api+json");

            var response = await httpClient.PostAsync(model.Type, postContent);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content, jsonApiSerializerSettings);
        }
    }
}