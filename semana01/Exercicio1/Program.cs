using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu primeiro nome? ");
        string nomePrimeiro = Console.ReadLine();
        Console.Write("Qual é o seu sobrenome? ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {sobrenome}, {nomePrimeiro} {sobrenome}");
    }
}