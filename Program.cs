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
    Console.WriteLine("5. Salir");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            empresa1.AgregarEmpleado(empresa1.PedirDatos());
            break;
        case "2":
            empresa1.MostrarTodosLosEmpleados();
            break;
        // case "3":
        //     empresaSystem.Update();
        //     break;
        // case "4":
        //     empresaSystem.Delete();
        //     break;
        // case "5":
        //     exit = true;
        //     break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }

    
}
