using CapaDatos;
using CapaN;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegStock
    {
        DatosStock objDatosStock = new DatosStock();

        public int abmStock(string accion, Stock objStock)
        {
            return objDatosStock.abmStock(accion, objStock);
        }

        public DataSet listadoStock(string cual)
        {
            return objDatosStock.listadoStocks(cual);
        }
    }
}
