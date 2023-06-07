using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_two.clases
{
    internal class Entrega
    {
        public int numero_camion; // Número de camión que hará la entrega
        public double distancia; // Distancia del punto (0,0) al cliente
        public int cliente; // Número de cliente
        public int producto; // Cantidad solicitada
        public int demanda_entregada; // Cuánto se entregó en esta entrega
        public DateTime fecha; // Fecha que el cliente requiere el pedido
        public DateTime fecha_entregada; // Fecha cuando se le hace la entrega

        public Entrega(int numero_camion, double distancia, int cliente, int producto, int demanda_entregada, DateTime fecha, DateTime fecha_entregada)
        {
            this.numero_camion = numero_camion;
            this.distancia = distancia; 
            this.cliente = cliente;
            this.producto = producto;
            this.demanda_entregada = demanda_entregada;
            this.fecha = fecha;
            this.fecha_entregada = fecha_entregada;
        }
    }
}
