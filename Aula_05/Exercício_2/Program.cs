using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program 
{
    static void Main() {

        int tentativas = 0;
        Random numAleatorio = new Random();
        int valor = numAleatorio.Next(1,100);

        Console.WriteLine("Seja bem-vindo ao Akinator dos Números");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Regras:");
        Console.WriteLine("1. Você terá que advinhar o número gerado de 1 a 100 em menos tentativas possíveis.");
        Console.WriteLine("2. Apenas digite os números nos locais indicados.");
        Console.WriteLine("3. Nada de palavras hein!");
        Console.WriteLine();
        Console.WriteLine("Vamos ao jogo, o Akinator agora é você!");
        
        Console.WriteLine("O número que estou pensando é...");
         int numero = 0;

        do{
        numero = int.Parse(Console.ReadLine());
        tentativas++;

        if (numero == valor){
            Console.WriteLine("Parabéns, você é o novo gênio!");
            Console.WriteLine($"Acertou em {tentativas} vezes!" );
        }
        else {

            int proximidade = Math.Abs(valor - numero);
            if (proximidade <= 20){
                Console.WriteLine("Está quente...");
            }
            if (proximidade <= 10){
                Console.WriteLine("Está beeeem quente...");
            }
            else{
                Console.WriteLine("É o clima ou você que está frio????");
            }
        }
        }
        while(numero != valor);
        }
} 
