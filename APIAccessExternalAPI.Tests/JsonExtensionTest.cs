using APIAccessExternalAPI.Models;
using APIAccessExternalAPI.Utils.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace APIAccessExternalAPI.Tests
{
    [TestClass]
    public class JsonExtensionTest
    {
        private string RetornarPokemonAPIJson()
        {
            return "{\"count\":1118,\"next\":\"https://pokeapi.co/api/v2/pokemon/?offset=20&limit=20\",\"previous\":null,\"results\":[{\"name\":\"bulbasaur\",\"url\":\"https://pokeapi.co/api/v2/pokemon/1/\"},{\"name\":\"ivysaur\",\"url\":\"https://pokeapi.co/api/v2/pokemon/2/\"},{\"name\":\"venusaur\",\"url\":\"https://pokeapi.co/api/v2/pokemon/3/\"},{\"name\":\"charmander\",\"url\":\"https://pokeapi.co/api/v2/pokemon/4/\"},{\"name\":\"charmeleon\",\"url\":\"https://pokeapi.co/api/v2/pokemon/5/\"},{\"name\":\"charizard\",\"url\":\"https://pokeapi.co/api/v2/pokemon/6/\"},{\"name\":\"squirtle\",\"url\":\"https://pokeapi.co/api/v2/pokemon/7/\"},{\"name\":\"wartortle\",\"url\":\"https://pokeapi.co/api/v2/pokemon/8/\"},{\"name\":\"blastoise\",\"url\":\"https://pokeapi.co/api/v2/pokemon/9/\"},{\"name\":\"caterpie\",\"url\":\"https://pokeapi.co/api/v2/pokemon/10/\"},{\"name\":\"metapod\",\"url\":\"https://pokeapi.co/api/v2/pokemon/11/\"},{\"name\":\"butterfree\",\"url\":\"https://pokeapi.co/api/v2/pokemon/12/\"},{\"name\":\"weedle\",\"url\":\"https://pokeapi.co/api/v2/pokemon/13/\"},{\"name\":\"kakuna\",\"url\":\"https://pokeapi.co/api/v2/pokemon/14/\"},{\"name\":\"beedrill\",\"url\":\"https://pokeapi.co/api/v2/pokemon/15/\"},{\"name\":\"pidgey\",\"url\":\"https://pokeapi.co/api/v2/pokemon/16/\"},{\"name\":\"pidgeotto\",\"url\":\"https://pokeapi.co/api/v2/pokemon/17/\"},{\"name\":\"pidgeot\",\"url\":\"https://pokeapi.co/api/v2/pokemon/18/\"},{\"name\":\"rattata\",\"url\":\"https://pokeapi.co/api/v2/pokemon/19/\"},{\"name\":\"raticate\",\"url\":\"https://pokeapi.co/api/v2/pokemon/20/\"}]}";
        }

        private string RetornarListaPokemonJson() 
        {
            return "[{\"name\": \"Teste 01\", \"url\":\"\"},{\"name\": \"Teste 02\", \"url\":\"\"},{\"name\": \"Teste 03\", \"url\":\"\"}]";
        }

        private IEnumerable<Pokemon> RetornarPokemon()
        {
            return new List<Pokemon>()
            {
                new Pokemon() { Name="Teste 01",Url="" },
                new Pokemon() { Name="Teste 02",Url="" },
                new Pokemon() { Name="Teste 03",Url="" }
            };
        }

        [TestMethod]
        public void ToClassOfTest()
        {
            string json = RetornarPokemonAPIJson();

            PokemonAPI pokemonAPI = json.ToClassOf<PokemonAPI>();

            Assert.IsNotNull(pokemonAPI);
            Assert.IsInstanceOfType(pokemonAPI, typeof(PokemonAPI));
        }

        [TestMethod]
        public void ToListClassOfTest()
        {
            string json = RetornarListaPokemonJson();

            List<Pokemon> pokemons = json.ToListClassOf<Pokemon>();

            Assert.IsNotNull(pokemons);
            Assert.IsInstanceOfType(pokemons, typeof(List<Pokemon>));
            Assert.IsTrue(pokemons.Count > 0);
        }

        [TestMethod]
        public void ToJson()
        {
            IEnumerable<Pokemon> pokemons = RetornarPokemon();

            string json = pokemons.ToJson();

            Assert.IsNotNull(json);
            Assert.IsFalse(string.IsNullOrEmpty(json));
        }

    }
}
