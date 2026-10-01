// Implementação de um sistema que garante que nenhuma pergunta ou prompt aleatório 
// seja repetido na classe AtividadeReflexao, até que todos os itens tenham sido exibidos ao menos uma vez.

using System;

class Program
{
    static void Main(string[] args)
    {
        string opcao = "";

        while (opcao != "4")
        {
            Console.Clear();
            Console.WriteLine("Opções do Menu:");
            Console.WriteLine("  1. Iniciar atividade de respiração");
            Console.WriteLine("  2. Iniciar atividade de reflexão");
            Console.WriteLine("  3. Iniciar atividade de listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("Escolha uma opção do menu: ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AtividadeRespiracao ar = new AtividadeRespiracao();
                    ar.Executar();
                    break;
                case "2":
                    AtividadeReflexao aref = new AtividadeReflexao();
                    aref.Executar();
                    break;
                case "3":
                    AtividadeListagem al = new AtividadeListagem();
                    al.Executar();
                    break;
                case "4":
                    Console.WriteLine("Obrigado por utilizar o aplicativo de introspecção!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}