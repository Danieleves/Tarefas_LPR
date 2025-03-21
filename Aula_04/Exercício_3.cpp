#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main(){

    string n1 = "Feiticeiro";
    string n2 = "Lobisomem";
    string n3 = "Vampiro";
    string n4 = "ShadowHunter";
    string n5 = "Demônio";

cout << "RPG - Dark Hunter" << endl;
cout << "" << endl;
cout <<"Para começar, temos 5 opções de personagens para escolher: " << endl;
cout <<"1 - Feiticeiro " << endl;
cout <<"2 - Lobisomen " << endl;
cout <<"3 - Vampiro " << endl;
cout <<"4 - ShadowHunter " << endl;
cout <<"5 - Demônio " << endl;

cout << "Escolha seu personagem inicial (apenas o nome dele): " << endl;
string personagem;
cin >> personagem;

if (personagem == n1){
    cout << "O Feiticeiro tem habilidades de magnus bane: Telecinese, Telepatia e Habilidade de controlar o tempo. ";
}
   else if(personagem == n2){
    cout << "O Lobisomem tem habilidades de Lucke Greymark: Visão longa, Força descomunal e Autocura. ";
   }
   else if (personagem == n3){
    cout << "O Vampiro tem habilidades de Simon Lewis: Velocidade, Autocura e Andar a luz do sol. ";
   }
   else if (personagem == n4){
    cout << "O ShadowHunter tem habilidades de Jace Wayland: Agilidade, Habilidade com lâminas e Criação de um poder qualquer extra. ";
   }
   else if (personagem == n5){
    cout << "O Demônio tem habilidades de Cristopher Morgenstein: Aparência de qualquer pessoa, Resistência intensa a feridas e controle do fogo. ";
   }
   else {
    cout << "Acredito que você tenha se esquecido de alguma letra. transcreva da mesma forma que está escrito no catálogo";
       }
}
