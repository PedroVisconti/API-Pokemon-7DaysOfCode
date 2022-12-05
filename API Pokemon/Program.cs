using API_Pokemon;
using API_Pokemon.Model;
using RestSharp;
using System.Runtime.CompilerServices;

public class program
{
    public static void Main(string[] args)
    {

        List<Pokemon> pokemonAdotado = new List<Pokemon>();
        string opcao;

        do
        {
            Console.WriteLine("Bem vindo ao sistema Pokemon, oque deseja fazer hoje:" +
                "\n 1 - Adotar um Pokemon;" +
                "\n 9 - Sair do Sistema\n");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Pokemon pokemon = new Pokemon();
                    Console.WriteLine("Qual Pokemon deseja adotar:" +
                        "\n Bulbasaur;" +
                        "\n Squirtle" +
                        "\n Charmander\n");

                    string escolhaPokemonUsuario = Console.ReadLine();

                    while (opcao != "3")
                    {
                        Console.WriteLine($"\n1 - Saber mais sobre {escolhaPokemonUsuario}" +
                            $"\n2 - Adotar {escolhaPokemonUsuario}" +
                            $"\n3 - Voltar\n");

                        string opcao2 = Console.ReadLine();

                        switch (opcao2) {

                            case "1":
                                Console.Clear();
                                pokemon = buscarPokemon.BuscarPokemon(escolhaPokemonUsuario);
                                Console.WriteLine($"Informações sobre {escolhaPokemonUsuario}");
                                Console.WriteLine($"Nome do Pokemon: " + pokemon.name);
                                Console.WriteLine("Altura: " + pokemon.height);
                                Console.WriteLine("Peso: " + pokemon.weight);

                                Console.WriteLine("Habilidades: ");
                                foreach (Abilities habilidade in pokemon.abilities)
                                {
                                    Console.Write(habilidade.ability.name.ToUpper() + " ");
                                }
                                Console.WriteLine();
                                break;

                           case "2":
                                pokemon = buscarPokemon.BuscarPokemon(escolhaPokemonUsuario);
                                pokemonAdotado.Add(pokemon);
                                Console.WriteLine("Pokemon adotado com sucesso");
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

                case "9":
                    Console.WriteLine("Obrigado por usar o sistema, até mais");
                    break;
            }

        } while (opcao == "9");

    }

    
}


