using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Exibir informações da reserva");
            Console.WriteLine("2. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    // Exibe a quantidade de hóspedes e o valor da diária
                    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
                    break;
                case "2":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
        }

