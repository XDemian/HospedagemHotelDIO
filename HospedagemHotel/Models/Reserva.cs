using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospedagemHotel.Models;



namespace HospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite{ get; set; }
        public int DiasReserva { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }


        public decimal CalcularValorDiaria()
    {
        if (Suite == null)
        {
            throw new InvalidOperationException("A suíte deve ser cadastrada antes de calcular o valor da diária.");
        }

        decimal valorTotal = Suite.ValorDiaria * DiasReserva;

       
        if (DiasReserva > 10)  // Aplicar desconto de 10% se a reserva for para mais de 10 dias
        {   
            valorTotal *= 0.90m; // Aplicar 10% de desconto
        }

        return valorTotal;
    }




        
    }
}
