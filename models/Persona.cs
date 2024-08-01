using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Empleados.models
{
    public abstract class Persona
    {
        // en person se agg los atributos que se le van heredar a los hijos
        protected Guid Id { get; set; }
        protected string? Nombre { get; set; }
        protected string? Apellido { get; set; }
        protected string? NumeroDeIdentificacion { get; set; }
        protected byte Edad { get; set; }

        // se crea el metodo 
        public abstract void MostrarInformacion();
        // {
        //     Console.WriteLine(@$"
        //     Id: {Id}
        //     Nombre: {Nombre}
        //     Apellido: {Apellido}
        //     Número de Identificación: {NumeroDeIdentificacion}
        //     Edad: {Edad}");
        // }

        public string GetNombre(){
            return Nombre;
        }

        public string GetNumeroDeIdentificacion(){
            return NumeroDeIdentificacion;
        }

        public void SetNombre(string nuevoNombre){
            Nombre = nuevoNombre;
        }
        public void SetApellido(string nuevoApellido){
            Nombre = nuevoApellido;
        } 
        public void SetNumeroDeIdentificacion(string nuevoNumeroDeIdentificacion){
            NumeroDeIdentificacion = nuevoNumeroDeIdentificacion;
        }
        public void SetEdad(byte nuevaEdad){
            Edad = nuevaEdad;
        }
    }

}