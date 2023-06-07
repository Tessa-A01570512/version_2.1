using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.metodos
{
    internal class Aleatorios
    {

        // Distribución Uniforme
        public int uniforme(int a = 0, int b = 1)
        {
            Random rnd = new Random();
            int num = rnd.Next(a, b);
            return num;
        }

        // Distribución Poisson para las fechas
        public int poisson(int lambda)
        {
            int x = 0;
            double h = 0.0;
            double y;

            while(h < 1)
            {
                y = exponencial(lambda);
                h = h + y;
                x = x + 1;
            }

            return x;
        }


        // Exponencial para generar Poisson
        public double exponencial(int lambda)
        {
            Random val = new Random();
            double r = (double) val.NextDouble();
            double op = (double) Math.Log10(1.0 - r);
            double value = -(1 / lambda) * op;
            return value;
        }
    }
}
