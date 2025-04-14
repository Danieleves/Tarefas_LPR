#include <iostream>
#include <locale>

using namespace std;

int numeroinverso(int n) {

int reverso = 0;

while (n != 0) {
    int digitos = n % 10;
    reverso = reverso * 10 + digitos;
    n /= 10;
    }

    return reverso;
}

int main() {

int n;

cout << "Aqui se voce digitar um número inteiro, nós retornaremos exatamente o contrário dele!" << endl;
cout << "Digite um número inteiro: ";
cin >> n;

int resultado = numeroinverso(n);
cout << "O número " << n << " ao contrário é: " << resultado << endl;
    return 0;
}