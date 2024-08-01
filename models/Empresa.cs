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
        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

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
            var salario = Convert.ToDecimal(Console.ReadLine());
            var empleado1 = new Empleado(nombre, apellido, numid, edad, posicion, salario);
            return empleado1;
        }

        public Cliente PedirDatosCliente(){
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

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            Console.WriteLine("Se agrego el empleado con exito");
        }

        public void AgregarCliente(Cliente cliente){
            ListaClientes.Add(cliente);
            Console.WriteLine("Se agrego el cliente con exito");
        }
        public void MostrarTodosLosEmpleados()
        {
            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarInformacion();
            }
        }
        public void MostrarInformacion(){
            

        }
        

        public void MostrarTodosLosClientes()
        {
            foreach (var cliente in ListaClientes)
            {
                cliente.MostrarInformacion();
            }
        }

        public void ActualizarEmpleado()
        {
            Console.WriteLine("Ingresa el nombre del empleado a actualizar");
            string? NombreBuscar = Console.ReadLine();
            var empleadoToUpdate = ListaEmpleados.Where(c => c.GetNombre() == NombreBuscar).ToList();
            if (empleadoToUpdate.Any())// any quiere decir si es deiferente de null
            {
                foreach (var empleado in empleadoToUpdate)
                {
                    Console.WriteLine($"Actualizando empleado ");

                    Console.WriteLine("¿Qué dato desea actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Numero documento");
                    Console.WriteLine("4. Edad");
                    Console.WriteLine("5. Posicion");
                    Console.WriteLine("6. Salario");
                    Console.WriteLine("7. Todos los datos");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            var nuevoNombre = Console.ReadLine();
                            empleado.SetNombre(nuevoNombre);
                            break;
                        case "2":
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            var nuevoApellido = Console.ReadLine();
                            empleado.SetApellido(nuevoApellido);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nuevo Documento:");
                            var nuevoNumeroDeIdentificacion = Console.ReadLine();
                            empleado.SetNumeroDeIdentificacion(nuevoNumeroDeIdentificacion);
                            break;
                        case "4":
                            Console.WriteLine("Ingrese el nuevo edad:");
                            var nuevaEdad =Convert.ToByte( Console.ReadLine());
                            empleado.SetEdad(nuevaEdad);
                            break;
                        case "5":
                            Console.WriteLine("Ingrese el nuevo posicion:");
                            empleado.Posicion = Console.ReadLine();
                            break;
                        case "6":
                            Console.WriteLine("Ingrese el nuevo salario:");
                            empleado.Salario = Convert.ToDecimal(Console.ReadLine());
                            break;
                        case "7":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                             var nuevoNombre1 = Console.ReadLine();
                            empleado.SetNombre(nuevoNombre1);

                            Console.WriteLine("Ingrese el nuevo apellido:");
                            var nuevoApellido1 = Console.ReadLine();
                            empleado.SetApellido(nuevoApellido1);
                            Console.WriteLine("Ingrese el nuevo email:");
                            var nuevoNumeroDeIdentificacion1 = Console.ReadLine();
                            empleado.SetNumeroDeIdentificacion(nuevoNumeroDeIdentificacion1);
                            Console.WriteLine("Ingrese el nuevo teléfono:");
                            var nuevaEdad1 =Convert.ToByte( Console.ReadLine());
                            empleado.SetEdad(nuevaEdad1);
                            Console.WriteLine("Ingrese el nuevo posicion:");
                            empleado.Posicion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo salario:");
                            empleado.Salario = Convert.ToDecimal(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                Console.WriteLine($"{empleadoToUpdate.Count} Empleado(s) actualizado(s) exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void EliminarEmpleado()
        {
            Console.WriteLine("Ingrese el numero de ID del empleado a eliminar");
            string? IDBuscar = Console.ReadLine(); // guarda el id que se ingreso
            // busca en la lista de empleados el empleado con el id buscado y lo guarda en la coleccion empleadoToDelete
            var empleadoToDelete = ListaEmpleados.Where(c => c.GetNumeroDeIdentificacion() == IDBuscar).ToList();

            if (empleadoToDelete.Any())// any quiere decir si es deiferente de null
            {
                foreach (var empleado in empleadoToDelete) // la coleccion e este caso es empleadoToDelete que es donde esta toda la info del empleado que se quiere elimianr
                {
                    ListaEmpleados.Remove(empleado);//elimina el empleado de la lista
                }
            }
        }

        public void EliminarCliente(){
            Console.WriteLine("Ingrese el numero de ID del empleado a eliminar");
            string? IdBucar = Console.ReadLine();

            var clienteToDelete = ListaClientes.Where(c => c.GetNumeroDeIdentificacion() == IdBucar).ToList();

            if (clienteToDelete!= null)
            {
                foreach (var cliente in clienteToDelete)
                {
                    ListaClientes.Remove(cliente);
                }
            }
        }
        

        public void BuscarEmpleado(string numeroDeIdentificacion)
        {// si ingreso parametros, no pido los datos
            var empleadoFind = ListaEmpleados.Find(e => e.GetNumeroDeIdentificacion() == numeroDeIdentificacion);
            if (empleadoFind != null)
            {
                empleadoFind.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("el empleado no existe");
            }
        }

        public void MostrarEmpleadosPorCargo(string posicion)
        {
            var empleadoCargo = ListaEmpleados.Find(e => e.Posicion == posicion.ToLower());

            if (empleadoCargo != null)
            {
                empleadoCargo.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("el empleado no existe");
            }
        }

        public void PausarMenu() // generamos una pausa en el menú para mejorar la experiencia de usuario
        {
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
        }
    }
}
