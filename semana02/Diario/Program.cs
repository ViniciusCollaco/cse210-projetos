// EXCEDENDO OS REQUISITOS:
// Para ir além dos requisitos, implementei a persistência de dados 
// utilizando o formato JSON através do repositório de suporte 'System.Text.Json'.
// Essa abordagem resolve completamente o desafio de formatação e limpeza de caracteres especiais (como aspas, 
// vírgulas e quebras de linha que o usuário digite), eliminando falhas na leitura ou corrupção na estrutura do arquivo.

using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- MENU DIÁRIO ---");
                Console.WriteLine("1. Escrever um novo registro");
                Console.WriteLine("2. Exibir o diário");
                Console.WriteLine("3. Carregar o diário de um arquivo");
                Console.WriteLine("4. Salvar o diário em um arquivo");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = journal.GetRandomPrompt();
                        Console.WriteLine($"\nPergunta: {prompt}");
                        Console.Write("> ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToShortDateString();

                        Entry entry = new Entry(date, prompt, response);
                        journal.AddEntry(entry);
                        Console.WriteLine("Registro adicionado com sucesso!");
                        break;

                    case "2":
                        journal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("Digite o nome do arquivo para carregar (ex: diario.json): ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;

                    case "4":
                        Console.Write("Digite o nome do arquivo para salvar (ex: diario.json): ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Saindo do programa. Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}