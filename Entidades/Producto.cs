using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos

        private int id { get; set; }
        private string nombre { get; set; }
        private string unidad { get; set;}
        private int precio { get; set;}
        private DateTime admitido { get; set;}

        #endregion

        #region constructores

        public Producto()
        { }

        public Producto(int Id, string Nombre, string Unidad, int Precio, DateTime Admitido) 
        { 
          this.id = Id;
            this.nombre = Nombre;
            this.unidad = Unidad;
            this.precio = Precio;
            this.admitido = Admitido;
        }

        public Producto(string Nombre, string Unidad, int Precio, DateTime Admitido)
        {
            this.nombre = Nombre;
            this.unidad = Unidad;
            this.precio = Precio;
            this.admitido = Admitido;
        }
        #endregion

        #region Metodos
        public void Cargar()
        {

        }
        #endregion

    }
}
