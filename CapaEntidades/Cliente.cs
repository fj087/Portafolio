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
    public class Cliente
    {
        public string nombreCliente { get; set; }
        public int idCliente { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool activo { get; set; }


  
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }

      

        public override string ToString()
        {
            return $"IDArticulo: {idCliente}, Nombre: {nombreCliente}, Primer Apellido: {primerApellido}, Segundo Apellido: {segundoApellido}, Fecha de Nacimiento: {fechaNacimiento}, Activo: {(activo ? "Sí" : "No")}";
        }
    }
}
