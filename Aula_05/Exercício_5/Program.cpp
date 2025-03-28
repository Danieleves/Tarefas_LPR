#include <iostream>
#include <locale>

using namespace std;

int main() {

    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    int horas; 
    int horastotal;
    int semana = 5;
    int dias = 0;
    int semanas = 0;
    int meses = 0;
    int meta = 1000;
    int horastreino = 0;
    float mes = 4.5;



    cout << "Bem-vindo ao treinamento JEDI" << endl;
    cout << " " << endl;
    cout << "indique quantas horas de treino você faz por dia: " << endl;
    cin >> horas;

    horastotal = horas * semana;

    while (horastreino < meta) {

        horastreino += horastotal;
        semanas++;
        }

        dias = semanas * semana;
        meses = semanas / mes;

         cout << "Sua meta é " << meta << " horas. Para isso, é necessário: " << endl;
         cout << dias << " dias; " << endl;
         cout << semanas << " semanas;" << endl;
         cout << meses << " meses. " << endl;

    return 0;
}
