using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Data.OleDb;

namespace CapaNegocio
{
    public class DatosProductos : DatosConexionBD
    {

        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
                orden = "insert into productos values (" + objProducto.Id + ",'" + objProducto.Nombre + "');";
            if (accion == "Modificar")
                orden = "update productos set nombre='" + objProducto.Nombre + "' where id = "+ objProducto.Id + "; ";
            // falta la orden de borrar 

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar tabla de productos",e); 


            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


    }
}
