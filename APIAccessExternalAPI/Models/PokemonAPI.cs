using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Models
{
    [Serializable]
    public class PokemonAPI
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        
        [JsonPropertyName("next")]
        public string Next { get; set; }
        
        [JsonPropertyName("previous")]
        public string Previous { get; set; }
        
        [JsonPropertyName("results")]
        public List<Pokemon> Pokemons { get; set; }

    }

    
}
