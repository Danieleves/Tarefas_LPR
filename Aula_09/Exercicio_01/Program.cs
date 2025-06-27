using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Programa feito para treino de listas em programação.");
        Console.WriteLine("Saída 1 deverá ser FALSE.");
        Console.WriteLine("Saída 2 deverá ser 2.");
        Console.WriteLine("Saída 3 deverá ser 1.");
        Console.WriteLine("Saída 4 deverá ser 1,3,7,5.");
        numeros.Add(4);
        numeros.Insert(3, 7);
        bool contem8 = numeros.Contains(8);
        Console.WriteLine(contem8);
        int cont = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] > 4)
            {
                cont += 1;
            }
        }
        Console.WriteLine(cont);
        int cont2 = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] == 3)
            {
                cont2 += 1;
            }
        }
        Console.WriteLine(cont2);
        numeros.Remove(2);
        while (numeros.Contains(4))
        {
            numeros.Remove(4);
        }
        for (int i = 0; i < numeros.Count; i++)
        {
            Console.WriteLine(numeros[i]);
        }        
    }
}
