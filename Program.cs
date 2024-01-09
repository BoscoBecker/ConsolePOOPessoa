using Classe.Pessoa;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Dados da primeira pessoa. - Informe um nome:");
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Informe a sua idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da Segunda pessoa. - Informe um nome:");
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Informe a sua idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());

if (pessoa1.Idade > pessoa2.Idade)
  Console.WriteLine(pessoa1.Nome + " É a pessoa mais velha " + string.Concat(pessoa1.Idade) + " Anos");
else
  Console.WriteLine(pessoa2.Nome + " É a pessoa mais velha " + string.Concat(pessoa2.Idade) + " Anos");

