using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public static class Administrador
    {

            public static Empleado PedirDatos()
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
            var salario = Convert.ToDecimal(Console.ReadLine());
            var empleado1 = new Empleado(nombre, apellido, numid, edad, posicion, salario);
            return empleado1;
        }

        public static Cliente PedirDatosCliente(){
            Console.WriteLine("Ingrese el nombre del cliente: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del cliente: ");
            var apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero de identificacion del cliente: ");
            var numid = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del cliente: ");
            var edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese el Email del cliente: ");
            var email = Console.ReadLine();
            Console.WriteLine("Ingrese la Telefono del cliente: ");
            var telefono = Console.ReadLine();
            var cliente1 = new Cliente(nombre, apellido, numid, edad, email, telefono);
            return cliente1;
        }

        public static void MostrarTitulo(string titulo){
            Console.WriteLine("\n============================");
            Console.WriteLine($"= { titulo.ToUpper() } =");
            Console.WriteLine("============================");
        }




   
    }
}