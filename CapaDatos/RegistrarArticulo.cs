using CapaEntidades;
using System.Windows;

/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

namespace CapaAccesoDatos
{
    public static class RegistrarArticulo
    {
        //Creamos un método static para que invoque al método sin necesidad de crear objetos
        private static Articulos[] arreloArticulos = new Articulos[20];
        private static int contarArt = 0;



        public static bool CargarArticulos(Articulos newArtcID)
        {

            try
            {

                if (newArtcID == null)
                {
                    MessageBox.Show("El artículo no puede ser nulo.");
                    return false;
                }


                if (contarArt < arreloArticulos.Length)
                {
                    arreloArticulos[contarArt] = newArtcID;
                    contarArt++;
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


        public static Articulos[] Consultar()
        {
            
            return arreloArticulos;
        }

       
    }

}
