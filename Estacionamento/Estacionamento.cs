using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Desafio_fundamentos.

using Desafio_fundamentos.Models;

namespace Desafio_fundamentos.Estacionamento
{
    public class Estacionamento
    {
        public List<Veiculo> VeiculosEstacionados { get; set; }
        public decimal PrecoAteUmaHora { get; set; }
        public decimal PrecoAteDuasHoras { get; set; }
        public decimal PrecoAcimaDuasHoras { get; set; }

        public decimal PrecoDiario24 { get; set; }

        public Estacionamento()
        {
            VeiculosEstacionados = new List<Veiculo>();

            PrecoAteUmaHora = 10.00M;
            PrecoAteDuasHoras = 25.00M;
            PrecoAcimaDuasHoras = 50.00M;
            PrecoDiario24 = 150.00M;
        }

        public void AdicionarVeiculo()
        {
            // Digita o a placa do veiculo
            Console.WriteLine("Digite a placa do Veiculo para estacionar:");
            string placa = Console.ReadLine();

            // digita o nome do cliente
            Console.WriteLine("Digite o nome do cliente:");
            string nomeCliente = Console.ReadLine();


            // criar o objeto veiculo
            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa,
                NomeCliente = nomeCliente,
                HoraEntrada = DateTime.Now
            };

            // adicionar veiculo à nossa lista de veículo estacionamentos
            VeiculosEstacionados.Add(novoVeiculo);

            Console.WriteLine($"Veículo {placa} de {nomeCliente} estacionado  com sucesso!");


        }
    }
}