public class ContaCorrente : ContaBancaria
{
    public double TaxaDeManutencao { get; private set; }

    public ContaCorrente(int numeroDaConta, double taxaDeManutencao) : base(numeroDaConta)
    {
        TaxaDeManutencao = taxaDeManutencao;
    }

    public void CobrarTaxa()
    {
        if (Saldo >= TaxaDeManutencao)
        {
            Saldo -= TaxaDeManutencao;
            Console.WriteLine("Taxa de manutenção de R$ " + TaxaDeManutencao + " cobrada.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para cobrar a taxa de manutenção.");
        }
    }

    public override void AplicarAtualizacoes()
    {
        CobrarTaxa();
    }
}