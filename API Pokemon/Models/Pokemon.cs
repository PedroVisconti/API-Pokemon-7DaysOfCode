using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon.Model
{
    public class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string name { get; set; }
        public int alimentacao { get; set; }
        public int humor { get; set; }
        public DateTime dataNascimento { get; set; }


        public Pokemon()
        {
            Random valorRandomico = new();
            this.alimentacao = valorRandomico.Next(2, 10);
            this.humor = valorRandomico.Next(2, 10);
            this.dataNascimento = DateTime.Now;
        }

        public bool verificarFome()
        {
            return this.alimentacao < 5;
        }

        public void alimentarPokemon()
        {
            this.alimentacao ++;
        }

        public bool verificarHumor()
        {
            return this.humor < 5;
        }

        public void brincarPokemon()
        {
            this.alimentacao--;
            this.humor++;
        }

        public bool saudePokemon()
        {
            return (this.alimentacao > 0 && this.humor > 0);
        }


    }



}
