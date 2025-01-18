using System;
using CapaEntidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapaAccesoDatos
{
   public static class RegistroSucursal
    {
        //Creamos un método static para que invoque al método sin necesidad de crear objetos

       
        private static Sucursal[] arregloSucursal = new Sucursal[5];
        private static int indiceInicial = 0;

        /// <summary>
        /// Método para validar las sucursales ingresadas por el usuario
        /// </summary>
        /// <param name="newSucursal"></param>
        /// <returns></returns>
        public static bool IngresarSucursales(Sucursal newSucursal)
        {
            try
            {
                if (indiceInicial < arregloSucursal.Length)
                {
                    arregloSucursal[indiceInicial] = newSucursal;
                    indiceInicial++;
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
                return true;  
            }

        }

        public static Sucursal[] Consultar()
        {
            return arregloSucursal;
        }
    }
}
