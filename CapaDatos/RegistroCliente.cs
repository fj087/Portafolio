using System;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

namespace CapaAccesoDatos
{
   public class RegistroCliente
    {

        private static Cliente[] arregloClientes = new Cliente[2];
        private static int indiceInicio = 0;

        /// <summary>
        /// Método que almacena los clientes ingresados 
        /// </summary>
        /// <param name="newCliente"></param>
        /// <returns></returns>
        public static bool IngresarClientes(Cliente newCliente)
        {
            try
            {


                if (indiceInicio < arregloClientes.Length)
                {
                    arregloClientes[indiceInicio] = newCliente;
                    indiceInicio++;
                    return true;

                }
                else
                {
                    MessageBox.Show("El repositorio está lleno y no permite ingresar más sucursales.");
                    return false;
                }

            }
            catch (IndexOutOfRangeException)
            { 
                MessageBox.Show("Ocurrió un error: el índice está fuera de rango.");
                return false;
            }


        }
        /// <summary>
        /// Método para consultar el arreglo en cualquier parte del código
        /// </summary>
        /// <returns></returns>
        public static Cliente[] Consultar()
        {
            return arregloClientes;
        }
    }
}
