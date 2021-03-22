using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandato3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseC clasec = new ClaseC();
            Console.ReadKey();
        }
    }

    public class ClaseA
    {
        public ClaseA()
        {
            Console.WriteLine("Mensaje que muestra la Clase A: Soy Isabela.");
        }
    }

    public class ClaseB : ClaseA
    {
        public ClaseB()
        {
            Console.WriteLine("Mensaje que muestra la Clase B: Mi gatita se llama Nico.");
        }
    }

    public class ClaseC : ClaseB
    {
        public ClaseC()
        {
            Console.WriteLine("Mensaje que muestra la Clase C: Hoy hice pollo frito, ya me puede llamar Isa la chef.");
        }
    }
}
