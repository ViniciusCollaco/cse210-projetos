/*
CRIATIVIDADE (GAMIFICAÇÃO):
1. Sistema de Níveis e Títulos Dinâmicos:
   - Implementado no método ExibirInfoJogador() dentro do GerenciadorDeMetas.
   - O jogador sobe de nível a cada 1000 pontos acumulados e ganha títulos temáticos que estimulam o engajamento contínuo (Ex: "Buscador Diligente", "Mestre da Perseverança", "Unicórnio Ninja Épico").
2. Validação de Eventos Duplicados:
   - Nas Metas Simples e de Lista de Tarefas, caso a meta já esteja concluída, o sistema impede o acúmulo ilimitado/indevido de pontos extras.
*/

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