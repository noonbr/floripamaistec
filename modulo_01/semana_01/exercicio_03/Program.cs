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