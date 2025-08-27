// See https://aka.ms/new-console-template for more information
public class ContaBancaria
{
    private string numeroConta;
    private string titular;
    private decimal saldo;

    public ContaBancaria(string numeroConta, string titular)
    {
        this.numeroConta = numeroConta;
        this.titular = titular;
        this.saldo = 0;
        Console.WriteLine($"CONTA DE :  {titular}.");
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"DEPOSITO DE R$ {valor}.");
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"VALOR SACADO R$ {valor}.");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente para saque de R$ {valor}.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"SALDO: R$ {saldo}.");
    }
}