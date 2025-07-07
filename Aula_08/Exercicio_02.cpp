#include <iostream>
#include <locale>
#include <vector>

using namespace std; 

struct Livro {
    string Titulo;
    string Autor;
    int Anopublic;
    int Npag;
    float Preco;
};

float CalculoPreco(vector<Livros>){
    float total = 0.0f;
   for (int i = 0; i <Livro.size() ; i++) {
        total += Livro[i].Preco;
    }
    return total;
}

int main() {
    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    /*Defina uma struct Livro com os seguintes
campos: Titulo, Autor, AnoPublicacao,
NumeroPaginas e Preco. Crie um
programa que permita ao usuário inserir
dados de 3 livros e, em seguida, calcule e
exiba o preço total dos livros cadastrados
e a média de páginas dos livros.
*/
int quantidade;
cout << "Programa feito para ler informações de alguns livros e exibir o preço e a média de paginas total." << endl;
cout << "-------------------------------------------------------------------------------------------------" << endl;
cout << "Quantos livros deseja cadastrar?" << endl;
cin >> quantidade;
for (int i=0; i!=quantidade; i++){
    Livro ai;
    cout << "Digite o título do " << i+1 << "º livro:";
    cin >> ai.Titulo;
    cout << "Digite o autor do " << i+1 << "º livro:";
    cin >> ai.Autor;
    cout << "Digite o anode publicação do " << i+1 << "º livro:";
    cin >> ai.Anopublic;
    cout << "Digite a quantidade de páginas do " << i+1 << "º livro:";
    cin >> ai.Npag;
    cout << "Digite o preço do " << i+1 << "º livro:";
    cin >> ai.Preco;
}
CalculoPreco(vector<Livros>);
 

}