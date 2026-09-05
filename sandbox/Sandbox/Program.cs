using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Sandbox.");
        Console.WriteLine("Isso é em C#");

        int numero = 5;
        numero = 9;
        numero = numero + 5;

        string cor = "azul";

        if (numero > 3)
        {
            Console.WriteLine("");
        }

        Console.WriteLine("Qual é a sua cor favorita ? ");
        string corFav = Console.ReadLine();
        Console.WriteLine($"Sua cor favorita é {corFav}");
    }
}