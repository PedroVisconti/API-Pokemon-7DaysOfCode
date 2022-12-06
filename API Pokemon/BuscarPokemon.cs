using API_Pokemon.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Pokemon
{
    public class buscarPokemon {
        public static Pokemon BuscarPokemon(string nomePokemon)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{nomePokemon.ToLower()}");

            var request = new RestRequest("",Method.Get);

            var response = client.Execute(request);

            return JsonSerializer.Deserialize<Pokemon>(response.Content);
        }
    }
    
}
