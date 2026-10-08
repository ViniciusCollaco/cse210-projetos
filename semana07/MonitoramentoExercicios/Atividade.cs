using System;

namespace MonitoramentoExercicios
{
    public class Atividade
    {
        private string _data;
        private int _duracaoMinutos;

        public Atividade(string data, int duracaoMinutos)
        {
            _data = data;
            _duracaoMinutos = duracaoMinutos;
        }

        public string ObterData() => _data;
        public int ObterDuracaoMinutos() => _duracaoMinutos;

        public virtual double ObterDistancia()
        {
            return 0;
        }

        public virtual double ObterVelocidade()
        {
            return (ObterDistancia() / _duracaoMinutos) * 60;
        }

        public virtual double ObterRitmo()
        {
            return _duracaoMinutos / ObterDistancia();
        }

        public string ObterResumo()
        {
            return $"{_data} {GetType().Name} ({_duracaoMinutos} min): " +
                $"Distância: {ObterDistancia():F1} km, " +
                $"Velocidade: {ObterVelocidade():F1} km/h, " +
                $"Ritmo: {ObterRitmo():F2} min por km";
        }
    }
}