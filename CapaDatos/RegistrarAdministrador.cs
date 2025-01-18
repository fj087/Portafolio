using System;
using CapaAccesoDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Windows.Navigation;
using System.Windows;
using System.Text.RegularExpressions;


/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

namespace CapaAccesoDatos
{
    public static class RegistrarAdministrador
    {
        /// <summary>
        /// Se crea un arreglo estático que va ser compartido por todas las instancias de la clase donde está definido.
        /// </summary>
        private static Administrador[] arregloAdministrador = new Administrador[2];
        private static int inidiceArregloAdmin = 0;


        public static bool IngresarAdministrador(Administrador newAdmin)
        {
            try
            {
                if (arregloAdministrador == null)
                {
                    MessageBox.Show("El administrador debe debe tener todos los datos.");
                    return false;
                }
                if (inidiceArregloAdmin < arregloAdministrador.Length)
                {
                    arregloAdministrador[inidiceArregloAdmin] = newAdmin;
                   inidiceArregloAdmin++;
                    return true;
                }
                else
                {
                    MessageBox.Show("El repositorio está lleno y no se puede ingresar más administradores.");
                    return false;
                }

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ocurrió un error: el índice está fuera de rango.");
                return false;
            }
           
        }

        public static Administrador[] Consultar()
        {
           return arregloAdministrador;
        }
    }
}