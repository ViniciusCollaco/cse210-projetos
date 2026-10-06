namespace MetasEternas
{
    public class MetaDeListaDeTarefas : Meta
    {
        private int _concluidas;
        private int _total;
        private int _bonus;

        public MetaDeListaDeTarefas(string nome, string descricao, string pontos, int total, int bonus) : base(nome, descricao, pontos)
        {
            _concluidas = 0;
            _total = total;
            _bonus = bonus;
        }

        public MetaDeListaDeTarefas(string nome, string descricao, string pontos, int bonus, int total, int concluidas) : base(nome, descricao, pontos)
        {
            _concluidas = concluidas;
            _total = total;
            _bonus = bonus;
        }

        public override int RegistrarEvento()
        {
            if (_concluidas < _total)
            {
                _concluidas++;
                int pontosGanhos = ObterValorPontos();

                if (_concluidas == _total)
                {
                    pontosGanhos += _bonus;
                }
                return pontosGanhos;
            }
            return 0;
        }

        public override bool EstaConcluida() => _concluidas >= _total;

        public override string ObterDetalhesEmTexto()
        {
            string status = EstaConcluida() ? "[X]" : "[ ]";
            return $"{status} {ObterNome()} ({ObterDescricao()}) -- Concluída {_concluidas}/{_total} vezes";
        }

        public override string ObterRepresentacaoEmTexto()
        {
            return $"MetaDeListaDeTarefas:{ObterNome()},{ObterDescricao()},{ObterValorPontos()},{_bonus},{_total},{_concluidas}";
        }
    }
}