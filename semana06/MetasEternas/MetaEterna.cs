namespace MetasEternas
{
    public class MetaEterna : Meta
    {
        public MetaEterna(string nome, string descricao, int pontos) : base(nome, descricao, pontos) { }

        public override int RegistrarEvento()
        {
            return ObterValorPontos();
        }

        public override bool EstaConcluida() => false;

        public override string ObterRepresentacaoEmTexto()
        {
            return $"MetaEterna:{ObterNome()},{ObterDescricao()},{ObterValorPontos()}";
        }
    }
}