using System;
using System.Numerics;
using System.Reflection;
using System.Text;

class Program {
    static void Main () {

     string nome1 = " ", nome2 = " ", nome3 = " ", nome4 = " ", nome5 = " ";
     string poder1 = " ", poder2 = " ", poder3 = " ", poder4 = " ", poder5 = " ";
     int pontuacao1 = 0, pontuacao2 = 0, pontuacao3 = 0, pontuacao4 = 0, pontuacao5 = 0;
     string equipe1 = " ", equipe2 = " ", equipe3 = " ";
     int total = 0;
     
     Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
     ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}
static void Menu (ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5,
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

int escolha;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Bem vindo ao Hero Fight!");
Console.WriteLine(" ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("============= Menu =============");
Console.ResetColor();
Console.WriteLine("1 - Lista de heróis");
Console.WriteLine("2 - Cadastrar heróis");
Console.WriteLine("3 - Escolher equipe");
Console.WriteLine("4 - Pontuação total da equipe ");
Console.WriteLine("5 - Exibição geral da equipe");
Console.WriteLine("6 - Sair do programa");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("================================");
Console.ResetColor();
Console.WriteLine("Digite o número que deseja para abrir suas respectivas interfaces:");
    escolha = int.Parse(Console.ReadLine()!);

    if (escolha == 1) {
        lista(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}

     else if (escolha == 2){

cadastrarHeroi (ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
     }

     else if (escolha == 3 && nome1 == " " && nome2 == " " && nome3 == " " && nome4 == " " && nome5 == " " ) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você ainda não cadastrou os 5 heróis. Reinicie o programa.");
     }

     else if (escolha == 3 && nome1 != " " && nome2 != " " && nome3 != " " && nome4 != " " && nome5 != " " ) {
        escolhaequipe(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
     }

     else if (escolha == 4) { 
pontuacaototal (ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
     }

     else if (escolha == 5) {
        exibicaogeral(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
     }

     else if (escolha == 6) {
        encerrar(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
     }
}
static void cadastrarHeroi (ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

int espaco;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Aqui você irá cadastrar seu herói");
Console.ResetColor();
Console.WriteLine(" ");

bool continuar = true;

while (continuar == true) {
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Lista de Heróis ===");
Console.ResetColor();
Console.WriteLine("1 - " + nome1);
Console.WriteLine("2 - " + nome2);
Console.WriteLine("3 - " + nome3);
Console.WriteLine("4 - " + nome4);
Console.WriteLine("5 - " + nome5);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("========================");
Console.ResetColor();
Console.WriteLine("Escolha um espaço vazio dentre os 5 disponíveis para cadastrar:");

 espaco = int.Parse(Console.ReadLine()!);

 switch(espaco) {

 case 1:
 if (nome1 != " "){
 Console.WriteLine("Este espaço já está ocupado, escolha outro");
 } else {
 Console.WriteLine("Espaço de cadastro do herói 1:");
 Console.WriteLine(" ");
 Console.WriteLine("Escreva o nome dele:");
 nome1 = Console.ReadLine()!; 
 Console.WriteLine("Escreva qual o poder dele:");
 poder1 = Console.ReadLine()!;
 Console.WriteLine("Digite a pontuação de seu herói, numericamente:");
 pontuacao1 = int.Parse(Console.ReadLine()!); }
 break; 

  case 2:
  if (nome2 != " "){
 Console.WriteLine("Este espaço já está ocupado, escolha outro");
 } else {
 Console.WriteLine("Espaço de cadastro do herói 2:");
 Console.WriteLine(" ");
 Console.WriteLine("Escreva o nome dele:");
 nome2 = Console.ReadLine()!;
 Console.WriteLine("Escreva qual o poder dele:");
 poder2 = Console.ReadLine()!;
 Console.WriteLine("Digite a pontuação de seu herói, numericamente:");
 pontuacao2 = int.Parse(Console.ReadLine()!); }
 break; 

  case 3:
  if (nome3 != " "){
 Console.WriteLine("Este espaço já está ocupado, escolha outro");
 } else {
 Console.WriteLine("Espaço de cadastro do herói 3:");
 Console.WriteLine(" ");
 Console.WriteLine("Escreva o nome dele:");
 nome3 = Console.ReadLine()!;
 Console.WriteLine("Escreva qual o poder dele:");
 poder3 = Console.ReadLine()!;
 Console.WriteLine("Digite a pontuação de seu herói, numericamente:");
 pontuacao3 = int.Parse(Console.ReadLine()!); }
 break; 

  case 4:
  if (nome4 != " "){
 Console.WriteLine("Este espaço já está ocupado, escolha outro");
 } else {
 Console.WriteLine("Espaço de cadastro do herói 4:");
 Console.WriteLine(" ");
 Console.WriteLine("Escreva o nome dele:");
 nome4 = Console.ReadLine()!;
 Console.WriteLine("Escreva qual o poder dele:");
 poder4 = Console.ReadLine()!;
 Console.WriteLine("Digite a pontuação de seu herói, numericamente:");
 pontuacao4 = int.Parse(Console.ReadLine()!); }
 break;

  case 5:
  if (nome5 != " "){
 Console.WriteLine("Este espaço já está ocupado, escolha outro");
 } else {
 Console.WriteLine("Espaço de cadastro do herói 5:");
 Console.WriteLine(" ");
 Console.WriteLine("Escreva o nome dele:");
 nome5 = Console.ReadLine()!;
 Console.WriteLine("Escreva qual o poder dele:");
 poder5 = Console.ReadLine()!;
 Console.WriteLine("Digite a pontuação de seu herói, numericamente:");
 pontuacao5 = int.Parse(Console.ReadLine()!); }
 break;

 default: 
Console.WriteLine("Esse espaco não está disponível, tente algum vazio entre os 5 acima:");
break;
 }

 Console.WriteLine("Deseja cadastrar mais algum personagem? Responda com (Sim) ou (Não) ");
 string escolha = Console.ReadLine()!;
 
 if (escolha != "Sim"){
    continuar = false;
}
}
 Console.WriteLine("Se quiser voltar a cadastrar um personagem, digite (2)");
 Console.WriteLine("Se quiser voltar ao menu, digite (1).");
 int n = int.Parse(Console.ReadLine()!);
 
 if(n == 2) {
    cadastrarHeroi (ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}
else if(n == 1){
    Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}
}

static void escolhaequipe(ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Lista de Heróis ===");
Console.ResetColor();
Console.WriteLine("1 - " + nome1);
Console.WriteLine("2 - " + nome2);
Console.WriteLine("3 - " + nome3);
Console.WriteLine("4 - " + nome4);
Console.WriteLine("5 - " + nome5);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("========================");
Console.ResetColor();
Console.WriteLine(" ");
Console.WriteLine("Entre esses heróis, escolha 3 para compor sua equipe");

bool exibir = true;
while(exibir == true){

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Essa é a sua equipe atual ===");
Console.ResetColor();
Console.WriteLine("1 - " + equipe1);
Console.WriteLine("2 - " + equipe2);
Console.WriteLine("3 - " + equipe3);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===============================");
Console.ResetColor();

Console.WriteLine("Digite abaixo o espaço para adicionar algum heroi à sua equipe:");
int escolha;
escolha = int.Parse(Console.ReadLine()!);

switch(escolha) {

    case 1:
    Console.WriteLine("Escreva o nome exato do herói, da lista, que deseja adicionar a sua equipe:");
    string digitado = Console.ReadLine()!;
    if (digitado == nome1 || digitado == nome2 || digitado == nome3 || digitado == nome4 || digitado == nome5){
        equipe1 = digitado; 
    Console.WriteLine($"O herói escolhido foi {equipe1}"); }
    else { 
       Console.WriteLine($"{digitado} não exixte na lista, escolha um entre os disponíveis.");
    }
    break;

    case 2:
    Console.WriteLine("Escreva o nome exato do herói, da lista, que deseja adicionar a sua equipe:");
    string digitado2 = Console.ReadLine()!;
    if (digitado2 == nome1 || digitado2 == nome2 || digitado2 == nome3 || digitado2 == nome4 || digitado2 == nome5){
        equipe2 = digitado2; 
    Console.WriteLine($"O herói escolhido foi {equipe2}"); }
    else { 
       Console.WriteLine($"{digitado2} não exixte na lista, escolha um entre os disponíveis.");
    }
    break;

    case 3:
    Console.WriteLine("Escreva o nome exato do herói, da lista, que deseja adicionar a sua equipe:");
    string digitado3 = Console.ReadLine()!;
    if (digitado3 == nome1 || digitado3 == nome2 || digitado3 == nome3 || digitado3 == nome4 || digitado3 == nome5){
        equipe3 = digitado3; 
    Console.WriteLine($"O herói escolhido foi {equipe3}"); }
    else { 
       Console.WriteLine($"{digitado3} não existe na lista, escolha um entre os disponíveis.");
    }
    break;
}
Console.WriteLine("Se quiser voltar a escolher sua equipe, digite (2)");
Console.WriteLine("Se quiser voltar ao menu, digite (1).");
int n = int.Parse(Console.ReadLine()!);
 
 if(n == 2) {
    escolhaequipe(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}
else if(n == 1){
     Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5,
    ref equipe1, ref equipe2, ref equipe3, ref total);
}
}
}

static void pontuacaototal(ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

if (equipe1 == nome1 || equipe2 == nome1 || equipe3 == nome1) {
    total += pontuacao1; }
if (equipe1 == nome2 || equipe2 == nome2 || equipe3 == nome2) {
    total += pontuacao2; }
if (equipe1 == nome3 || equipe2 == nome3 || equipe3 == nome3) {
    total += pontuacao3; }
if (equipe1 == nome4 || equipe2 == nome4 || equipe3 == nome4) {
    total += pontuacao4; }
if (equipe1 == nome5 || equipe2 == nome5 || equipe3 == nome5) {
    total += pontuacao5; }
    Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"A pontuação total de sua equipe é de: {total} "  );
Console.ResetColor();
Console.WriteLine("para voltar ao menu, digite (1).");
int n = int.Parse(Console.ReadLine()!);

if(n == 1){
    Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5,
    ref equipe1, ref equipe2, ref equipe3, ref total);
}
}

static void exibicaogeral(ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Panorama geral de sua equipe:");
    Console.ResetColor();
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"O primeiro herói escolhido foi {equipe1}");
    if (equipe1 == nome1) {
    Console.WriteLine($"Seu poder é: {poder1}, com {pontuacao1} pontos de força."); }
    if (equipe1 == nome2) {
    Console.WriteLine($"Seu poder é: {poder2}, com {pontuacao2} pontos de força."); }
    if (equipe1 == nome3) {
    Console.WriteLine($"Seu poder é: {poder3}, com {pontuacao3} pontos de força."); }
    if (equipe1 == nome4) {
    Console.WriteLine($"Seu poder é: {poder4}, com {pontuacao4} pontos de força."); }
    if (equipe1 == nome5) {
    Console.WriteLine($"Seu poder é: {poder5}, com {pontuacao5} pontos de força."); }
    Console.WriteLine("");
    Console.WriteLine($"O segundo herói escolhido foi {equipe2}");
    if (equipe2 == nome1) {
    Console.WriteLine($"Seu poder é: {poder1}, com {pontuacao1} pontos de força."); }
    if (equipe2 == nome2) {
    Console.WriteLine($"Seu poder é: {poder2}, com {pontuacao2} pontos de força."); }
    if (equipe2 == nome3) {
    Console.WriteLine($"Seu poder é: {poder3}, com {pontuacao3} pontos de força."); }
    if (equipe2 == nome4) {
    Console.WriteLine($"Seu poder é: {poder4}, com {pontuacao4} pontos de força."); }
    if (equipe2 == nome5) {
    Console.WriteLine($"Seu poder é: {poder5}, com {pontuacao5} pontos de força."); }
    Console.WriteLine("");
    Console.WriteLine($"O terceiro herói escolhido foi {equipe3}");
    if (equipe3 == nome1) {
    Console.WriteLine($"Seu poder é: {poder1}, com {pontuacao1} pontos de força."); }
    if (equipe3 == nome2) {
    Console.WriteLine($"Seu poder é: {poder2}, com {pontuacao2} pontos de força."); }
    if (equipe3 == nome3) {
    Console.WriteLine($"Seu poder é: {poder3}, com {pontuacao3} pontos de força."); }
    if (equipe3 == nome4) {
    Console.WriteLine($"Seu poder é: {poder4}, com {pontuacao4} pontos de força."); }
    if (equipe3 == nome5) {
    Console.WriteLine($"Seu poder é: {poder5}, com {pontuacao5} pontos de força."); }
    Console.WriteLine(" ");
    Console.WriteLine($"Por fim, a pontuação total de seu time é de {total} pontos");   
    Console.WriteLine(" ");
    Console.ResetColor();
    Console.WriteLine("Se quiser voltar ao menu, digite (1).");
    int n = int.Parse(Console.ReadLine()!);

if(n == 1){
    Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5,
    ref equipe1, ref equipe2, ref equipe3, ref total);
}
}
static void lista(ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Lista de Heróis ===");
Console.ResetColor();
Console.WriteLine("1 - " + nome1);
Console.WriteLine("2 - " + nome2);
Console.WriteLine("3 - " + nome3);
Console.WriteLine("4 - " + nome4);
Console.WriteLine("5 - " + nome5);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("========================");
Console.ResetColor();
Console.WriteLine("Se quiser voltar ao menu, digite (1).");
Console.WriteLine("Se quiser ir direto, digite 2 para cadastrar algum herói");
    int n = int.Parse(Console.ReadLine()!);

if(n == 1){
    Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5,
    ref equipe1, ref equipe2, ref equipe3, ref total); }

    else if (n == 2) {
        cadastrarHeroi(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
    ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
    }
}
static void encerrar(ref string nome1, ref string poder1, ref string nome2, ref string poder2, 
ref string nome3, ref string poder3, ref string nome4, ref string poder4, ref string nome5, 
ref string poder5, ref int pontuacao1, ref int pontuacao2, ref int pontuacao3, ref int pontuacao4, ref int pontuacao5, 
ref string equipe1, ref string equipe2, ref string equipe3, ref int total) {

Console.WriteLine("Se deseja que o programa feche, digite 0");
Console.WriteLine("Se deseja voltar ao menu, digite 1");

     int n = int.Parse(Console.ReadLine()!);
     if (n == 0) {

        return;
     }
    else 
    Menu(ref nome1, ref poder1, ref nome2, ref poder2, ref nome3, ref poder3, ref nome4, ref poder4, ref nome5, ref poder5,
     ref pontuacao1, ref pontuacao2, ref pontuacao3, ref pontuacao4, ref pontuacao5, ref equipe1, ref equipe2, ref equipe3, ref total);
}
}