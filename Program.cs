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
Suite suite1 = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);
Suite suite2 = new Suite(tipoSuite: "Basic", capacidade: 3, valorDiaria: 10);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 10);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"1° - Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"1° - Valor diária: {reserva1.CalcularValorDiaria()}");

Reserva reserva2 = new Reserva(diasReservados: 5);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"2° - Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"2° - Valor diária: {reserva2.CalcularValorDiaria()}");