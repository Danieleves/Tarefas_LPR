using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public struct Produto
    {
        public string Nome;
        public int Codigo;
        public double Preco;
        public int Quantidade;
    }
    static void Main()
    {
        Produto[] estoque = new Produto[3];
        double total = 0;

        Console.WriteLine("Programa feito para ler um produto e gerenciar o estoque.");
        Console.WriteLine("---------------------------------------------------------");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Escreva o nome do {i + 1}º produto:");
            estoque[i].Nome = Console.ReadLine()!;
            Console.WriteLine($"Digite o código do {i + 1}º produto:");
            estoque[i].Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Digite o preço do {i + 1}º produto:");
            estoque[i].Preco = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Digite a quantidade em estoque do {i + 1}º produto:");
            estoque[i].Quantidade = int.Parse(Console.ReadLine()!);
        }
        for (int i = 0; i < 3; i++)
        {
            total += estoque[i].Preco * estoque[i].Quantidade;
        }
    }
}