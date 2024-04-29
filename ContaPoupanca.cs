public class ContaPoupanca : ContaBancaria
{
    public double TaxaDeJuros { get; private set; }

    public ContaPoupanca(int numeroDaConta, double taxaDeJuros) : base(numeroDaConta)
    {
        TaxaDeJuros = taxaDeJuros;
    }

    public void AdicionarJuros()
    {
        var juros = Saldo * TaxaDeJuros / 100;
        Saldo += juros;
        Console.WriteLine("Juros de R$ " + juros + " adicionados.");
    }

    public override void AplicarAtualizacoes()
    {
        AdicionarJuros();
    }
}