using System;
class Program
{
    static void Main()
    {
   int[,] posicoes={ {  0, 524, 521, 882 },  {524,   0, 434, 586 }, {521, 434,   0, 429 },  {882, 586, 429,   0 }};
        // b = belo horizonte
        // v = vitoria
        // r = rio de janeiro
        // s = sao paulo
        bool continuar = true;
        while (continuar == true)
        {
            Console.WriteLine("Programa feito para ler cidades remetentes e destinos e dizer a distância entre elas.");
            Console.WriteLine("Escreva o número da cidade remetente (VT = 0, BH = 1, RJ = 2, SP = 3): ");
            int i = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Escreva a cidade destino (VT = 0, BH = 1, RJ = 2, SP = 3): ");
            int j = int.Parse(Console.ReadLine()!);
            int distancia = posicoes[i, j];
            if (i == j)
            {
                continuar = false;
            }
            Console.WriteLine($"A distância entre {i} e {j} é de {distancia}km");
        }
       }                   
    }