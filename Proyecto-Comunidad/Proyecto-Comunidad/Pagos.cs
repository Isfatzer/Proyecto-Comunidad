using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Pagos
    {
        string id_gastos;
        string descripcion;
        int importe;
        string tipo_Zona_de_Reparto;

        public string Id_gastos
        {
            get
            {
                return id_gastos;
            }

            set
            {
                id_gastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipo_Zona_de_Reparto
        {
            get
            {
                return tipo_Zona_de_Reparto;
            }

            set
            {
                tipo_Zona_de_Reparto = value;
            }
        }
    }
}
