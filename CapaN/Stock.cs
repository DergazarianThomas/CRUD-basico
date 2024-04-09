using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaN
{
    public class Stock
    {

        #region Atributos

        private int id_stock;
        private int cantidad;
        private DateTime admitido;
        private int prod_cod;

        #endregion

        #region constructores

        public Stock()
        { }

        public Stock(int Id_stock, int Cantidad, DateTime Admitido, int Prod_cod)
        {
            this.id_stock = Id_stock;
            this.cantidad = Cantidad;
            this.admitido = Admitido;
            this.prod_cod = Prod_cod;
        }

        public Stock(int Cantidad, DateTime Admitido, int Prod_cod)
        {
            this.cantidad = Cantidad;
            this.admitido = Admitido;
            this.prod_cod = Prod_cod;
        }
        #endregion

        #region Metodos
        public void Cargar()
        {

        }
        #endregion

        #region GetSet
        public int Id_stock
        {
            get { return id_stock; }
            set { id_stock = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DateTime Admitido
        {
            get { return admitido; }
            set { admitido = value; }
        }

        public int Prod_cod
        {
            get { return prod_cod; }
            set { prod_cod = value; }
        }
        #endregion

    }
}
