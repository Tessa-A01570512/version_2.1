using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.clases
{
    internal class Camion
    {
        public int capacidad_camion; //Capacidad total del camión
        public double km_dia;
        public int indice; // numero de camión
        public int capacidad_restante; // Cuanto le queda por ese día
        public double km_restantes; 
        public Camion(int capacidad_camion, int km_dia, int indice) {
            this.capacidad_camion = capacidad_camion;
            this.km_dia = (double) km_dia;
            this.indice = indice;
            capacidad_restante = capacidad_camion;
            km_restantes = km_dia;
        }

        public void nuevo_dia()
        {
            // Cada vez que un camión termine de entregar se reinician los valores
            capacidad_restante = capacidad_camion;
            km_restantes = km_dia;
        }
    }
}
