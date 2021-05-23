using APIAccessExternalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Services
{
    public interface IPokemonAPIService
    {
        public Task<PokemonAPI> Get(string url);
    }
}
