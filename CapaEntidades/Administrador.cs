using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */
namespace CapaEntidades
{


    public class Administrador 
    {

        public int identificacion {  get; set; }
        public string nombreAdmin { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaCumpleaños { get; set; }
        public DateTime fechaIngreso { get; set; }


       

        
        
        public override string ToString()
        {
            return $"Identificacion: {identificacion}, Nombre: {nombreAdmin}, Primer Apellido: {primerApellido}, Segundo Apellido: {segundoApellido}, Fecha de Nacimiento: {fechaCumpleaños}, Fecha de Ingreso: {fechaIngreso} ";
        }

      

    }
}
