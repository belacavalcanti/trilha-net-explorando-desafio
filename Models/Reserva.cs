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
        if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        // Retorna a quantidade de hóspedes (propriedade Hospedes)
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        // Calcula o valor da diária: DiasReservados X ValorDiaria da suíte
        decimal valor = DiasReservados * Suite.ValorDiaria;

        // Se a reserva for de 10 dias ou mais, aplica um desconto de 10%
        if (DiasReservados >= 10)
        {
            valor *= 0.9m; // Multiplica por 0.9 para aplicar o desconto de 10%
        }

        return valor;
    }
}

}