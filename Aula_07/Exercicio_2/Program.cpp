#include <iostream>
#include <locale>
#include <vector>

using namespace std;

vector <int> numeros(10);
int ocorrencias = 0;
int i;

void leitura() {
 
    for (int i = 0; i < numeros.size(); i++){
    cout << "Digite o " << i + 1 << " número: ";
    cin >> numeros[i];
    }
}

void pesquisa() {

    int n;
    cout << "Digite o número que deseja pesquisar" << endl;
    cin >> n;

    if(n != numeros[0] && n != numeros[1] && n != numeros[2] && n != numeros[3] && n != numeros[4] && n != numeros[5] && n != numeros[6] && n != numeros[7] && n != numeros[8] && n != numeros[9])
            cout << "Esse número não existe no vetor"; 
    
    else {
    for (int i = 0; i<numeros.size(); i++) {
        if (n == numeros[i]) {
            cout << "O número " << n << " está na posição " << i << " do vetor." << endl;
            ocorrencias ++;
            }
        }
        cout << "Esse número aparece " << ocorrencias << " vezes";   
    }
}

int main() {

    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    cout << "Programa feito para ler 10 números e permitir ao usuário pesquisá-los" << endl;
    cout << " " << endl;
    leitura();
    pesquisa();

    return 0;

}