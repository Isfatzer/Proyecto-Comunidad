using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Comunidad
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        List<Comunidad> Lcomunidad = new List<Comunidad>();
        List<Gastos> Lgastos = new List<Gastos>();
        List<Propietarios> Lpropietarios = new List<Propietarios>();
        List<Propiedades> Lpropiedades = new List<Propiedades>();
        List<Pisos> Lpisos = new List<Pisos>();
        List<Local> Llocales = new List<Local>();
        List<Garaje> Lgaraje = new List<Garaje>();
        List<Pagos> Lpagos = new List<Pagos>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lee el primer archivo (Comunidad)
            string fileName = "C:\\Users\\isrom\\Source\\Repos\\Proyecto-Comunidad\\Proyecto-Comunidad\\Archivos_txt\\Comunidad.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Comunidad com = new Comunidad();
                com.Identificacion = Convert.ToInt16(leer.ReadLine());
                com.Nombre = leer.ReadLine();
                com.Poblacion = leer.ReadLine();

                Lcomunidad.Add(com);
            }
            leer.Close();

            //lee el segundo archivo (Gastos)
            string fileName2 = "C:\\Users\\isrom\\Source\\Repos\\Proyecto-Comunidad\\Proyecto-Comunidad\\Archivos_txt\\Gastos.txt";
            FileStream stream2 = new FileStream(fileName2, FileMode.Open, FileAccess.Read);
            StreamReader leer2 = new StreamReader(stream2);

            while (leer2.Peek() > -1)
            {
                Gastos gas = new Gastos();
                gas.Identificacion = leer2.ReadLine();
                gas.Nombre = leer2.ReadLine();
                gas.Tipo_de_Reparto = leer2.ReadLine();

                Lgastos.Add(gas);
            }
            leer2.Close();

            //lee el tercer archivo (propietarios)
            string fileName3 = "C:\\Users\\isrom\\Source\\Repos\\Proyecto-Comunidad\\Proyecto-Comunidad\\Archivos_txt\\Propietarios.txt";
            FileStream stream3 = new FileStream(fileName3, FileMode.Open, FileAccess.Read);
            StreamReader leer3 = new StreamReader(stream3);

            while (leer3.Peek() > -1)
            {
                Propietarios prop = new Propietarios();
                prop.Nombre = leer3.ReadLine();
                prop.Nit = Convert.ToInt32(leer3.ReadLine());
                prop.Email = leer3.ReadLine();

                Lpropietarios.Add(prop);
            }
            leer3.Close();

            //lee el primer archivo (propiedades)
            string fileName4 = "C:\\Users\\isrom\\Source\\Repos\\Proyecto-Comunidad\\Proyecto-Comunidad\\Archivos_txt\\Propiedades.txt";
            FileStream stream4 = new FileStream(fileName4, FileMode.Open, FileAccess.Read);
            StreamReader leer4 = new StreamReader(stream4);

            while (leer4.Peek() > -1)
            {
                Propiedades propdd = new Propiedades();
                Pisos pis = new Pisos();
                Local loc = new Local();
                Garaje gar = new Garaje();
                List<string> gastostemp = new List<string>();

                propdd.Tipo_de_Propiedad = leer4.ReadLine();
                if (propdd.Tipo_de_Propiedad == "P") {
                    propdd.Codigo_de_Propiedad = leer4.ReadLine();
                    propdd.Metros_Cuadrados = Convert.ToInt16(leer4.ReadLine());
                    propdd.Nit_del_Propietario = Convert.ToInt32(leer4.ReadLine());
                    string gastostr = "";
                    while (gastostr != "---")
                    {
                        gastostr = leer4.ReadLine();
                        if (gastostr != "---")
                            gastostemp.Add(gastostr);
                    }
                    propdd.Gastos = gastostemp;
                    pis.Vhvn = leer4.ReadLine();
                    pis.Habitaciones = Convert.ToInt32(leer4.ReadLine());
                    Lpisos.Add(pis);
                    
                }
                else
                if (propdd.Tipo_de_Propiedad == "L")
                {
                    propdd.Codigo_de_Propiedad = leer4.ReadLine();
                    propdd.Metros_Cuadrados = Convert.ToInt16(leer4.ReadLine());
                    propdd.Nit_del_Propietario = Convert.ToInt32(leer4.ReadLine());
                    string gastostr = "";
                    while (gastostr != "---")
                    {
                        gastostr = leer4.ReadLine();
                        if (gastostr != "---")
                            gastostemp.Add(gastostr);
                    }
                    propdd.Gastos = gastostemp;
                    loc.Nombre_Comercial = leer4.ReadLine();
                    loc.Actividad = leer4.ReadLine();
                    Llocales.Add(loc);
                }
                else
                if (propdd.Tipo_de_Propiedad == "G")
                {
                    propdd.Codigo_de_Propiedad = leer4.ReadLine();
                    propdd.Metros_Cuadrados = Convert.ToInt16(leer4.ReadLine());
                    propdd.Nit_del_Propietario = Convert.ToInt32(leer4.ReadLine());
                    string gastostr = "";
                    while (gastostr != "---")
                    {
                        gastostr = leer4.ReadLine();
                        if (gastostr != "---")
                            gastostemp.Add(gastostr);
                    }
                    propdd.Gastos = gastostemp;
                    gar. Abierta_Cerrada = leer4.ReadLine();
                    gar.Bodega = leer4.ReadLine();
                    Lgaraje.Add(gar);
                }

                Lpropiedades.Add(propdd);
                
            }
            leer4.Close();


            //lee el quinto archivo (pagos)
            string fileName5 = "C:\\Users\\isrom\\Source\\Repos\\Proyecto-Comunidad\\Proyecto-Comunidad\\Archivos_txt\\Pagos.txt";
            FileStream stream5 = new FileStream(fileName5, FileMode.Open, FileAccess.Read);
            StreamReader leer5 = new StreamReader(stream5);

            while (leer5.Peek() > -1)
            {
                Pagos pag = new Pagos();
                pag.Id_gastos = leer5.ReadLine();
                pag.Descripcion = leer5.ReadLine();
                pag.Importe = Convert.ToInt16(leer5.ReadLine());
                pag.Tipo_Zona_de_Reparto = leer5.ReadLine();

                Lpagos.Add(pag);
            }
            leer5.Close();
        }
    }
}
