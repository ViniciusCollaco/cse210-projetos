using System;

namespace Figuras
{
    public abstract class Figura
    {
        private string _cor;

        public Figura(string cor)
        {
            _cor = cor;
        }

        public string ObterCor()
        {
            return _cor;
        }

        public void DefinirCor(string cor)
        {
            _cor = cor;
        }

        public abstract double ObterArea();
    }
}