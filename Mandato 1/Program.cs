using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandato1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            Profesor prof = new Profesor();
            
            per.MostrarPersona("1-0012536-2", "Isabela", " Cortorreal", 18);
            prof.MostrarSueldo(20000);

            Console.ReadKey();
        }
    }

    public class Persona
    {
        string cedula_;
        string nombre_;
        string apellido_;
        int edad_;

        public string Cedula
        {
            get { return cedula_; }
            set { cedula_ = value; }
        }

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

        public int Edad
        {
            get { return edad_; }
            set { edad_ = value; }
        }

        public void MostrarPersona(string pCedula, string pNombre, string pApellido, int pEdad)
        {
            Cedula = pCedula;
            Nombre = pNombre;
            Apellido = pApellido;
            Edad = pEdad;
            
            Console.WriteLine("Mi cedula es " + Cedula + ", mi nombre es " + Nombre + Apellido + " y tengo " + Edad + " años");
        }
    }

    public class Profesor : Persona
    {
        int sueldo_;

        public int Sueldo
        {
            get { return sueldo_; }
            set { sueldo_ = value; }
        }

        public void MostrarSueldo(int pSueldo)
        {
            Sueldo = pSueldo;

            Console.WriteLine("Mi sueldo es de " + Sueldo);
        }
    }
}
