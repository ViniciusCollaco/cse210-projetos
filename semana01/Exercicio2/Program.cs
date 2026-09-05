using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual foi sua nota? ");
        string notaString = Console.ReadLine();
        int nota = int.Parse(notaString);

        string letra = "";

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        string sinal = "";
        int ultimoDigito = nota % 10;

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }
        else if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"Sua nota é: {letra}{sinal}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Não desanime! Continue se esforçando para a próxima vez.");
        }
    }
}