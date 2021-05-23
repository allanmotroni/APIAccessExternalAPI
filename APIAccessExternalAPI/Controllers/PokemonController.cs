using APIAccessExternalAPI.Models;
using APIAccessExternalAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService servicePokemon;
        private readonly IConfiguration configuration; 
        //private readonly ILogger<WeatherForecastController> _logger;

        public PokemonController(IPokemonService servicePokemon/*, ILogger<WeatherForecastController> logger*/, IConfiguration configuration)
        {
            this.servicePokemon = servicePokemon;
            //_logger = logger;
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<IEnumerable<Pokemon>> GetAll()
        {
            string baseURL = configuration["BaseURL:PokeAPIv2:URL"];
            string endpoint = configuration["BaseURL:PokeAPIv2:Endpoint:Pokemon"];
            
            IEnumerable<Pokemon> pokemons = await servicePokemon.GetAllAsync(baseURL, endpoint);
            
            return pokemons;
        }
    }
}
