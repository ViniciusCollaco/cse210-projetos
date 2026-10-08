namespace MonitoramentoExercicios
{
    public class Ciclismo : Atividade
    {
        private double _velocidadeKmh;

        public Ciclismo(string data, int duracaoMinutos, double velocidadeKmh) 
            : base(data, duracaoMinutos)
        {
            _velocidadeKmh = velocidadeKmh;
        }

        public override double ObterDistancia()
        {
            return (_velocidadeKmh * ObterDuracaoMinutos()) / 60.0;
        }

        public override double ObterVelocidade()
        {
            return _velocidadeKmh;
        }
    }
}