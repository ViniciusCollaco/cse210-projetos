namespace MetasEternas
{
    public class MetaDeListaDeTarefas : Meta
    {
        private int _quantidadeConcluida;
        private int _target;
        private int _bonus;

        public MetaDeListaDeTarefas(string nome, string descricao, int pontos, int target, int bonus) : base(nome, descricao, pontos)
        {
            _quantidadeConcluida = 0;
            _target = target;
            _bonus = bonus;
        }

        public MetaDeListaDeTarefas(string nome, string descricao, int pontos, int bonus, int target, int quantidadeConcluida) : base(nome, descricao, pontos)
        {
            _bonus = bonus;
            _target = target;
            _quantidadeConcluida = quantidadeConcluida;
        }

        public override int RegistrarEvento()
        {
            if (_quantidadeConcluida < _target)
            {
                _quantidadeConcluida++;
                if (_quantidadeConcluida == _target)
                {
                    return ObterValorPontos() + _bonus;
                }
                return ObterValorPontos();
            }
            return 0;
        }

        public override bool EstaConcluida() => _quantidadeConcluida >= _target;

        public override string ObterDetalhesEmTexto()
        {
            string status = EstaConcluida() ? "[X]" : "[ ]";
            return $"{status} {ObterNome()} ({ObterDescricao()}) -- Concluído: {_quantidadeConcluida}/{_target}";
        }

        public override string ObterRepresentacaoEmTexto()
        {
            return $"MetaDeListaDeTarefas:{ObterNome()},{ObterDescricao()},{ObterValorPontos()},{_bonus},{_target},{_quantidadeConcluida}";
        }
    }
}