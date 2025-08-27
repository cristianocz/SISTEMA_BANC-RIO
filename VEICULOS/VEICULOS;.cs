using System;

namespace CadastroVeiculos
{
    // Classe base
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        // Método virtual para ser sobrescrito
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"{Marca} {Modelo}, {Ano}");
        }
    }

    // Classe derivada Carro
    public class Carro : Veiculo
    {
        public int Portas { get; set; }

        public Carro(string marca, string modelo, int ano, int portas)
            : base(marca, modelo, ano)
        {
            Portas = portas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, {Ano}, {Portas} portas.");
        }
    }

    // Classe derivada Moto
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, int ano, int cilindradas)
            : base(marca, modelo, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo}, {Ano}, {Cilindradas} cc.");
        }
    }

    // Classe principal para testar
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Ford", "Ka", 2020, 4);
            Moto moto = new Moto("Yamaha", "MT-03", 2022, 321);

            carro.ExibirInfo();
            moto.ExibirInfo();
        }
    }
}