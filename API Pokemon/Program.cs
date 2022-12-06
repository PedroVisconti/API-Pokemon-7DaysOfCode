using API_Pokemon;
using API_Pokemon.Model;
using API_Pokemon_View;
using RestSharp;
using System.Runtime.CompilerServices;


public class program
{
    public static void Main(string[] args)
    {

        List<Pokemon> pokemonAdotado = new List<Pokemon>();
        View mensagens  = new View();

        string opcao;

        do
        {
            mensagens.menuPrincipal();
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

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
                                pokemonAdotado.Add(pokemon);
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
                    break;

                case "2": //interação
                    break;
                case "9":
                    Console.WriteLine("Obrigado por usar o sistema, até mais");
                    break;

                default:
                    Console.WriteLine("Opcao invalida, tente novamente");
                    break;
            }

        } while (opcao == "9");

    }

    
}


