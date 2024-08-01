using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public class Empleado:Persona
    {
        // atributos de empleado
        public string? Posicion { get; set; }
        public double Salario { get; set; }


        public Empleado(string nombre, string apellido, string numeroDeDocumento, byte edad, string posicion, double salario)
        {
            Posicion = posicion;
            Salario = salario;
        }

        private double CalcularBonificacion(){
            var Bonificacion = Salario * 0.01;
            var SalarioBonificacion = Bonificacion + Salario;
            return SalarioBonificacion;
        }

        // sobre escritura de metodos
        public override void MostrarInformacion(){
            base.MostrarInformacion();
            Console.WriteLine(@$"
            Posición: {Posicion}
            Salario base: {Salario}
            Salario con Bonificación: {CalcularBonificacion()}
            ");
        }
    }
}