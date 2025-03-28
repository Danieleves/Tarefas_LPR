using System;
class Program
{

static void Main() {

int Qpares=0;
int soma=0;
Console.WriteLine("Programa feito para identificar números pares e dizer qual a média entre eles");
Console.WriteLine();
Console.WriteLine("Escreva abaixo a quantidade de números que deseja-se tirar a média");
int quantidade = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite a os números um de cada vez: ");

while (quantidade > 0 ){

 int numeros = int.Parse(Console.ReadLine());
  if (numeros != 0){

     if (numeros % 2 == 0){

            soma += numeros;
            Qpares++;
    }
    quantidade--;
    Console.WriteLine("Digite o próximo número: ");
}
}
  if (Qpares > 0){

            double media = (double)soma / Qpares;
            Console.WriteLine($"A média dos números pares será: {media}");
        }
        else{

            Console.WriteLine("Não foi possível calcular a média.");
        }
    }
}