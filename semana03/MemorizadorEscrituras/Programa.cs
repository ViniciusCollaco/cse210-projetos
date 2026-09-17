/*
================================================================================
CRIATIVIDADE:
1. Biblioteca de Escrituras: Em vez de carregar sempre a mesma escritura, foi criada uma lista/biblioteca contendo múltiplas escrituras. O programa seleciona uma delas aleatoriamente a cada execução.
2. Esconder Apenas Palavras Visíveis: A lógica na classe 'Escritura' garante que o algoritmo filtre e sorteie APENAS palavras que ainda NÃO foram escondidas. Isso otimiza o processo e faz com que a cada 'Enter' novas palavras sumam.
3. Preservação de Pontuação: Na classe 'Palavra', a lógica ao converter em sublinhado mascara apenas letras/números, mantendo pontuações intactas.
================================================================================
*/

using System;
using System.Collections.Generic;

namespace MemorizadorEscrituras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Escritura> biblioteca = new List<Escritura>()
            {
                new Escritura(
                    new Referencia("Provérbios", 3, 5, 6),
                    "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
                ),
                new Escritura(
                    new Referencia("João", 3, 16),
                    "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
                ),
                new Escritura(
                    new Referencia("Néfi", 3, 7),
                    "Eu irei e farei as coisas que o Senhor ordenou, porque sei que o Senhor nunca dá ordens aos filhos dos homens sem antes preparar um caminho."
                )
            };

            Random random = new Random();
            Escritura escrituraSelecionada = biblioteca[random.Next(biblioteca.Count)];

            string entradaUsuario = "";

            while (entradaUsuario.ToLower() != "sair" && !escrituraSelecionada.EstaCompletamenteEscondida())
            {
                Console.Clear();
                Console.WriteLine(escrituraSelecionada.ObterTextoExibicao());
                Console.WriteLine();
                Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para encerrar:");

                entradaUsuario = Console.ReadLine();

                if (entradaUsuario.ToLower() != "sair")
                {
                    escrituraSelecionada.EsconderPalavrasAleatorias(3);
                }
            }

            Console.Clear();
            Console.WriteLine(escrituraSelecionada.ObterTextoExibicao());
            Console.WriteLine();
            Console.WriteLine("Programa encerrado. Parabéns pelo treino de memorização!");
        }
    }
}