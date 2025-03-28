#include <iostream>
#include <locale>

using namespace std;

int main() {

    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    int numero;
    int n2;

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

    return 0;
}
