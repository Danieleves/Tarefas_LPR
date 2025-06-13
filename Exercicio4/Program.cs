using System;



namespace lojinhaTerceiraoDS

{

    internal class Program

    {

        static void Main(string[] args)

        //Problema 4 do slide resolvido em C#

        {

            string nome;

            int pr1;         //Correspondente ao produto 1

            pr1 = 160;

            int pr2;         //Correspondente ao produto 2

            pr2 = 90;

            int pr3;         //Correspondente ao produto 3

            pr3 = 120;

            int pr4;         //Correspondente ao produto 4

            pr4 = 115;

            float total = 0f;



            Console.WriteLine("---------------------Lojinha do Terceirao---------------------");

            Console.WriteLine("Qual professor que esta acessando no momento?");

            nome = Console.ReadLine();

            Console.WriteLine($"Seja bem-vindo {nome} a loja do terceirão DS 2025!");

            Console.WriteLine("Aqui temos algumas opcoes de compras especiais esperando por voce!");

            Console.WriteLine();

            Console.WriteLine("1 - Moleton personalizado com seu nome (R$160.00)");

            Console.WriteLine("2 - Camiseta especial do tercecirao DS 2025 (R$90.00)");

            Console.WriteLine("3 - Calca jogger com DS e games escrito nos lados (R$120.00)");

            Console.WriteLine("4 - Chinelo slide roxo e preto com DS e 25 escrito (R$115.00)");

            Console.WriteLine();

            Console.Write("Patrocine nossa formatura comprando algum produto de nossa lojinha! ");

            Console.Write("Digite a quantidade de produtos que voce deseja adicionar ao seu carrinho: ");

            int quantidade = int.Parse(Console.ReadLine());



            for (int i = 0; i < quantidade; i++)          //Funcao loop parando quando "quantidade" chegar a 0 (entre 1 e 4)



            {

                Console.Write($"Digite apenas o numero do {i + 1}º produto: ");        //Forma "i+1" para a funcao comecar no 1 e nao no zero

                int produto = int.Parse(Console.ReadLine());



                switch (produto)                       //Funcao para ler os valores escolhidos no loop acima.

                {



                    case 1:                               //Cada case é um numero a ser lido 

                        total += pr1;                         //A partir do momento que esse numero é reconhecido, seu valor ja definido é somado ao total 

                        break;                                //Usado para quebrar a leitura do case 1, e deixar o outro case seguir "sozinho"



                    case 2:

                        total += pr2;

                        break;



                    case 3:

                        total += pr3;

                        break;



                    case 4:

                        total += pr4;

                        break;



                    default:                              //Caso o numero digitado nao seja reconhecido em nenhum case  

                        Console.WriteLine("Escolha invállida, por favor, escolha um produto que nos temos em nosso estoque!");

                        i--;                                  //Usado para nao fechar o loop e dar outra chance ao usuario de escolher outro numero 

                        break;



                }

            }



            Console.WriteLine("Todas as compras ja foram adicionadas ao seu carrinho!");

            Console.WriteLine($"Devido a suas escolhas, o valor total do seu carrinho sera de R${total:F2}");

            Console.WriteLine("Mande esse valor no pix 35992672613 e o comprovante nesse mesmo numero de celular!");



        }

    }

}
