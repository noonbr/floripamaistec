/*
int[] numeros = new int[10];

for (int i = 0; i < numeros.Count(); i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    int contador = 1;
    for (int j = 1; j < numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }

    if (contador <= 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um número primo, e está na posição {i}.");
    }
}
*/

// Organizador de frutas

/*
 List<string> frutas = new List<string>();
bool continuar = true;

while (continuar)
{ 
    if (frutas.Count() == 15)
    {
        continuar = false;
        break;
    }

    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.Write("Você deseja continuar? ");
    string resposta = Console.ReadLine();

    if (resposta == "nao" || resposta == "n")
    {
        continuar = false;
    }
}

frutas.Sort();

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
*/

// Separador de números ímpares e pares
/*
List<int> numeros = new List<int>();
bool continuar = true;

while (continuar)
{
    if (numeros.Count() >= 10)
    {
        continuar = false;
        break;
    }

    Console.Write($"Digite o {numeros.Count() + 1}º número: ");
    numeros.Add(int.Parse(Console.ReadLine()));
}

List<int> pares = new List<int>();
int somaPares = 0;

List<int> impares = new List<int>();
int somaImpares = 0;

for (int i = 0; i < numeros.Count(); i++)
{
    int numeroAtual = numeros[i];
    if (numeroAtual % 2 == 0)
    {
        pares.Add(numeroAtual);
        somaPares += numeroAtual;
    }
    else
    {
        impares.Add(numeroAtual);
        somaImpares += numeroAtual;
    }
}

Console.WriteLine($"A lista de números ímpares possui {impares.Count()} e a soma deles é igual a {somaImpares}.");
Console.WriteLine($"A lista de números pares possui {pares.Count()} e a soma deles é igual a {somaPares}.");
*/

// Médias
/*
string[] alunos = new string[5];
float[] medias = new float[5];

for (int i = 0; i < 5;  i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    alunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno: ");
    medias[i] = Math.Min(float.Parse(Console.ReadLine()), 10);
}

Console.WriteLine("\n\nNome\t\tSituação");
for (int i = 0; i < alunos.Length; i++)
{
    string situacao = medias[i] >= 6 ? "Aprovado" : "Reprovado";
    Console.WriteLine($"{alunos[i]} ({medias[i]}) \t\t{situacao}");
}
*/

// Fibonacci

/*

int n;
int x = 1, y = 0, z = 0;
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // z = 0, x = 1, y = 0
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
*/