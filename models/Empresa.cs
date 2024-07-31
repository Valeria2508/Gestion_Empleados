using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Empresa
    {
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();

        public Empleado PedirDatos()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado: ");
            var apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero de identificacion del empleado: ");
            var numid = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado: ");
            var edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese el posicion del empleado: ");
            var posicion = Console.ReadLine();
            Console.WriteLine("Ingrese el salario del empleado: ");
            var salario = Convert.ToDouble(Console.ReadLine());
            var empleado1 = new Empleado(nombre, apellido, numid, edad, posicion, salario);
            return empleado1;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            Console.WriteLine("Se agrego el empleado con exito");
        }
        public void MostrarTodosLosEmpleados()
        {
            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarInformacion();
            }
        }

        

    }
}