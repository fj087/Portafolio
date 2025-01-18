using CapaEntidades;
using System.Windows;

/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

namespace CapaAccesoDatos
{
    public static class RegistroCat
    {
        //Creamos un método static para que invoque al método sin necesidad de crear objetos

        private static Categorias[] arregloCateg = new Categorias[10];
        private static int indiceAtual = 0;

        ///<summary>
        ///Método que almacena las categorías ingresadas por el usuario
        /// <param name="newCateg">Recibe los datos del empleado</param>
        /// </summary>

        public static bool CargarCategorias(Categorias newCateg)
        {
            try
            {

                if (indiceAtual < arregloCateg.Length)
                {
                    arregloCateg[indiceAtual] = newCateg;
                    indiceAtual++;

                    return true;


                }
                else
                {
                    MessageBox.Show("El repositorio está lleno y no permite ingresar más categorías");
                    return false;
                }

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ocurrió un error: el índice está fuera de rango.");
                return false;
            }

        }

        public static Categorias[] Consultar()

        { 
            return arregloCateg;
        }

    }


}