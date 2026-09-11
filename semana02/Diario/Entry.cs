using System;

namespace JournalApp
{
    public class Entry
    {
        public string Date { get; set; }
        public string PromptText { get; set; }
        public string EntryText { get; set; }

        public Entry() { }

        public Entry(string date, string promptText, string entryText)
        {
            Date = date;
            PromptText = promptText;
            EntryText = entryText;
        }

        public void Display()
        {
            Console.WriteLine($"Data: {Date} - Pergunta: {PromptText}");
            Console.WriteLine($"Resposta: {EntryText}\n");
        }
    }
}