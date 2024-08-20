namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        //Propriedades
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        //Construtores
        public Reserva() { }

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            int caphos = hospedes.Count();
            int capsuite = Suite.Capacidade;
            Console.WriteLine($"Capacidade hospedes: {caphos}");
            Console.WriteLine($"Capacidade suite: {capsuite}");
            if (Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes
            int totalhospedes = Hospedes.Count();
            return totalhospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            int quantdias = DiasReservados;
            bool desconto = quantdias >= 10;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = valorDiaria * quantdias;
            if (desconto)
            {
                decimal desc = 0.10m;
                valor -= valor * desc; 
            }

            return valor;
        }
    }
}