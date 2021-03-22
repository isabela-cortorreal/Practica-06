using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandato2
{
    class Program
    {
        
    }

    public class Contacto
    {
        private string nombre_;
        private string apellido_;
        private string telefono_;
        private string direccion_;

        public string Nombre
        {
            get { return nombre_; }
            set { nombre_ = value; }
        }

        public string Apellido
        {
            get { return apellido_; }
            set { apellido_ = value; }
        }

        public string Telefono
        {
            get { return telefono_; }
            set { telefono_ = value; }
        }

        public string Direccion
        {
            get { return direccion_; }
            set { direccion_ = value; }
        }

        public void SetContacto(string pNombre, string pApellido, string pTelefono, string pDireccion)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Telefono = pTelefono;
            Direccion = pDireccion;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy " + Nombre + Apellido + ", mi numero de telefono es " + Telefono + " y vivo en " + Direccion + ".");
        }

        
    }

    public class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto contac1 = new Contacto();
            Contacto contac2 = new Contacto();

            contac1.SetContacto("Isabela", " Cortorreal", "809-552-6548", "Santo Domingo Este");
            contac2.SetContacto("Pedro", " Almonte", "849-472-1453", "Santo Domingo Norte");

            contac1.Saludar();
            contac2.Saludar();

            Console.ReadKey();
        }
    }
}
