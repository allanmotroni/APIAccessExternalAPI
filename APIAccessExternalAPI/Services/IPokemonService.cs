using APIAccessExternalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Services
{
    public interface IPokemonService
    {
        public Task<List<Pokemon>> GetAllAsync(string baseURL, string endpoint);
    }
}
