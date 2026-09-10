using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JournalApp
{
    public class Journal
    {
        public List<Entry> Entries { get; set; } = new List<Entry>();

        private readonly List<string> _prompts = new List<string>
        {
            "Quem foi a pessoa mais interessante com quem interagi hoje?",
            "Qual foi a melhor parte do meu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "Que aprendizado novo ou insight eu tive hoje?",
            "Pelo que sou grato no dia de hoje?"
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public void AddEntry(Entry newEntry)
        {
            Entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine("\nO diário está vazio.");
                return;
            }

            Console.WriteLine("\n--- REGISTROS DO DIÁRIO ---");
            foreach (Entry entry in Entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string file)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(Entries, options);
                File.WriteAllText(file, jsonString);
                Console.WriteLine($"Diário salvo com sucesso no arquivo '{file}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }
        }

        public void LoadFromFile(string file)
        {
            try
            {
                if (!File.Exists(file))
                {
                    Console.WriteLine("Arquivo não encontrado.");
                    return;
                }

                string jsonString = File.ReadAllText(file);
                List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);

                if (loadedEntries != null)
                {
                    Entries = loadedEntries;
                    Console.WriteLine($"Diário carregado com sucesso do arquivo '{file}'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar o arquivo: {ex.Message}");
            }
        }
    }
}