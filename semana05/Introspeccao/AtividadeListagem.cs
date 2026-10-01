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
        DateTime tempoFim = tempoInicio.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFim)
        {
            Console.Write("> ");
            string entrada = LerLinhaComTempoLimite(tempoFim);
            
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                itens.Add(entrada);
            }
        }

        Console.WriteLine($"\nVocê listou {itens.Count} itens!");
        ExibirMensagemFinal();
    }

    private string LerLinhaComTempoLimite(DateTime tempoFim)
    {
        string entrada = "";
        while (DateTime.Now < tempoFim)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: false);
                if (key.Key == ConsoleKey.Enter)
                {
                    return entrada;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (entrada.Length > 0)
                    {
                        entrada = entrada.Substring(0, entrada.Length - 1);
                    }
                }
                else
                {
                    entrada += key.KeyChar;
                }
            }
            System.Threading.Thread.Sleep(50);
        }
        return entrada;
    }
}