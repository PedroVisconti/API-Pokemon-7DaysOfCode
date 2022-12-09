using API_Pokemon.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon.Models
{
    public class MascoteMapping
    {

        public MascoteMapping()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Pokemon, Mascotes>());

        }
    }
    
}
