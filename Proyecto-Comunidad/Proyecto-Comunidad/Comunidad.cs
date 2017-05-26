using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Comunidad 
    {
        int identificacion;
        string nombre;
        string poblacion;

        public int Identificacion
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

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}
