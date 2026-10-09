namespace MetasEternas
{
    public abstract class Meta
    {
        private string _nome;
        private string _descricao;
        private int _pontos;

        public Meta(string nome, string descricao, int pontos)
        {
            _nome = nome;
            _descricao = descricao;
            _pontos = pontos;
        }

        public string ObterNome() => _nome;
        public string ObterDescricao() => _descricao;
        public int ObterValorPontos() => _pontos;

        public abstract int RegistrarEvento();
        public abstract bool EstaConcluida();

        public virtual string ObterDetalhesEmTexto()
        {
            string status = EstaConcluida() ? "[X]" : "[ ]";
            return $"{status} {_nome} ({_descricao})";
        }

        public abstract string ObterRepresentacaoEmTexto();
    }
}