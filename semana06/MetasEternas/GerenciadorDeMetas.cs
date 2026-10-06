using System;
using System.Collections.Generic;
using System.IO;

namespace MetasEternas
{
    public class GerenciadorDeMetas
    {
        private List<Meta> _metas;
        private int _pontos;

        public GerenciadorDeMetas()
        {
            _metas = new List<Meta>();
            _pontos = 0;
        }

        public void Iniciar()
        {
            string opcao = "";
            while (opcao != "6")
            {
                ExibirInfoJogador();
                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("  1. Criar Nova Meta");
                Console.WriteLine("  2. Listar Metas");
                Console.WriteLine("  3. Salvar Metas");
                Console.WriteLine("  4. Carregar Metas");
                Console.WriteLine("  5. Registrar Evento");
                Console.WriteLine("  6. Sair");
                Console.Write("Selecione uma opção do menu: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": CriarMeta(); break;
                    case "2": ListarDetalhesDasMetas(); break;
                    case "3": SalvarMetas(); break;
                    case "4": CarregarMetas(); break;
                    case "5": RegistrarEvento(); break;
                }
            }
        }

        public void ExibirInfoJogador()
        {
            int nivel = (_pontos / 1000) + 1;
            string titulo = nivel switch
            {
                1 => "Iniciante das Metas",
                2 => "Buscador Diligente",
                3 => "Guerreiro da Disciplina",
                4 => "Mestre da Perseverança",
                _ => "Unicórnio Ninja Épico"
            };

            Console.WriteLine($"\n*** Você tem {_pontos} pontos! | Nível {nivel}: {titulo} ***");
        }

        public void ListarNomesDasMetas()
        {
            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
            }
        }

        public void ListarDetalhesDasMetas()
        {
            Console.WriteLine("\nSuas Metas:");
            if (_metas.Count == 0)
            {
                Console.WriteLine("Nenhuma meta cadastrada.");
                return;
            }

            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
            }
        }

        public void CriarMeta()
        {
            Console.WriteLine("\nTipos de Metas:");
            Console.WriteLine("  1. Meta Simples");
            Console.WriteLine("  2. Meta Eterna");
            Console.WriteLine("  3. Meta de Lista de Tarefas");
            Console.Write("Qual tipo de meta você gostaria de criar? ");
            string tipo = Console.ReadLine();

            Console.Write("Qual é o nome da sua meta? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é uma curta descrição dela? ");
            string descricao = Console.ReadLine();
            Console.Write("Qual é a quantidade de pontos associada a esta meta? ");
            string pontos = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    _metas.Add(new MetaSimples(nome, descricao, pontos));
                    break;
                case "2":
                    _metas.Add(new MetaEterna(nome, descricao, pontos));
                    break;
                case "3":
                    Console.Write("Quantas vezes essa meta precisa ser realizada para um bônus? ");
                    int total = int.Parse(Console.ReadLine());
                    Console.Write("Qual é o bônus por realizar essa quantidade de vezes? ");
                    int bonus = int.Parse(Console.ReadLine());
                    _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus));
                    break;
            }
        }

        public void RegistrarEvento()
        {
            Console.WriteLine("\nSuas metas são:");
            ListarNomesDasMetas();
            Console.Write("Qual meta você realizou? ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < _metas.Count)
            {
                int pontosGanhos = _metas[indice].RegistrarEvento();
                _pontos += pontosGanhos;
                Console.WriteLine($"Parabéns! Você ganhou {pontosGanhos} pontos!");
                Console.WriteLine($"Você agora tem {_pontos} pontos.");
            }
        }

        public void SalvarMetas()
        {
            Console.Write("Qual é o nome do arquivo para salvar? ");
            string nomeArquivo = Console.ReadLine();

            using (StreamWriter output = new StreamWriter(nomeArquivo))
            {
                output.WriteLine(_pontos);
                foreach (Meta m in _metas)
                {
                    output.WriteLine(m.ObterRepresentacaoEmTexto());
                }
            }
            Console.WriteLine("Metas salvas com sucesso!");
        }

        public void CarregarMetas()
        {
            Console.Write("Qual é o nome do arquivo para carregar? ");
            string nomeArquivo = Console.ReadLine();

            if (!File.Exists(nomeArquivo))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(nomeArquivo);
            _pontos = int.Parse(linhas[0]);
            _metas.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] partesTipo = linhas[i].Split(':');
                string tipo = partesTipo[0];
                string[] dados = partesTipo[1].Split(',');

                switch (tipo)
                {
                    case "MetaSimples":
                        _metas.Add(new MetaSimples(dados[0], dados[1], dados[2], bool.Parse(dados[3])));
                        break;
                    case "MetaEterna":
                        _metas.Add(new MetaEterna(dados[0], dados[1], dados[2]));
                        break;
                    case "MetaDeListaDeTarefas":
                        _metas.Add(new MetaDeListaDeTarefas(dados[0], dados[1], dados[2], int.Parse(dados[3]), int.Parse(dados[4]), int.Parse(dados[5])));
                        break;
                }
            }
            Console.WriteLine("Metas carregadas com sucesso!");
        }
    }
}