// See https://aka.ms/new-console-template for more information


using HospedagemHotel.Models;


        // Criar instâncias de Pessoa
        Pessoa pessoa1 = new Pessoa("Maria", "Oliveira");
        Pessoa pessoa2 = new Pessoa("Carlos", "Almeida");
        List<Pessoa> listaHospedes = new List<Pessoa> { pessoa1, pessoa2 };

        // Criar uma instância de Suite
        Suite suite = new Suite("Luxo", 20, 200M);

        // Criar uma instância de Reserva
        Reserva reserva = new Reserva
        {
            DiasReserva = 20 // Exemplo de 12 dias de reserva
        };

        // Cadastrar hóspedes e suíte na reserva
        reserva.CadastrarHospedes(listaHospedes);
        reserva.CadastrarSuite(suite);

        // Exibir informações
        Console.WriteLine("Quantidade de Hóspedes: " + reserva.ObterQuantidadeHospedes());
        Console.WriteLine("Valor Total da Diária: R$ " + reserva.CalcularValorDiaria());
 
