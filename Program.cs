// See https://aka.ms/new-console-template for more information
Console.WriteLine("--Troca de Valores--");
string nome1,nome2, texto;
Console.Write("Nome 1: ");
nome1 = Console.ReadLine()!;
Console.Write("Nome 2: ");
nome2 = Console.ReadLine()!;
texto = nome1;
nome1 = nome2;
nome2=texto;
Console.WriteLine("--Pós-troca de valores--");
Console.WriteLine($"Nome 1 = {nome1}");
Console.WriteLine($"Nome 2 = {nome2}");

