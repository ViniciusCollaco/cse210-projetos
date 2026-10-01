using System;
using System.Collections.Generic;

public class AtividadeListagem : Atividade
{
    private List<string> _prompts;

    public AtividadeListagem() 
        : base("Atividade de Listagem", "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
        _prompts = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nListe o máximo de respostas que puder para o seguinte aviso:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();

        List<string> itens = new List<string>();
        DateTime tempoInicio = DateTime.Now;
        DateTime tempoFim = tempoInicio.AddSeconds(GetDuracao());

        while (DateTime.Now < tempoFim)
        {
            Console.Write("> ");
            
            string entrada = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                itens.Add(entrada);
            }
        }

        Console.WriteLine($"Você listou {itens.Count} itens!");
        ExibirMensagemFinal();
    }
}