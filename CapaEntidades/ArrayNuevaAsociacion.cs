using System;
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

namespace CapaEntidades
{
    public class ArrayNuevaAsociacion
    {
        public Sucursal Sucursal { get; set; }
        public Articulos Articulo { get; set; }
        public int Cantidad { get; set; }

        // Constructor
        public ArrayNuevaAsociacion(Sucursal sucursal, Articulos articulo, int cantidad)
        {
            Sucursal = sucursal;
            Articulo = articulo;
            Cantidad = cantidad;
        }

        // Sobrescribir Equals para validar que no se repita la combinación de Sucursal y Articulo
        public override bool Equals(object obj)
        {
            if (obj is ArrayNuevaAsociacion otraAsociacion)
            {


                return Sucursal.Equals(otraAsociacion.Sucursal) && Articulo.Equals(otraAsociacion.Articulo);
            }

            return false;
        }





    }



}





