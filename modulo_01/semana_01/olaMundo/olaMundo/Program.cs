// See https://aka.ms/new-console-template for more information
// Comentário
Console.WriteLine("Olá, mundo!"); // Saída de dados, impressão em tela.

int numeroInteiro = 10; // Declaração de variável inteira, recebendo valor 10
long numeroMaior = 1099999L; // Declaração de variável long, recebendo valor 1099999
float numeroQuebrado = 6.8f; // Declaração de variável do tipo float
double numeroQuebradoMaior = 101.99999999D; // Declaração de variável do tipo double
char letra = 'z'; // Declaração de variável do tipo char (1 caracter)
string texto = "A turma Estreito é a melhor."; // Declaração de variável do tipo string, recebendo uma frase
bool variavelBooleana = true; // Declaração de variável do tipo boolean, recebendo valor verdadeiro
DateTime data = DateTime.Now; // Declaração de variável do tipo DateTime (data até segundos), armazenando os segundos atuais
DateTime outraData = new DateTime(2023,01,31); // Instanciando objeto da classe DateTime, passando parâmetros como mês e dia
texto.ToUpper(); // Convertendo o texto para letras maiúsculas
Console.WriteLine("Frase com letras maiúsculas: " + texto.ToUpper());

string nomeCompleto; // Declaração de variável
Console.WriteLine("Digite o seu nome: "); // Instrução ao usuário, impressão em tela
nomeCompleto = Console.ReadLine(); // Aguardando o usuário digitar no terminal
Console.WriteLine("O seu nome é: " + nomeCompleto); // Saída de dados, concatenando texto com valor da variável