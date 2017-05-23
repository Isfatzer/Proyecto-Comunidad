using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Comunidad
{
    class Propiedades
    {
        string tipo_de_Propiedad;
        string codigo_de_Propiedad;
        int metros_Cuadrados;
        int nit_del_Propietario;
        List<string> gastos;

        public string Tipo_de_Propiedad
        {
            get
            {
                return tipo_de_Propiedad;
            }

            set
            {
                tipo_de_Propiedad = value;
            }
        }

        public string Codigo_de_Propiedad
        {
            get
            {
                return codigo_de_Propiedad;
            }

            set
            {
                codigo_de_Propiedad = value;
            }
        }

        public int Metros_Cuadrados
        {
            get
            {
                return metros_Cuadrados;
            }

            set
            {
                metros_Cuadrados = value;
            }
        }

        public int Nit_del_Propietario
        {
            get
            {
                return nit_del_Propietario;
            }

            set
            {
                nit_del_Propietario = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }
    }
}
