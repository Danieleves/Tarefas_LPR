#include <iostream>
#include <locale>

using namespace std; 

struct Livros {
    string Titulo;
    string Autor;
    int Anopublic;
    int Npag;
    float Preco;
};

float CalculoPreco(Livros estoque[], int quantidade){
    float total1 = 0.0f;
   for (int i = 0; i < quantidade; i++) {
        total1 += estoque[i].Preco;
    }
    return total1;
}

double MediaPags(Livros estoque[], int quantidade){
    int total2 = 0;
    for(int i = 0; i<quantidade; i++){
        total2 += estoque[i].Npag;
    }
    double media = (total2)/quantidade;
    return media;

}

int main() {
    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());

    int quantidade;
cout << "Programa feito para ler informações de alguns livros e exibir o preço e a média de paginas total." << endl;
cout << "-------------------------------------------------------------------------------------------------" << endl;
cout << "Quantos livros deseja cadastrar?" << endl;
cin >> quantidade;
Livros* estoque = new Livros[quantidade];
for (int i=0; i!=quantidade; i++){
    cout << "Digite o título do " << i+1 << "º livro:";
    cin >> estoque[i].Titulo;
    cout << "Digite o autor do " << i+1 << "º livro:";
    cin >> estoque[i].Autor;
    cout << "Digite o anode publicação do " << i+1 << "º livro:";
    cin >> estoque[i].Anopublic;
    cout << "Digite a quantidade de páginas do " << i+1 << "º livro:";
    cin >> estoque[i].Npag;
    cout << "Digite o preço do " << i+1 << "º livro:";
    cin >> estoque[i].Preco;
}
float total1 = CalculoPreco(estoque, quantidade);
double media = MediaPags(estoque, quantidade);
cout << "O preço total dos livros cadastrados é: R$" << total1 << endl;
cout << "A média de páginas total dos livros é de: " << media << endl;

 delete[] estoque;

}