using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listaVideos = new List<Video>();

        Video video1 = new Video("Review da Cadeira Gamer Pro", "TechReviews", 600);
        video1.AdicionarComentario(new Comentario("Carlos Silva", "Achei a cadeira muito confortável, vale o preço!"));
        video1.AdicionarComentario(new Comentario("Mariana Costa", "Qual é o peso máximo que ela suporta?"));
        video1.AdicionarComentario(new Comentario("Lucas Andrade", "Ótima análise, me ajudou a decidir a compra."));
        listaVideos.Add(video1);

        Video video2 = new Video("Curso de C# para Iniciantes - Aula 01", "DevAcademy", 1200);
        video2.AdicionarComentario(new Comentario("Aline Rocha", "Explicação excelente e direta ao ponto!"));
        video2.AdicionarComentario(new Comentario("Felipe Souza", "Terá continuação sobre Programação Orientada a Objetos?"));
        video2.AdicionarComentario(new Comentario("Juliana Lima", "Melhor canal de programação, parabéns!"));
        listaVideos.Add(video2);

        Video video3 = new Video("Receita de Bolo de Cenoura Perfeito", "Cozinha Prática", 450);
        video3.AdicionarComentario(new Comentario("Roberto Melo", "Fiz aqui em casa e ficou sensacional!"));
        video3.AdicionarComentario(new Comentario("Camila Fernandes", "Posso substituir o óleo por manteiga?"));
        video3.AdicionarComentario(new Comentario("Gabriel Torres", "A cobertura de chocolate ficou perfeita."));
        listaVideos.Add(video3);

        Console.WriteLine("==================================================");
        Console.WriteLine("         RELATÓRIO DE VÍDEOS DO YOUTUBE           ");
        Console.WriteLine("==================================================\n");

        foreach (Video video in listaVideos)
        {
            Console.WriteLine($"Título: {video.GetTitulo()}");
            Console.WriteLine($"Autor: {video.GetAutor()}");
            Console.WriteLine($"Duração: {video.GetDuracaoSegundos()} segundos");
            Console.WriteLine($"Total de Comentários: {video.ObterNumeroComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.GetComentarios())
            {
                Console.WriteLine($"  - {comentario.GetNomePessoa()}: \"{comentario.GetTexto()}\"");
            }

            Console.WriteLine("\n--------------------------------------------------\n");
        }
    }
}