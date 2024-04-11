using CapaN;
using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class formTienda : Form
    {

        #region inicializar
        Producto NuevoProd;
        Producto ProdExistente;
        Stock NuevoStock;
        Stock StockExistente;

        public NegStock objNegStock = new NegStock();
        public NegProductos objNegProd = new NegProductos();
        #endregion

        public formTienda()
        {
            InitializeComponent();

            CrearDGVs();
            LlenarDgvStock();
            LlenarDgvProd();
            LlenarCbxProd();

        }

        #region creacion&llenadoDGVs

        private void LlenarDgvProd()
        {
            lblProdCarg.Text = "";
            dgvProd.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProd.listadoProductos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvProd.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            else
                lblProdCarg.Text = "No existen productos cargados en el sistema";
        }

        private void LlenarDgvStock()
        {
            lblStockCarg.Text = "";
            dgvStock.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegStock.listadoStock("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvStock.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
                lblStockCarg.Text = "No existe Stock cargado en el sistema";
        }

        private void CrearDGVs()
        {
            dgvProd.Columns.Add("0", "Codigo");
            dgvProd.Columns.Add("1", "Nombre");
            dgvProd.Columns.Add("2", "Unidad");
            dgvProd.Columns.Add("3", "Precio");

            dgvStock.Columns.Add("0", "Producto");
            dgvStock.Columns.Add("1", "Cantidad");
            dgvStock.Columns.Add("2", "Admitido");

        }

        #endregion

        void LlenarCbxProd()
        {
            cbxProd.SelectedIndex = -1;
            cbxProd.ValueMember = "Id_prod";
            cbxProd.DisplayMember = "Nombre";
            cbxProd.DataSource = objNegProd.ObtenerProductos();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!ValidarProductos())
            {
                if (ValidCodigoUnico(int.Parse(txtCod.Text)) == false)
                {
                    errorProvider1.SetError(txtCod, "El codigo ya existe");
                }
                else
                {
                    int nGrabados = -1;

                    NuevoProd = new Producto(int.Parse(txtCod.Text), txtNomb.Text, txtUnid.Text, int.Parse(txtPrecio.Text));

                    nGrabados = objNegProd.abmProductos("Alta", NuevoProd);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo cargar el producto al sistema");
                    }
                    else
                    {
                        MessageBox.Show("El producto se guardo con éxito.");
                        LlenarDgvProd();
                        LimpiarPantalla();
                    }
                }
            }
            LlenarCbxProd();
        }

        private void btnBorrarProd_Click(object sender, EventArgs e)
        {
            if (!validBorrarProd())
            {
                if (ValidCodigoUnico(int.Parse(txtCodBorr.Text)))
                {
                    errorProvider1.SetError(txtCodBorr, "El producto no existe");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el producto de codigo " + txtCodBorr.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        int nGrabados = -1;
                        NuevoProd = new Producto(int.Parse(txtCodBorr.Text));
                        nGrabados = objNegProd.abmProductos("Borrar", NuevoProd);
                        LlenarDgvProd();
                        txtCodBorr.Text = "";

                    }

                    LlenarCbxProd();
                    errorProvider1.Clear();
                    LimpiarPantalla();
                }
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!ValidarStock())
            {
                if (ValidCodigoUnicoStock(Convert.ToInt32(cbxProd.SelectedValue)) == false)
                {
                    errorProvider1.SetError(cbxProd, "El producto ya esta en stock");
                }
                else
                {
                    int nGrabados = -1;

                    NuevoStock = new Stock(int.Parse(txtCant.Text), dtpAdmit.Value, Convert.ToInt32(cbxProd.SelectedValue));

                    nGrabados = objNegStock.abmStock("Alta", NuevoStock);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo cargar el stock al sistema");
                    }
                    else
                    {
                        MessageBox.Show("El stock se guardo con éxito.");
                        LlenarDgvStock();
                        LimpiarPantalla();
                    }
                }
            }
            LlenarCbxProd();
        }

        #region validaciones

        private bool ValidarProductos()
        {
            errorProvider1.Clear();
            bool error = false;
            // Validar campos vacios
            if (String.IsNullOrEmpty(txtCod.Text))
            {
                errorProvider1.SetError(txtCod, "Debe llenar el campo");
                error = true;
            }

            if (Regex.IsMatch(txtCod.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtPrecio, "Deben ser solo numeros");
                error = true;
            }

            if (String.IsNullOrEmpty(txtNomb.Text))
            {
                errorProvider1.SetError(txtNomb, "Debe llenar el campo");
                error = true;
            }

            if (String.IsNullOrEmpty(txtUnid.Text))
            {
                errorProvider1.SetError(txtUnid, "Debe llenar el campo");
                error = true;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text))
            {
                errorProvider1.SetError(txtPrecio, "Debe llenar el campo");
                error = true;
            }

            if (Regex.IsMatch(txtPrecio.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtPrecio, "Deben ser solo numeros");
                error = true;
            }

            return error;
        }

        private bool ValidarStock()
        {
            errorProvider1.Clear();
            bool error = false;

            if (String.IsNullOrEmpty(cbxProd.Text))
            {
                errorProvider1.SetError(txtCant, "Debe llenar el campo");
                error = true;
            }

            if (Regex.IsMatch(txtCant.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtPrecio, "Deben ser solo numeros");
                error = true;
            }

            return error;
        }

        private bool ValidCodigoUnico(int codigo)
        {
            foreach (DataGridViewRow row in dgvProd.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false;


                }

            }
            return true;
        }

        private bool ValidCodigoUnicoStock(int codigo)
        {
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false;
                }

            }
            return true;
        }

        private bool validBorrarProd()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtCodBorr.Text))
            {
                errorProvider1.SetError(txtCodBorr, "Debe llenar el campo");
                error = true;
            }

            if (Regex.IsMatch(txtCodBorr.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtCodBorr, "Deben ser solo numeros");
                error = true;
            }
            return error;
        }

        private bool validBorrarStock()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtBorrStock.Text))
            {
                errorProvider1.SetError(txtBorrStock, "Debe llenar el campo");
                error = true;
            }

            if (Regex.IsMatch(txtCodBorr.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtBorrStock, "Deben ser solo numeros");
                error = true;
            }
            return error;
        }

        #endregion

        public void LimpiarPantalla()
        {
            txtCod.Text = "";
            txtNomb.Text = "";
            txtUnid.Text = "";
            txtPrecio.Text = "";
            txtCant.Text = "";
        }

        private void btnModfProd_Click(object sender, EventArgs e)
        {
            if (!ValidarProductos())
            {
                if (ValidCodigoUnico(int.Parse(txtCod.Text)))
                {
                    errorProvider1.SetError(txtCod, "Codigo inexistente");
                }
                else
                {
                    int nResultado = -1;

                    NuevoProd = new Producto(int.Parse(txtCod.Text), txtNomb.Text, txtUnid.Text, int.Parse(txtPrecio.Text));

                    nResultado = objNegProd.abmProductos("Modificar", NuevoProd); //invoco a la capa de negocio

                    if (nResultado != 0 || nResultado != -1)
                    {
                        MessageBox.Show("El producto fue modificado con éxito", "Aviso");

                        LimpiarPantalla();
                        LlenarDgvProd();
                        LlenarCbxProd();
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar modificar el produccto", "Error");
                }
            }
        }

        private void btnBorrarStock_Click(object sender, EventArgs e)
        {
            if (!validBorrarStock())
            {
                if (ValidCodigoUnicoStock(int.Parse(txtBorrStock.Text)))
                {
                    errorProvider1.SetError(txtBorrStock, "El stock de este producto no existe");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el stock del producto " + txtBorrStock.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        int nGrabados = -1;
                        NuevoStock = new Stock(int.Parse(txtBorrStock.Text));
                        nGrabados = objNegStock.abmStock("Borrar", NuevoStock);
                        LlenarDgvStock();
                        txtBorrStock.Text = "";

                    }
                    errorProvider1.Clear();
                    LimpiarPantalla();
                }
            }
        }

        private void btnModfStock_Click(object sender, EventArgs e)
        {
            if (!ValidarStock())
            {
                if (ValidCodigoUnicoStock(Convert.ToInt32(cbxProd.SelectedValue)))
                {
                    errorProvider1.SetError(cbxProd, "este producto no se encuentra en stock");
                }
                else
                {
                    int nResultado = -1;

                    NuevoStock = new Stock(int.Parse(txtCant.Text), dtpAdmit.Value, Convert.ToInt32(cbxProd.SelectedValue));

                    nResultado = objNegStock.abmStock("Modificar", NuevoStock); //invoco a la capa de negocio

                    if (nResultado != 0 || nResultado != -1)
                    {
                        MessageBox.Show("El stock fue modificado con éxito", "Aviso");

                        LimpiarPantalla();
                        LlenarDgvStock();
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar modificar el stock", "Error");
                }
            }
        }
    }
}
