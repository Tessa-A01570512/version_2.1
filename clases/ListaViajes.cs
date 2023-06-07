using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.clases
{
    internal class ListaViaje
    {
        public List<Viaje> lista_viajes = new List<Viaje>();
        public int dimension = 0;

        public void agregar_viaje(Viaje viaje)
        {
            lista_viajes.Add(viaje);
            dimension++;
        }

        public void ordenar_viajes()
        {
            for(int i = 0; i < dimension; i++)
            {
                for(int j = 0; j < dimension - 1; j++)
                {
                    if (lista_viajes[j].fecha >= lista_viajes[j+1].fecha)
                    {
                        Viaje aux = new Viaje(
                            lista_viajes[j].demanda,
                            lista_viajes[j].distancia,
                            lista_viajes[j].numero_producto,
                            lista_viajes[j].fecha,
                            lista_viajes[j].numero_cliente
                            );
                        lista_viajes[j] = lista_viajes[j + 1];
                        lista_viajes[j + 1] = aux;
                    }
                }
            }
        }

    }
}
