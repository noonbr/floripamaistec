using Construtores;

Pessoa pessoa1 = new Pessoa("Raimundão", 17);
Console.WriteLine($"O nome da Pessoa1 é: {pessoa1.nome}.");

Pessoa pessoa2 = new Pessoa("Vintorino", 44, 1.83f);
Console.WriteLine($"O nome da Pessoa2 é: {pessoa2.nome}, {pessoa2.idade}, {pessoa2.altura}");