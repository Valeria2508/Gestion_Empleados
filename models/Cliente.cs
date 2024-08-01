using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Cliente: Persona
    {
        public string? Email { get; set; }
        public string? Telefono { get; set; }


        public Cliente(string nombre, string apellido, string numeroDeDocumento, byte edad,string email, string telefono) : base()
        {
            Email = email;
            Telefono = telefono;
        }
        public override void MostrarInformacion(){
            base.MostrarInformacion();
            Console.WriteLine(@$"
            Posición: {Email}
            Salario base: {Telefono}");
        }
    }
}