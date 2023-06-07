using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.clases
{
    internal class Asignador
    {
        public ListaViaje lista_viajes_totales = new ListaViaje();
        public ListaCamion lista_camiones_totales = new ListaCamion();
        public List<Entrega> lista_entregas = new List<Entrega>();
        public List<DateTime> lista_fechas = new List<DateTime>();
        // KPIS
        public int entregas_totales = 0;
        public int entregas_tiempo = 0;
        public int cantidad_total = 0;
        public int cantidad_tiempo = 0;
        // Variables locales 
        public int camion_actual = 0;
        public int dia_actual = 0;

        public Asignador(ListaViaje lista_viaje, ListaCamion lista_camion)
        {
            lista_viajes_totales = lista_viaje;
            lista_camiones_totales = lista_camion;
        }

        public Asignador()
        {

        }

        public List<Entrega> asignaciones()
        {
            
            // Generar lista de fechas de hoy hasta la última entrega
            calendario(lista_viajes_totales.lista_viajes.Last().fecha);
            
            int demanda_instatisfecha_viaje_actual = 0;
            

            foreach (Viaje v in lista_viajes_totales.lista_viajes)
            {
                cantidad_total = cantidad_total + v.demanda; //Capacidad total entregada
                demanda_instatisfecha_viaje_actual = v.demanda; //Del viaje actual
                entregas_totales++; //Viajes creados

                // Mientras la demanda siga insatisfecha
                while(demanda_instatisfecha_viaje_actual > 0)
                {
                    demanda_instatisfecha_viaje_actual = asignar_entrega(v);
                }
                // Evaluar si se completó antes de la fecha solicitada
                if (v.fecha.DayOfYear >= lista_fechas[dia_actual].DayOfYear)
                {
                    entregas_tiempo = entregas_tiempo + 1;
                }

            }

            return lista_entregas;
        }

        public void calendario(DateTime last)
        {
            // Desde el día de hoy hasta la fecha última
            int i = 0;
            DateTime fecha = DateTime.Now.AddDays(i);
            while(fecha <= last)
            {
                lista_fechas.Add(fecha);
                i++;
                fecha = DateTime.Now.AddDays(i);
            }

            // Agregamos más día de colchón
            for(int j = i; j < 100000; j++)
            {
                fecha = DateTime.Now.AddDays(j);
                lista_fechas.Add(fecha);
            }
        }

        public int asignar_entrega(Viaje v)
        {
            int max_indice_camiones = lista_camiones_totales.lista_camiones.Count;
            int demanda_restante = v.demanda;
            int demanda_viaje = 0;

            // Asignar en la secuencia de camiones
            for (int i = camion_actual; i < max_indice_camiones; i++)
            {
                if(v.demanda == 0)
                {
                    break;
                }

                Camion c = lista_camiones_totales.lista_camiones[i];

                //¿El camión puede llevar carga? 
                if (c.capacidad_restante > 0)
                {
                    // Información del siguiente viaje
                    // Cantidad a entregar
                    if (c.capacidad_restante > v.demanda)
                    {
                        demanda_viaje = v.demanda; // Carga de la entrega
                        c.capacidad_restante = c.capacidad_restante - demanda_viaje;
                    }
                    else
                    {
                        demanda_viaje = c.capacidad_restante; // Carga de la entrega
                        c.capacidad_restante = 0;
                    }
                    demanda_restante = demanda_restante - demanda_viaje;
                    Entrega en = new Entrega(
                            c.indice,
                            v.distancia,
                            v.numero_cliente,
                            v.demanda,
                            demanda_viaje,
                            v.fecha,
                            lista_fechas[dia_actual]
                            );
                    lista_entregas.Add(en);
                    //KPI's
                    if(v.fecha.DayOfYear >= lista_fechas[dia_actual].DayOfYear)
                    {
                        cantidad_tiempo = cantidad_tiempo + demanda_viaje;
                    }
                    v.demanda = v.demanda - demanda_viaje; //Ajuste a la carga total del viaje
                }

                // El camion puede volver a formarse
                if(c.capacidad_restante > 0)
                {
                    camion_actual = i;
                }

            }
            
            if(demanda_restante >0)
            {
                // Ya se acabaron los camiones y aún falta demanda
                camion_actual = 0;
                dia_actual++;
                foreach (Camion cam in lista_camiones_totales.lista_camiones)
                {
                    cam.nuevo_dia();
                }
                return demanda_restante;
            }


            return demanda_restante;
        }
    }
}
