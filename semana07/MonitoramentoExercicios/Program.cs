using System;
using System.Collections.Generic;

namespace MonitoramentoExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atividade> atividades = new List<Atividade>();

            Corrida corrida = new Corrida("03 Nov 2022", 30, 4.8);
            Ciclismo ciclismo = new Ciclismo("03 Nov 2022", 45, 20.0);
            Natacao natacao = new Natacao("03 Nov 2022", 40, 40);

            atividades.Add(corrida);
            atividades.Add(ciclismo);
            atividades.Add(natacao);

            foreach (Atividade atividade in atividades)
            {
                Console.WriteLine(atividade.ObterResumo());
            }
        }
    }
}