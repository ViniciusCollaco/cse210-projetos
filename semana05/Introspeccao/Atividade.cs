using System;
using System.Collections.Generic;
using System.Threading;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
    }

    public int GetDuracao()
    {
        return _duracao;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.\n");
        Console.WriteLine(_descricao + "\n");
        Console.Write("Por quantos segundos, aproximadamente, você gostaria que durasse sua sessão? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare-se...");
        ExibirSpinner(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("\nMuito bem!!");
        ExibirSpinner(3);
        Console.WriteLine($"\nVocê concluiu mais {_duracao} segundos de {_nome}.");
        ExibirSpinner(3);
    }

    public void ExibirSpinner(int segundos)
    {
        List<string> animacao = new List<string> { "|", "/", "-", "\\" };
        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(segundos);

        int i = 0;
        while (DateTime.Now < fim)
        {
            Console.Write(animacao[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % animacao.Count;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}