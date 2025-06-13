#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    //Problema 1 do slide resolvido em c++
    float raio;
    double pi = 3.14159;

    cout << "Sistema usado para calcular a area do circulo de maneira pratica, precisando apenas de seu raio" << endl;
    cout << "--------------------------------------------------------" << endl;
    cout << "--------------------------------------------------------" << endl;
    cout << "Qual o valor do raio desse circulo: " << endl;
    cin >> raio;

    double area = pi * raio * raio;             //Formula da area do circulo: PI * Raio^2

    cout << "A area desse circulo e igual a: " << fixed << setprecision(4) << area << endl;          //Configurado para mostrar 4 casas decimais na saída

    return 0;
}