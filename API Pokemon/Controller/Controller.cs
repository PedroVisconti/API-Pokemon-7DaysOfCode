using API_Pokemon.Model;
using API_Pokemon.Service;
using API_Pokemon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon.Controller
{
    public class controller
    {
        public string nome { get; set; }
        private List<Pokemon> pokemonsAdotados { get; set; }
        private pokemonView mensagens { get; set; }

        public controller()
        {
            controllerPokemon();
            jogar();
        }
        public void controllerPokemon()
        {
            this.pokemonsAdotados = new List<Pokemon>();
            this.mensagens = new pokemonView();
        }

        public void jogar()
        {
            int jogar = 1;
            string opcao;
            while(jogar == 1)
            {
                mensagens.menuPrincipal();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        adotarPokemon(opcao);
                        break;

                    case "2":
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Obrigado por usar o sistema, até mais");
                        jogar = 0;
                        break;

                    default:
                        Console.WriteLine("Opcao invalida, tente novamente");
                        break;
                }

            }
        }

        public void adotarPokemon(string opcao)
        {
            Pokemon pokemon = new Pokemon();
            string escolhaPokemonUsuario = mensagens.escolherPokemon();

            while (opcao != "3")
            {

                string opcao2 = mensagens.saberMais(escolhaPokemonUsuario);

                switch (opcao2)
                {

                    case "1":
                        pokemon = buscarPokemon.BuscarPokemon(escolhaPokemonUsuario);
                        mensagens.saberMaisPokemon(pokemon);
                        break;

                    case "2":
                        pokemon = buscarPokemon.BuscarPokemon(escolhaPokemonUsuario);
                        pokemonsAdotados.Add(pokemon);
                        mensagens.adotarPokemon(pokemon);
                        opcao = "3";
                        break;

                    case "3":
                        opcao = "3";
                        break;

                    default:
                        Console.WriteLine("Opcao invalida, tente novamente");
                        break;
                }
            }
        }


    }

}

