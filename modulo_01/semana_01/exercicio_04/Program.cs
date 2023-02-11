string[] alunos = new string[5];
float[] medias = new float[5];

for (int i = 0; i < 5; i++)
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