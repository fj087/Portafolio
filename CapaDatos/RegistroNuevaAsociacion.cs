using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaAccesoDatos
{
    public class RegistroNuevaAsociacion
    {
        // Arreglo para almacenar sucursales y artículos
      //  public static List<Sucursal> sucursales = new List<Sucursal>();
       // public static List<Articulos> articulos = new List<Articulos>();

        // Arreglo de 100 posiciones para las asociaciones
        private static ArrayNuevaAsociacion[] asociaciones = new ArrayNuevaAsociacion[5];
        private static int indiceInicio = 0;

        public static bool IngresaSucurslxArtic(ArrayNuevaAsociacion nuevaAsociacion)
        {
            try
            {

                

                // Agregar el nuevo registro si hay espacio
                if (indiceInicio < asociaciones.Length)
                {
                    asociaciones[indiceInicio] = nuevaAsociacion;
                    indiceInicio++;
                    return true; // Indica que la inserción fue exitosa
                }
                else
                {
                    MessageBox.Show("El repositorio está lleno y no permite ingresar más asociaciones.");
                    return false;
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show($"Ocurriósssssss un error al cargar las sucursales: { xe.Message}\nDetalles: { xe.StackTrace})");
      
                return false;
            }
        }

        public static ArrayNuevaAsociacion[] Consultar()
        {
            // Retorna solo las posiciones ocupadas
            return asociaciones;
        }
    }
}