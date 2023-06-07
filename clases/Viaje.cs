using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using version_two.metodos;

namespace version_two.clases
{
    internal class Viaje
    {
        public int demanda; // Unidades solicitadas
        public double distancia; 
        public int numero_cliente;
        public int numero_producto;
        public DateTime fecha;

        // Constructor de datos iniciales
        public Viaje(int demanda_minima, int demanda_maxima, int lambda, int numero_cliente) {
            this.demanda = this.simular_demanda( demanda_minima, demanda_maxima);
            this.distancia = this.simular_distancia();
            this.numero_cliente = numero_cliente;
            this.numero_producto = this.simular_numero_producto();
            this.fecha = this.simular_fecha(lambda);
        }
        
        // Constructor cuando el viaje ya existe
        public Viaje(int demanda, double distancia, int numero_producto, DateTime fecha, int numero_cliente)
        {
            this.demanda = demanda;
            this.distancia = distancia;
            this.numero_producto = numero_producto;
            this.fecha = fecha;
            this.numero_cliente = numero_cliente;
        }

        public int simular_demanda(int demanda_minima, int demanda_maxima)
        {
            // Demanda simulada con distribución uniforme
            Aleatorios ale = new Aleatorios();
            return ale.uniforme(demanda_minima, demanda_maxima);
        }

        public int simular_numero_producto()
        {
            // Con esta función se simula un "tipo" de producto
            Aleatorios ale = new Aleatorios();
            return ale.uniforme(1,100);
        }

        public DateTime simular_fecha(int lambda)
        {
            Random value = new Random();
            return DateTime.Now.AddDays(value.Next(1, 10));
        }

        public double simular_distancia()
        {
            /* 
             * Distancia en coordenadas euclidianas (X,Y)
             * con X generado con uniforme (1, 100)
             * con Y generado con uniforme (1, 100)
             */
            Aleatorios ale = new Aleatorios();
            int x = ale.uniforme(1, 100);
            int y = ale.uniforme(1, 100);
            return (double)Math.Round(Math.Sqrt(x * x + y * y));
        }
    }
}
