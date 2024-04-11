using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class NegProductos
    {
        DatosProductos objDatosProductos = new DatosProductos();

        public int abmProductos(string accion, Producto objProducto) 
        {
            return objDatosProductos.abmProductos(accion, objProducto);
        }

        public DataSet listadoProductos(string cual)
        {
            return objDatosProductos.listadoProductos(cual);
        }

        public List<Producto> ObtenerProductos()
        {

            return objDatosProductos.ObtenerProductos();

        }

    }
}
