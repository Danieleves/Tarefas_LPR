#include <iostream>
#include <locale>

using namespace std;

void exercicio1() {

    int Qpares = 0;
    int soma = 0;

    cout << "Bem-vindo ao Algoritmo 1!" << endl;
    cout << "Programa feito para identificar números pares e calcular a média entre eles" << endl;
    cout << endl;
    cout << "Escreva abaixo a quantidade de números que deseja-se tirar a média" << endl;

    int quantidade;
    cin >> quantidade;

    cout << "Agora digite os números um de cada vez: " << endl;

    while (quantidade > 0) {
        int numeros;
        cin >> numeros;

        if (numeros != 0) {
            if (numeros % 2 == 0) {
                soma += numeros;
                Qpares++;
            }
            cout << "Digite o proximo número: " << endl;
        }
        quantidade--;
    }

    if (Qpares > 0) {
        double media = (double)soma / Qpares;
        cout << "A média dos números pares será: " << media << endl;
    } else {
        cout << "Não foi possível calcular a média." << endl;
    }
}

void exercicio3() {

    int soma = 0;

    cout << "Bem-vindo ao Algoritmo 3!" << endl;
    cout << "Programa para mostrar a soma total dos números ímpares múltiplos de 3 entre 50 e 500." << endl;
    
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma é: " << soma << endl;
}

void exercicio4() {

    int numero;
    int n2;

    cout << "Bem-vindo ao Algoritmo 4!" << endl;
    cout << "Programa para ler um número e somar os dígitos de seu quadrado." << endl;
    cout << " " << endl;
    cout << "Digite um número: ";
    cin >> numero;

    n2 = numero * numero;
    int soma = 0;

    while (n2 > 0) {

    int digitos = n2%10;
    soma += digitos;
    n2 /= 10;

    }

    cout << "A soma de todos os dígitos do quadrado do número " << numero << " é igual a: " << soma << endl;
}

int main() {

    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

int numeros;

cout << "Digite 1, 3 ou 4 para o exercício que se deseja entrar: " << endl;
cout << "Quando quiser sair, digite 0" << endl;
cout << " " << endl;
cin >> numeros;

switch(numeros) {

case 1:
    exercicio1();
    break;

case 3:
    exercicio3();
    break;

case 4:
    exercicio4();
    break;

case 0:
    cout << "Até logo!" << endl;
    return 0;
    
default: 
    cout << "Digite apenas os números 1, 3, 4 ou 0" << endl;
    cout << "Tente novamente" << endl;
    break;
}
}