namespace Fracoes
{
    public class Fracao
    {
        private int _numerador;
        private int _denominador;
        public Fracao()
        {
            _numerador = 1;
            _denominador = 1;
        }

        public Fracao(int numerador)
        {
            _numerador = numerador;
            _denominador = 1;
        }

        public Fracao(int numerador, int denominador)
        {
            _numerador = numerador;
            _denominador = denominador != 0 ? denominador : 1;
        }

        public int GetNumerador()
        {
            return _numerador;
        }

        public void SetNumerador(int numerador)
        {
            _numerador = numerador;
        }

        public int GetDenominador()
        {
            return _denominador;
        }

        public void SetDenominador(int denominador)
        {
            if (denominador != 0)
            {
                _denominador = denominador;
            }
            else
            {
                Console.WriteLine("Erro: O denominador não pode ser zero.");
            }
        }

        public string ObterFracaoEmTexto()
        {
            return $"{_numerador}/{_denominador}";
        }

        public double ObterFracaoEmDecimal()
        {

            return (double)_numerador / _denominador;
        }
    }
}