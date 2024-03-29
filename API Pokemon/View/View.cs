﻿using API_Pokemon.Model;
using API_Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon.View
{
    public class pokemonView
    {
        private string name { get; set; }

        public pokemonView()
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
            name = Console.ReadLine().ToUpper();
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
        public void adotarPokemon(Mascotes mascotes)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- ADOTAR POKEMON ---------------------------\n");
            Console.WriteLine($"Parabens {name}, voce adotou um {mascotes.name.ToUpper()}");
            Console.ReadLine();
        }

        public void detalhePokemonAdotado(Mascotes mascotes)
        {
            Console.Clear();
            Console.WriteLine($"\n--------------------------- DETALHES {mascotes.name} ---------------------------\n");
            Console.WriteLine("name Pokemon: " + mascotes.name.ToUpper());
            Console.WriteLine("Altura: " + mascotes.height);
            Console.WriteLine("Peso: " + mascotes.weight);

            System.TimeSpan idade = DateTime.Now.Subtract(mascotes.dataNascimento);

            Console.WriteLine("\nIdade: " + idade.Minutes + " Anos em Pokemon Virtual");

            if (mascotes.verificarFome())
            {
                Console.WriteLine($"{mascotes.name.ToUpper()} Está com fome!");
            }
            else
            {
                Console.WriteLine($"{mascotes.name.ToUpper()} Está alimentado!");
            }

            if (mascotes.verificarHumor())
            {
                Console.WriteLine($"{mascotes.name.ToUpper()} Está feliz!");
            }
            else
            {
                Console.WriteLine($"{mascotes.name.ToUpper()} Está triste!");
            }

            Console.WriteLine("Habilidades: ");

            foreach (Abilities habilidade in mascotes.abilities)
            {
                Console.Write(habilidade.ability.name.ToUpper() + " ");
            }
            Console.ReadLine();

        }
        public int menuConsultarMascotes(List<Mascotes> pokemons)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- CONSULTAR POKEMON ---------------------------\n");
            Console.WriteLine($"Você possui {pokemons.Count} Pokemon adotados.");
            for (int indicePokemon = 0; indicePokemon < pokemons.Count; indicePokemon++)
            {
                Console.WriteLine($"{indicePokemon} - {pokemons[indicePokemon].name.ToUpper()}");
            }

            Console.WriteLine($"Qual Pokemon você deseja interagir?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string interagirComMascotes(Mascotes mascotes)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- INTERAGIR COM POKEMON ---------------------------\n");
            Console.WriteLine($"{name} VOCÊ DESEJA:");
            Console.WriteLine($"1 - SABER COMO {mascotes.name.ToUpper()} ESTÁ");
            Console.WriteLine($"2 - ALIMENTAR O {mascotes.name.ToUpper()}");
            Console.WriteLine($"3 - BRINCAR COM {mascotes.name.ToUpper()} ");
            Console.WriteLine($"4 - VOLTAR");

            return Console.ReadLine().ToUpper();
        }

        public void alimentarMascote()
        {
            Console.Clear();
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($" (=^w^=)");
            Console.WriteLine($"Pokemon Alimentado");
            Console.ReadLine();
        }

        public void brincarMascote()
        {
            Console.Clear();
            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine($"(=^w^=)");
            Console.WriteLine($"Mascote mais feliz");
            Console.ReadLine();
        }

        public void gameOver(Mascotes mascotes)
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------- GAME OVER ---------------------------\n");
            Console.WriteLine("O Mascote morreu de " + (mascotes.humor > 0 ? "fome" : "tristeza"));

            Console.WriteLine(@"
              #####      #     #     #  #######      #######  #     #  #######  ######  
             #     #    # #    ##   ##  #            #     #  #     #  #        #     # 
             #         #   #   # # # #  #            #     #  #     #  #        #     # 
             #  ####  #     #  #  #  #  #####        #     #  #     #  #####    ######  
             #     #  #######  #     #  #            #     #   #   #   #        #   #   
             #     #  #     #  #     #  #            #     #    # #    #        #    #  
              #####   #     #  #     #  #######      #######     #     #######  #     # ");
            Console.ReadLine();
        }

    }

}
