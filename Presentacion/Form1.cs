﻿using CapaN;
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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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

        public Producto objEntProd = new Producto();
        public Stock objEntStock = new Stock();

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
                    dgvStock.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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

            dgvStock.Columns.Add("0", "Codigo");
            dgvStock.Columns.Add("1", "Producto");
            dgvStock.Columns.Add("2", "Cantidad");
            dgvStock.Columns.Add("3", "Admitido");
            dgvStock.Columns.Add("4", "Caducado");

        }

        #endregion

        #region botones

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
                    string fechaFormateada = dtpAdmit.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    int nGrabados = -1;

                    NuevoStock = new Stock(int.Parse(txtCant.Text), DateTime.Parse(fechaFormateada), Convert.ToInt32(cbxProd.SelectedValue), chbCaducado.Checked );

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

                    NuevoStock = new Stock(int.Parse(txtCant.Text), dtpAdmit.Value, Convert.ToInt32(cbxProd.SelectedValue), chbCaducado.Checked);

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
        #endregion

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

            if (String.IsNullOrEmpty(txtCant.Text))
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

        void LlenarCbxProd()
        {
            cbxProd.SelectedIndex = -1;
            cbxProd.ValueMember = "Codigo";
            cbxProd.DisplayMember = "Nombre";
            cbxProd.DataSource = objNegProd.ObtenerProductos();

        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objEntProd.Codigo = Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value);

            ds = objNegProd.listadoProductos(objEntProd.Codigo.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                LlenarTxtsProd(ds);
                btnCargarProd.Visible = false;
            }
        }

        private void LlenarTxtsProd(DataSet ds)
        {
            txtCod.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txtNomb.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtUnid.Text = ds.Tables[0].Rows[0]["Unidad"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
        }

        private void CrearPdf(DataGridView dataGridView, string filePath)
        {
            try
            {
                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    Cell headerCell = new Cell().Add(new Paragraph(column.HeaderText));
                    table.AddHeaderCell(headerCell);
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                        }
                        else
                        {
                            table.AddCell(new Cell());
                        }
                    }
                }

                document.Add(table);

                document.Close();

                MessageBox.Show("Reporte generado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el pdf: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRepProd_Click(object sender, EventArgs e)
        {
            CrearPdf(dgvProd, @"E:\k\Reportes\" + "ReporteProd_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");
        }

        private void btnRepStock_Click(object sender, EventArgs e)
        {
            CrearPdf(dgvStock, @"E:\k\Reportes\" + "Reporte_Stock" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");
        }
    }
}
