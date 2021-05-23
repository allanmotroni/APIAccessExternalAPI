using APIAccessExternalAPI.Models;
using APIAccessExternalAPI.Utils.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Services
{
    public class PokemonAPIService : IPokemonAPIService
    {
        private readonly IAPIService apiService;
        public PokemonAPIService(IAPIService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<PokemonAPI> Get(string url)
        {
            string json = await apiService.Get(url);

            PokemonAPI pokemonAPI = json.ToClassOf<PokemonAPI>();

            return pokemonAPI;
        }
    }
}
