/* UNED III Cuatrimestre
 * Proyecto 1: Tienda Deportiva
 * Estudiante: Jessenia Fuentes Ruiz
 * Fecha: 06/09/2024
 * */

using System.Windows.Markup;

namespace CapaEntidades
{
    public class Articulos : Categorias
    {
        
       
        
        private int idArticulo;
        public string descripcion { get; set; }
        public bool activo { get; set; }
        public string marca {  get; set; }
        public int cantidad { get; set; }
       
        
        

        //contructor de la clase derivada




        public int IDArticulo

        {
            get
            {
                return idArticulo;
            }
            set
            {
                idArticulo = value;
            }

        }

      
        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != GetType()) return false;

            Articulos articulos = (Articulos)obj;
            return this.IDArticulo == articulos.IDArticulo && this.nombreCategoria == articulos.nombreCategoria;

        }

        public override int GetHashCode()
        {
           return HashCode.Combine(IDArticulo,nombreCategoria);
        }


        public override string ToString()
        {
            return $"IDArticulo: {IDArticulo}, Descripción: {descripcion}, Marca: {marca}, Activo: {(Activo ? "True" : "False")}, Categoría: {nombreCategoria}";
        }
    }
}
