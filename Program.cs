using Gestion_Empleados.models;
var empresa1 = new Empresa();
bool exit = false;

while (!exit)
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Crear un nuevo Empleado");
    Console.WriteLine("2. Leer todos los Empleados");
    Console.WriteLine("3. Actualizar un Empleado");
    Console.WriteLine("4. Eliminar un Empleado");
    Console.WriteLine("5. Buscar un Empleado");
    Console.WriteLine("6. Buscar un Empleado por cargo");
    Console.WriteLine("7. Salir");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            empresa1.AgregarEmpleado(empresa1.PedirDatos());
            break;
        case "2":
            empresa1.MostrarTodosLosEmpleados();
            break;
        case "3":
            empresa1.ActualizarEmpleado();
            break;
        case "4":
            empresa1.EliminarEmpleado();
            Console.WriteLine("El empleado se elimino con exito");
            break;
        case"5":
            Console.WriteLine("Ingrese el número de identificación del empleado a buscar:");
            var documentoEncontrado = Console.ReadLine();
            Console.WriteLine("el empleado se encontro con la informacion");
            empresa1.BuscarEmpleado(documentoEncontrado);
            break;
        case"6":
            Console.WriteLine("Ingrese el cargo del empleado a buscar:");
            var empleadoCargo = Console.ReadLine();
            Console.WriteLine("el empleado se encontro con la informacion");
            empresa1.MostrarEmpleadosPorCargo(empleadoCargo);
            break;
        case "7":
            exit = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }


}
