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

        private void btnStock_Click(object sender, EventArgs e)
        {

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

        private bool ValidCodigoUnico(int codigo)
        {
            foreach (DataGridViewRow row in dgvProd.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == codigo.ToString())
                {
                    return false;


                }

            }
            return true;
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
    }
}
