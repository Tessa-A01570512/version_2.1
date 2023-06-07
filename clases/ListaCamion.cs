using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using version_two.clases;

namespace version_two.clases
{
    internal class ListaCamion
    {
        public List<Camion> lista_camiones = new List<Camion>();
        public void agregar_camion(Camion camion)
        {
            lista_camiones.Add(camion);
        }
    }
}
