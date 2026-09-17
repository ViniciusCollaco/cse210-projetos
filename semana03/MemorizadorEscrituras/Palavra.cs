namespace MemorizadorEscrituras
{
    public class Palavra
    {
        private string _texto;
        private bool _estaEscondida;

        public Palavra(string texto)
        {
            _texto = texto;
            _estaEscondida = false;
        }

        public void Esconder()
        {
            _estaEscondida = true;
        }

        public void Mostrar()
        {
            _estaEscondida = false;
        }

        public bool EstaEscondida()
        {
            return _estaEscondida;
        }

        public string ObterTextoExibicao()
        {
            if (_estaEscondida)
            {
                string sublinhados = "";
                foreach (char c in _texto)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        sublinhados += "_";
                    }
                    else
                    {
                        sublinhados += c;
                    }
                }
                return sublinhados;
            }
            else
            {
                return _texto;
            }
        }
    }
}