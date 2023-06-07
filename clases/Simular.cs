using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.clases
{
    internal class Simular
    {

        public Asignador comenzarSimulacion(int cantidad_clientes, int camiones_disponibles, int demanda_minima, int demanda_maxima, int capacidad_camion, int km_dia, int lambda)
        {
            // Crear lista de camiones
            ListaCamion lista_camiones = new ListaCamion();
            for (int i = 0; i < camiones_disponibles; i++)
            {
                Camion c = new Camion(capacidad_camion, km_dia, i+1);
                lista_camiones.agregar_camion(c);
            }

            // Crear lista de viajes 
            ListaViaje lista_viaje = new ListaViaje();
            for (int i = 0; i < cantidad_clientes; i++)
            {
                Viaje v = new Viaje(demanda_minima, demanda_maxima, lambda, i+1);
                lista_viaje.agregar_viaje(v);
            }


            // Ordenar viajes de mayor a menor
            //lista_viaje.ordenar_viajes();

            // Asignar camión a cada uno de los viajes
            Asignador asig = new Asignador(lista_viaje, lista_camiones);
            asig.asignaciones();

            // Imprimir asignación de viajes
            return asig;
        }
    }
}
