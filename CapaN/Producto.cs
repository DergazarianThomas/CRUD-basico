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

        private int id_prod;
        private int codigo;
        private string nombre;
        private string unidad;
        private int precio;

        #endregion

        #region constructores

        public Producto()
        { }

        public Producto(int Id_prod, int Codigo, string Nombre, string Unidad, int Precio) 
        { 
            this.id_prod = Id_prod;
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.unidad = Unidad;
            this.precio = Precio;
        }

        public Producto(string Nombre, int Codigo, string Unidad, int Precio)
        {
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.unidad = Unidad;
            this.precio = Precio;
        }
        #endregion

        #region Metodos
        public void Cargar()
        {

        }
        #endregion

        #region GetSet
        public int Id_prod
        {
            get { return id_prod; }
            set { id_prod = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
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
        #endregion

    }
}
