/* Sistema dinâmico de níveis e títulos do Jogador: feito no método ExibirInfoJogador() em GerenciadorDeMetas, o jogador evolui de nível a cada 1.000 pontos acumulados e desbloqueia títulos temáticos progressivos (ex: "Iniciante das Metas", "Buscador Diligente", "Guerreiro da Disciplina", "Mestre da Perseverança", "Unicórnio Ninja Épico").
Barra de progresso Visual no console: exibe uma barra gráfica de progresso `[██████....]` indicando o quanto falta para o próximo nível de pontuação.
Proteção contra pontuação indevida e feedback rico: ao tentar registrar um evento em uma meta já concluída (simples ou checklist), o sistema impede a duplicidade de pontos e exibe um aviso orientativo ao usuário.
Comemorações visuais de conquista: mensagens destacadas e efeitos visuais no console quando o jogador atinge o bônus de uma meta de lista de tarefas ou sobe de nível.*/

using System;

namespace MetasEternas
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
            gerenciador.Iniciar();
        }
    }
}