using API_Pokemon;
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
                "\n 9 - Sair do Sistema");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Pokemon pokemon = new();
                    Console.WriteLine("Qual Pokemon deseja adotar:" +
                        "\n Bulbasaur;" +
                        "\n Squirtle" +
                        "\n Charmander\n");

                    string escolhaPokemonUsuario = Console.ReadLine();

                    while (opcao != "3")
                    {
                        Console.WriteLine($"1 - Saber mais sobre {escolhaPokemonUsuario}" +
                            $"\n2 - Adotar {escolhaPokemonUsuario}" +
                            $"\n3 - Voltar\n");

                        string opcao2 = Console.ReadLine();

                        switch (opcao2) {

                            case "1":
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


