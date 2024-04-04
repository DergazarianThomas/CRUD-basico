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

        private int id;
        private string nombre;
        private string unidad;
        private int precio;
        private DateTime admitido;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public DateTime Admitido
        {
            get { return admitido; }
            set { admitido = value; }
        }

    }
}
