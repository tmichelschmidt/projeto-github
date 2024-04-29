using System; 
public abstract class ContaBancaria
{
    public int NumeroDaConta { get; private set; }
    public double Saldo { get; protected set; }

    public ContaBancaria(int numeroDaConta)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = 0;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine("Depósito de R$ " + valor + " realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo && valor > 0)
        {
            Saldo -= valor;
            Console.WriteLine("Saque de R$ " + valor + " realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saque inválido.");
        }
    }

    public abstract void AplicarAtualizacoes();
}
