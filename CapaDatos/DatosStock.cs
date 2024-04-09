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

namespace CapaDatos
{
    public class DatosStock : DatosConexionBD
    {

        public int abmStock(string accion, Stock objStock)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = $"insert into stock (Cantidad, Admitido, Prod_cod) values ({objStock.Cantidad}, '{objStock.Admitido}', {objStock.Prod_cod});";
            }

            if (accion == "Modificar")
            {
                orden = $"update stock set Cantidad= {objStock.Cantidad}, Admitido= {objStock.Admitido} WHERE Prod_cod Like '%{objStock.Prod_cod}%';";
            }

            if (accion == "Borrar")
                orden = "delete * from stock where Prod_cod =" + objStock.Prod_cod + ";";
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
                orden = "select * from stock;";
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
