using System;

namespace MonitoramentoExercicios
{
    public abstract class Atividade
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
        public abstract double ObterDistancia();
        public abstract double ObterVelocidade();
        public abstract double ObterRitmo();
        public string ObterResumo()
        {
            return $"{_data} {GetType().Name} ({_duracaoMinutos} min) - " +
                $"Distância: {ObterDistancia():F1} km, " +
                $"Velocidade: {ObterVelocidade():F1} km/h, " +
                $"Ritmo: {ObterRitmo():F2} min por km";
        }
    }
}