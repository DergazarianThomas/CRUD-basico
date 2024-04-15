using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaN;
using System.Collections;
using System.Reflection;

namespace CapaDatos
{
    public class DatosStock : DatosConexionBD
    {
        public int convertToBit(bool caducado)
        {
            if ( caducado == true)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

        public string convertToDate(DateTime adm)
        {
            string fechaFormateada = adm.ToString("yyyy-MM-dd HH:mm:ss");

            return fechaFormateada;
        }


        public int abmStock(string accion, Stock objStock)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = $"insert into stock (Cantidad, Admitido, Prod_cod, Caducado) values ({objStock.Cantidad}, '{convertToDate(objStock.Admitido)}', {objStock.Prod_cod}, {convertToBit(objStock.Caducado)} );";
            }

            if (accion == "Modificar")
            {
                orden = $"update stock set Cantidad= {objStock.Cantidad}, Admitido= '{convertToDate(objStock.Admitido)}', Caducado= {convertToBit(objStock.Caducado)} WHERE Prod_cod Like '%{objStock.Prod_cod}%';";
            }

            if (accion == "Borrar")
                orden = "delete from stock where Prod_cod = " + objStock.Prod_cod + ";";
            // falta la orden de borrar 

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar tabla de stock", e);


            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoStocks(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from stock where Id_stock = " + int.Parse(cual) + ";";
            else
                orden = "select s.Prod_cod, p.Nombre, s.Cantidad, s.Admitido, s.Caducado from stock s inner join productos p on s.Prod_cod = p.Codigo;";

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
                throw new Exception("Error al listar Stocks", e);
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
