using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int cont1 = 0, cont2 = 0;

        Console.WriteLine("Programa feito para ler 10 números e separá-los em pares e ímpares");
        Console.WriteLine("------------------------------------------------------------------");

        //salva números

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        //separa em pares e ímpares

        int[] pares = new int[10];
        int[] impares = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares[cont1] = numeros[i];
                cont1++;
            }

            else
            {
                impares[cont2] = numeros[i];
                cont2++;
            }
        }

            Console.WriteLine("Os números pares são: ");
            for (int u = 0; u < pares.Length; u++)
                if (pares[u] != 0)
                {
                    Console.WriteLine(pares[u]);
                }
                else{}

            Console.WriteLine("Os números ímpares são: ");
            for (int j = 0; j < impares.Length; j++)
                if (impares[j] != 0)
                {
                    Console.WriteLine(impares[j]);
                }
                else{}
        
    }
}