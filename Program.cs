namespace projeto_github;

class Program
{
    static void Main()
    {
        var contaPoupanca = new ContaPoupanca(123, 0.5);
        var contaCorrente = new ContaCorrente(456, 12);

        contaPoupanca.Depositar(1000);
        contaCorrente.Depositar(500);

        contaPoupanca.Sacar(100);
        contaCorrente.Sacar(50);

        contaPoupanca.AplicarAtualizacoes();
        contaCorrente.AplicarAtualizacoes();

        Console.WriteLine("Saldo final da poupança: R$ " + contaPoupanca.Saldo);
        Console.WriteLine("Saldo final da corrente: R$ " + contaCorrente.Saldo);
    }
}