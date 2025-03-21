using System;

class Program
{
    static void Main(){

        int n1;
        int n2;

        Console.WriteLine("Programa para ler dois números e dizer se são múltiplos entre si.");
        Console.WriteLine(); 
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1%n2 == 0 || n2%n1 == 0){

            Console.WriteLine("Os números são múltiplos entre si!");
        }
        else{

            Console.WriteLine("Os números não são múltiplos entre si!"); 
        }
}
}
