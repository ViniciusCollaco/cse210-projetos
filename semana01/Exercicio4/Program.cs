using System;
using System.Collections.Generic; 
using System.Linq; 

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int numeroDigitado = -1;

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        while (numeroDigitado != 0)
        {
            Console.Write("Insira o número: ");
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado != 0)
            {
                numeros.Add(numeroDigitado);
            }
        }

        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        Console.WriteLine($"A soma é: {soma}");

        double media = (double)soma / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        int maior = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }
        Console.WriteLine($"O maior número é: {maior}");

        int? menorPositivo = null;
        foreach (int numero in numeros)
        {
            if (numero > 0)
            {
                if (menorPositivo == null || numero < menorPositivo)
                {
                    menorPositivo = numero;
                }
            }
        }

        if (menorPositivo != null)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        numeros.Sort();

        Console.WriteLine("A lista reordenada é:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}