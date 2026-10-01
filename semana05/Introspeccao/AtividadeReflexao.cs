using System;
using System.Collections.Generic;

public class AtividadeReflexao : Atividade
{
    private List<string> _prompts;
    private List<string> _perguntas;
    private List<string> _promptsNaoUsados;
    private List<string> _perguntasNaoUsadas;

    public AtividadeReflexao() 
        : base("Atividade de Reflexão", "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência.")
    {
        _prompts = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência para o futuro?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?"
        };

        _promptsNaoUsados = new List<string>(_prompts);
        _perguntasNaoUsadas = new List<string>(_perguntas);
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        string prompt = ObterPromptAleatorio();
        Console.WriteLine("\nConsidere a seguinte instrução:\n");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nQuando tiver algo em mente, pressione Enter para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora reflita sobre cada uma das seguintes perguntas referentes a essa experiência:");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime tempoInicio = DateTime.Now;
        DateTime tempoFim = tempoInicio.AddSeconds(ObterDuracao());

        while (DateTime.Now < tempoFim)
        {
            string pergunta = ObterPerguntaAleatoria();
            Console.Write($"> {pergunta} ");
            ExibirSpinner(5);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }

    private string ObterPromptAleatorio()
    {
        if (_promptsNaoUsados.Count == 0)
            _promptsNaoUsados = new List<string>(_prompts);

        Random rand = new Random();
        int index = rand.Next(_promptsNaoUsados.Count);
        string item = _promptsNaoUsados[index];
        _promptsNaoUsados.RemoveAt(index);
        return item;
    }

    private string ObterPerguntaAleatoria()
    {
        if (_perguntasNaoUsadas.Count == 0)
            _perguntasNaoUsadas = new List<string>(_perguntas);

        Random rand = new Random();
        int index = rand.Next(_perguntasNaoUsadas.Count);
        string item = _perguntasNaoUsadas[index];
        _perguntasNaoUsadas.RemoveAt(index);
        return item;
    }
}