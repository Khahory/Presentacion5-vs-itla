using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleados = new Empleados();

            //asignar valores
            empleados.Nombre = "Angel";
            empleados.edad = 20;
            empleados.salario = 400000.00m;

            

            decimal total = empleados.calcularSalario(30);

            //imprimir
            Console.WriteLine("El nombre del empleado es: " +empleados.Nombre);
            Console.WriteLine("La edad es: {0}", empleados.edad);
            Console.WriteLine("Gana mnesual: " +total.ToString("C"));
            Console.ReadKey();
        }
    }
}
