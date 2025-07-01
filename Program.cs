//Console.OutputEncoding = System.Text.Encoding.UTF8;
using Desafio_fundamentos.Models;
using Desafio_fundamentos.Estacionamento;
using System.Diagnostics;

Estacionamento es = new Estacionamento();

bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear(); // Limpa o terminal a cada repetição
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículos");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
    {
        case "1":
            // Quando o usuário digita "1", nós chamamos o método que você acabou de criar!
            es.AdicionarVeiculo();
            break;

        case "2":
            // Implementaremos a lógica de remover em breve
            Console.WriteLine("Você escolheu remover o veículo.");
            break;

        case "3":
            // Implementaremos a lógica de listar em breve
            Console.WriteLine("Você escolheu listar os veículos.");
            break;

        case "4":
            exibirMenu = false; // Isso fará com que o loop 'while' termine
            Console.WriteLine("Encerrando o programa.");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadLine(); // Pausa o programa até o usuário apertar Enter

  }