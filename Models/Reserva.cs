namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Verifica se a capacidade é maior ou igual ao número de hóspedes
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                //Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A suíte não comporta a quantidade de hóspedes informada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Retorna a quantidade de hóspedes
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            //Retorna o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}