using System;

public class AtividadeRespiracao : Atividade
{
    public AtividadeRespiracao() 
        : base("Atividade de Respiração", "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime tempoInicio = DateTime.Now;
        DateTime tempoFim = tempoInicio.AddSeconds(GetDuracao());

        while (DateTime.Now < tempoFim)
        {
            Console.Write("\nInspire...");
            ExibirContagemRegressiva(4);
            Console.WriteLine();

            Console.Write("Expire...");
            ExibirContagemRegressiva(6);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}