using System;
using System.Collections.Generic;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            Quadrado q1 = new Quadrado("Vermelho", 5);
            Retangulo r1 = new Retangulo("Azul", 4, 6);
            Circulo c1 = new Circulo("Verde", 3);

            figuras.Add(q1);
            figuras.Add(r1);
            figuras.Add(c1);

            foreach (Figura f in figuras)
            {
                string cor = f.ObterCor();
                double area = f.ObterArea();

                Console.WriteLine($"Figura {f.GetType().Name} - Cor: {cor} | Área: {area:F2}");
            }
        }
    }
}