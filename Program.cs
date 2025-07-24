using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Matheus");
Pessoa p2 = new Pessoa(nome: "Caroline");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Casal", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Reserva emitida!!");
Console.WriteLine("--------------------");
Console.WriteLine($"Suíte: {suite.TipoSuite}\nCapacidade: {suite.Capacidade} pessoas\nValor da diária: {suite.ValorDiaria:C}\n");


// Exibe a quantidade de hóspedes, seus nomes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");

foreach (var hospede in hospedes)
{
    Console.WriteLine($"Nome: {hospede.Nome}");
}

Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria():C}");