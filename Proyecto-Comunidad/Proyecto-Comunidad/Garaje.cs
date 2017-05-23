using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Garaje : Propiedades
    {
        string abierta_Cerrada;
        string bodega;

        public string Abierta_Cerrada
        {
            get
            {
                return abierta_Cerrada;
            }

            set
            {
                abierta_Cerrada = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}
