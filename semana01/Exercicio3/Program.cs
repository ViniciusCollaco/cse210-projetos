using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        string jogarDeNovo = "sim";

        while (jogarDeNovo.ToLower() == "sim")
        {
            int numeroMagico = geradorAleatorio.Next(1, 101);
            int resposta = -1;
            int contadorPalpites = 0; 

            while (resposta != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                string respostaString = Console.ReadLine();
                resposta = int.Parse(respostaString);
                
                contadorPalpites++;

                if (resposta < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (resposta > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você precisou de {contadorPalpites} palpites para acertar!");

            Console.Write("Deseja jogar de novo (sim/não)? ");
            jogarDeNovo = Console.ReadLine();
            Console.WriteLine(); 
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}