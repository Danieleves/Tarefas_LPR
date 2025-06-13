#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    //Problema 2 do slide resolvido em c++
    int num1;
    int num2;
    int num3;
    int num4;

    cout << "Qual o primeiro numero? " << endl;
    cin >> num1;

    cout << "Qual o segundo numero? " << endl;
    cin >> num2;

    cout << "Qual o terceiro numero? " << endl;
    cin >> num3;

    cout << "Qual o quarto numero? " << endl;
    cin >> num4;

    int resultado = (num1 * num2) - (num3 * num4);    //Diferenca do produto entre A e B e C e D

    cout << "O resultado da diferenca entre o produto do primeiro pelo segundo numero e o produto do terceiro pelo quarto numero, e igual a: " << resultado << endl;

    return 0;
}
