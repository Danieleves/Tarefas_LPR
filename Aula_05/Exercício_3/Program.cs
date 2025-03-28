using System;

class Program
{
    static void Main() {

    int soma = 0;

    Console.WriteLine("Programa para mostrar a soma total dos números ímpares múltiplos de 3 entre 50 e 500.");
    for (int i = 50; i <= 500; i++) {

        if (i%2 != 0 && i%3 == 0) {

                soma += i;
        }
        }

        Console.WriteLine("A soma é: " + soma);
    }
}
