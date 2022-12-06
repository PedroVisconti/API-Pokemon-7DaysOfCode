using API_Pokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon_View
{
    public class View
    {
        private string name { get; set; }

        public View()
        {
            boasVindas();
        }

        public void boasVindas()
        {
            Console.WriteLine(@"
                   ###
                    ##
 ######    ####     ##  ##   ####    ##  ##    ####    #####     #####
  ##  ##  ##  ##    ## ##   ##  ##   #######  ##  ##   ##  ##   ##
  ##  ##  ##  ##    ####    ######   ## # ##  ##  ##   ##  ##    #####
  #####   ##  ##    ## ##   ##       ##   ##  ##  ##   ##  ##        ##
  ##       ####     ##  ##   #####   ##   ##   ####    ##  ##   ######
 ####
");
            Console.WriteLine("\nBoas vindas ao Sistema Pokemon");
            Console.WriteLine("Qual seu nome?\n");
            this.name = Console.ReadLine().ToUpper();
        }

        public void menuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- MENU ---------------------------\n");
            Console.WriteLine($"{name} oque deseja fazer no sistema ?\n");
            Console.WriteLine("1 - Adotar um Pokemon");
            Console.WriteLine("2 - Consultar Pokemons adotados?");
            Console.WriteLine("9 - Sair do Sistema ?\n");

        }
        public string escolherPokemon()
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- ADOTAR POKEMON ---------------------------\n");
            Console.WriteLine($"Qual Pokemon {name} você deseja adotar hoje ?\n");
            return Console.ReadLine().ToUpper();

        }

        public string saberMais(string nomePokemon)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- SABER MAIS ---------------------------\n");
            Console.WriteLine($"1 - Saber mais sobre {nomePokemon}");
            Console.WriteLine($"2 - Adotar {nomePokemon}");
            Console.WriteLine("3 - Voltar\n");
            return Console.ReadLine();
        }

        public void saberMaisPokemon(Pokemon pokemon)
        {
            Console.Clear();
            Console.WriteLine($"\n--------------------------- SABER MAIS SOBRE {pokemon.name.ToUpper()} ---------------------------\n");
            Console.WriteLine($"Nome do Pokemon: {pokemon.name}");
            Console.WriteLine($"Altura:  {pokemon.height}");
            Console.WriteLine($"Peso: {pokemon.weight}\n");

            Console.WriteLine("Habilidades: \n");
            foreach (Abilities habilidade in pokemon.abilities)
            {
                Console.WriteLine(habilidade.ability.name.ToUpper() + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void adotarPokemon(Pokemon pokemon)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- ADOTAR POKEMON ---------------------------\n");
            Console.WriteLine($"Parabens {name}, voce adotou um {pokemon.name}");
        }

    }

}
