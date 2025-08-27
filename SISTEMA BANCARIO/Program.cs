// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SISTEMA_BANCARIO
{   
class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("12345", "Maria");
            conta.Depositar(1000);
            conta.Sacar(500);
            conta.ExibirSaldo();
        }
    }
}
