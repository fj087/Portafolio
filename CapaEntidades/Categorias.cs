/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaEntidades
{
    public class Categorias

    {
        public int id { get; set; }
        public string nombreCategoria { get; set; }
        public  string descrip { get; set; }




        public override string ToString()
        {
            return nombreCategoria; // Esto permite que el objeto se represente por su nombre
        }



        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != GetType()) return false;

            Categorias categoria = (Categorias)obj;
            return this.id == categoria.id && this.nombreCategoria == categoria.nombreCategoria;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, nombreCategoria);
        }
        /*
         public override string ToString()
        {
            return $"IDArticulo: {id}, Descripción: {descrip}";
        }
        */
    }
}
