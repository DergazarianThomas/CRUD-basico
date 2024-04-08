using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Data.OleDb;
using CapaDatos;

namespace CapaDatos
{
    public class DatosProductos : DatosConexionBD
    {

        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta") 
            {
                orden = $"insert into productos (Codigo, Nombre, Unidad, Precio, Admitido) values ({objProducto.Codigo}, '{objProducto.Nombre}', '{objProducto.Unidad} ',{objProducto.Precio} , '{objProducto.Admitido}');";
            }

            if (accion == "Modificar")
            {
                orden = $"update productos set NombreProducto='{objProducto.Nombre}', Unidad=' {objProducto.Unidad}', Precio=' {objProducto.Precio}', Admitido=' {objProducto.Admitido}' WHERE Codigo Like '%{objProducto.Codigo}%';";
            }

            if (accion == "Borrar")
                orden = "delete * from productos where Codigo =" + objProducto.Codigo + ";";
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

        public DataSet listadoProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from productos where Id = " + int.Parse(cual) + ";";
            else
                orden = "select * from productos;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}

    

