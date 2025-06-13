using System;



namespace salarioFuncionario

{

    internal class Program

    {

        static void Main(string[] args)

        //Problema 3 do slide resolvido em C#

        {



            string nome;     //nome do reponsavel presente 

            int numero;      //numero do funcionario 

            int horas;       //horas trabalhadas

            float salario;   //salario por hora 



            Console.WriteLine("_______________Sistema RH - Salario de funcionarios_______________");
        
Console.Write("Qual dos chefes esta acessando? ");

            nome = Console.ReadLine();



            Console.Write("Indique o numero de identificacao do funcionario: ");

            numero = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Ola {nome}!");

            Console.WriteLine($"Para continuarmos, digite abaixo quantas horas o funcionario {numero} trabalhou este mes: ");

            horas = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Quantos reais esse funcionario ganha por hora? Utilize virgula para valores decimais. ");

            salario = float.Parse(Console.ReadLine());



            float Tsalario = horas * salario;  //salario total = produto entre horas trabalhadas e salario por hora



            Console.WriteLine($"Esse mes o salario do funcionario de numero {numero} sera de R${Tsalario:F2}.");



        }

    }

}