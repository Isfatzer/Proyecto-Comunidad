using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Local : Propiedades
    {
        string nombre_Comercial;
        string actividad;

        public string Nombre_Comercial
        {
            get
            {
                return nombre_Comercial;
            }

            set
            {
                nombre_Comercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
