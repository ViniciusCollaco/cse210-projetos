namespace MetasEternas
{
    public class MetaSimples : Meta
    {
        private bool _estaConcluida;

        public MetaSimples(string nome, string descricao, string pontos) : base(nome, descricao, pontos)
        {
            _estaConcluida = false;
        }

        public MetaSimples(string nome, string descricao, string pontos, bool estaConcluida) : base(nome, descricao, pontos)
        {
            _estaConcluida = estaConcluida;
        }

        public override int RegistrarEvento()
        {
            if (!_estaConcluida)
            {
                _estaConcluida = true;
                return ObterValorPontos();
            }
            return 0;
        }

        public override bool EstaConcluida() => _estaConcluida;

        public override string ObterRepresentacaoEmTexto()
        {
            return $"MetaSimples:{ObterNome()},{ObterDescricao()},{ObterValorPontos()},{_estaConcluida}";
        }
    }
}