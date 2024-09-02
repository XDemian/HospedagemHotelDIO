using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospedagemHotel.Models;
namespace  HospedagemHotel.Models
{
    public class Pessoa
    {
     
        public Pessoa ( string nome, string sobrenome )
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        

        private string Nome { get; set; }
        public string Sobrenome { get; set;}

    }
}