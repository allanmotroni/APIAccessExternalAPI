using APIAccessExternalAPI.Models;
using APIAccessExternalAPI.Utils.Extension;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonAPIService pokemonAPIService;
        public PokemonService(IPokemonAPIService pokemonAPIService)
        {
            this.pokemonAPIService = pokemonAPIService;
        }

        public async Task<List<Pokemon>> GetAllAsync(string baseURL, string endpoint)
        {
            string urlCompleta = System.IO.Path.Combine(baseURL, endpoint);
            
            PokemonAPI pokemonAPI = await pokemonAPIService.Get(urlCompleta);

            List<Pokemon> pokemons = pokemonAPI.Pokemons;
            return pokemons;
        }
    }
}
