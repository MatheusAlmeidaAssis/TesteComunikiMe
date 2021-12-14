using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Web.Repositories
{
    public class RepositoryBase<Dto> where Dto : DtoBase
    {
        private readonly HttpClient _client;

        public RepositoryBase()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44369/")
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applcation/json"));
        }

        public async Task<Dto> Add(Dto dto)
        {
            var contentJson = JsonConvert.SerializeObject(dto);
            var content = new StringContent(contentJson, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(typeof(Dto).Name.Replace("Dto", "s"), content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                dto = JsonConvert.DeserializeObject<Dto>(responseString);
            }
            return dto;
        }

        public async Task<IEnumerable<Dto>> Get()
        {
            var response = await _client.GetAsync(typeof(Dto).Name.Replace("Dto", "s"));
            var dtos = new List<Dto>();
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                dtos = JsonConvert.DeserializeObject<List<Dto>>(responseString);
            }
            return dtos;
        }

        public async Task<Dto> Get(int id)
        {
            var response = await _client.GetAsync($"{typeof(Dto).Name.Replace("Dto", "s")}/{id}");
            var dto = new DtoBase() as Dto;
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                dto = JsonConvert.DeserializeObject<Dto>(responseString);
            }
            return dto;
        }

        public async Task<Dto> Remove(int id)
        {
            var response = await _client.DeleteAsync($"{typeof(Dto).Name.Replace("Dto", "s")}?id={id}");
            var dto = new DtoBase() as Dto;
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                dto = JsonConvert.DeserializeObject<Dto>(responseString);
            }
            return dto;
        }

        public async Task<Dto> Update(Dto dto)
        {
            var contentJson = JsonConvert.SerializeObject(dto);
            var content = new StringContent(contentJson, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync(typeof(Dto).Name.Replace("Dto", "s"), content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                dto = JsonConvert.DeserializeObject<Dto>(responseString);
            }
            return dto;
        }
    }
}