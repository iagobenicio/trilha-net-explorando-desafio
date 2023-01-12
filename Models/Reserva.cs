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
            
            //implementado
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //implementado
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            //implementado
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            //implementado
            decimal valor = DiasReservados * Suite.ValorDiaria;

            
            //implementado 
            if (DiasReservados >= 10)
            {

                valor -= valor * 0.10M;
            }

            return valor;
        }
    }
}