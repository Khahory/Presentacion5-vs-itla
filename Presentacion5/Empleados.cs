using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Empleados
    {
        //constructor
        public Empleados()
        {
            Nombre = "";
            edad = 0;
            salario = 0.0m;
        }

        


        private string _nombre;

        //otra forma pro
        public decimal salario { get; set; }

        public int edad;
        

        public string Nombre { get => _nombre; set => _nombre = value; }

        public decimal calcularSalario(int numDias)
        {
            return salario * numDias;
        }

    }
}
