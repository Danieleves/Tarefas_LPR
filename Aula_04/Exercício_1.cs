using System;

class Program
{
    static void Main(){

        int numero;

        Console.WriteLine("Programa para ler números inteiros e dizer se eles são pares ou ímpares!");
        Console.WriteLine();
        Console.Write("Digite o número: ");
        
        numero = int.Parse(Console.ReadLine());

        if (numero%2 == 0){

            Console.WriteLine("O número digitado é par!");
        }
        else{

            Console.WriteLine("O número é ímpar!");
        }
}
}
