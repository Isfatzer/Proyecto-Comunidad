using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Gastos
    {
        string identificacion;
        string nombre;
        string tipo_de_Reparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipo_de_Reparto
        {
            get
            {
                return tipo_de_Reparto;
            }

            set
            {
                tipo_de_Reparto = value;
            }
        }
    }
}
