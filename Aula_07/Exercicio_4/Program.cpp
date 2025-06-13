#include <iostream>
#include <locale>

using namespace std;

int main() {

    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    int matriz1[3][3];
    int matriz2[3][3];
    int soma1 = 0;
    int soma2 = 0;
    int soma3 = 0;
    int soma4 = 0;
    int soma5 = 0;
    int soma6 = 0;
    int soma7 = 0;
    int soma8 = 0;
    int soma9 = 0;

    cout << "Programa feito para ler 2 matrizes e fazer a multiplicação delas" << endl;
    cout << "--------------------------------------------------------------- " << endl;
    cout << "Digite os valores em ordem linear (0,0; 0,1; 0,2): " << endl;

    //matriz1

    for (int k=0; k<3; k++){
        for(int o=0; o<3; o++){
            cout << "Digite o " << o+1 << "º número";
            int i;
            cin >> i;
            matriz1[k][o] = i;
        }
    }

    //matriz2

     for (int k=0; k<3; k++){
        for(int o=0; o<3; o++){
            cout << "Digite o " << o+1 << "º número";
            int i;
            cin >> i;
            matriz2[k][o] = i;
        }
    }

    //multiplicação de matrizes

    for(int i=0; i<3; i++){
    soma1 += matriz1[0][i] * matriz2[i][0];
    }
    for(int i=0; i<3; i++){
    soma2 += matriz1[0][i] * matriz2[i][1];
    }
    for(int i=0; i<3; i++){
    soma3 += matriz1[0][i] * matriz2[i][2];
    }
    for(int i=0; i<3; i++){
    soma4 += matriz1[1][i] * matriz2[i][0];
    }
    for(int i=0; i<3; i++){
    soma5 += matriz1[1][i] * matriz2[i][1];
    }
    for(int i=0; i<3; i++){
    soma6 += matriz1[1][i] * matriz2[i][2];
    }
    for(int i=0; i<3; i++){
    soma7 += matriz1[2][i] * matriz2[i][0];
    }
    for(int i=0; i<3; i++){
    soma8 += matriz1[2][i] * matriz2[i][1];
    }
    for(int i=0; i<3; i++){
    soma9 += matriz1[2][i] * matriz2[i][2];
    }

    //resultado
    int soma[3][3] = { {soma1, soma2, soma3}, {soma4, soma5, soma6}, {soma7, soma8, soma9} };
    cout << "O resultado da multiplicação da matriz 1 pela matriz 2 é " <<"| "<< soma1 <<" "<< soma2 <<" "<< soma3 <<" |"<< endl;
    cout << "---------------------------------------------------------" <<"| "<< soma4 <<" "<< soma5 <<" "<< soma6 <<" |"<< endl;
    cout << "-------------------------------------------------------- " <<"| "<< soma7 <<" "<< soma8 <<" "<< soma9 <<" |"<< endl;
    
    return 0;

}