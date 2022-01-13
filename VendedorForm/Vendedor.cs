using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorForm
{
    public class Vendedor
    {
        public Vendedor(string nombre, string apellido, string legajo) {
        
            Nombre = nombre;
            Apellido = apellido;    
            Legajo = legajo;    
        }



        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }


        private static int comision = 10;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }

    }
}
