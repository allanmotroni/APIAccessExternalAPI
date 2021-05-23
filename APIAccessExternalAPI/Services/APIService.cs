using APIAccessExternalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Services
{
    public class APIService : IAPIService
    {
        private readonly IHttpClientFactory httpClientFactory;
        public APIService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        //public async Task<IEnumerable<Pokemon>> Get(string baseUrl, string endpoint)
        //{
        //    IEnumerable<Pokemon> pokemons = new List<Pokemon>();

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseUrl);
        //        client.DefaultRequestHeaders.Add("Accept", "application/json");

        //        using (HttpResponseMessage response = await client.GetAsync(endpoint))
        //        {
        //            //response.EnsureSuccessStatusCode();
        //            string jsonPokemons = await response.Content.ReadAsStringAsync();

        //        }
        //    }

        //    return pokemons;
        //}

        public async Task<string> Get(string url)
        {
            string json = string.Empty;
            using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                HttpClient client = httpClientFactory.CreateClient();
                using (HttpResponseMessage response = await client.SendAsync(httpRequestMessage)) 
                { 
                    //response.EnsureSuccessStatusCode();
                    json = await response.Content.ReadAsStringAsync();
                }
            }

            return json;
        }
    }
}
