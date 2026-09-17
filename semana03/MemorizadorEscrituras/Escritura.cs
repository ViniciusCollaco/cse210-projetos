using System;
using System.Collections.Generic;

namespace MemorizadorEscrituras
{
    public class Escritura
    {
        private Referencia _referencia;
        private List<Palavra> _palavras;

        public Escritura(Referencia referencia, string texto)
        {
            _referencia = referencia;
            _palavras = new List<Palavra>();

            string[] palavrasMatriz = texto.Split(' ');
            foreach (string palavraTexto in palavrasMatriz)
            {
                _palavras.Add(new Palavra(palavraTexto));
            }
        }

        public void EsconderPalavrasAleatorias(int quantidadeParaEsconder)
        {
            Random random = new Random();

            List<int> indicesVisiveis = new List<int>();
            for (int i = 0; i < _palavras.Count; i++)
            {
                if (!_palavras[i].EstaEscondida())
                {
                    indicesVisiveis.Add(i);
                }
            }

            int escondidasAteAgora = 0;
            while (escondidasAteAgora < quantidadeParaEsconder && indicesVisiveis.Count > 0)
            {
                int indiceAleatorio = random.Next(indicesVisiveis.Count);
                int indicePalavra = indicesVisiveis[indiceAleatorio];

                _palavras[indicePalavra].Esconder();

                indicesVisiveis.RemoveAt(indiceAleatorio);
                escondidasAteAgora++;
            }
        }

        public string ObterTextoExibicao()
        {
            string textoFormatado = _referencia.ObterTextoExibicao() + " - ";

            foreach (Palavra palavra in _palavras)
            {
                textoFormatado += palavra.ObterTextoExibicao() + " ";
            }

            return textoFormatado.TrimEnd();
        }

        public bool EstaCompletamenteEscondida()
        {
            foreach (Palavra palavra in _palavras)
            {
                if (!palavra.EstaEscondida())
                {
                    return false;
                }
            }
            return true;
        }
    }
}