//Implementado um sistema de controle de memória na classe AtividadeReflexao que garante 
// que nenhum prompt ou pergunta seja repetido até que todos os itens da lista tenham sido exibidos.

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