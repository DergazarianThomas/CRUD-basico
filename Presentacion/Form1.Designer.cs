namespace Presentacion
{
    partial class formTienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabProdStock = new System.Windows.Forms.TabControl();
            this.tabPageProd = new System.Windows.Forms.TabPage();
            this.lblProdCarg = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUnid = new System.Windows.Forms.TextBox();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.lblStockCarg = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabProdStock.SuspendLayout();
            this.tabPageProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProdStock
            // 
            this.tabProdStock.Controls.Add(this.tabPageProd);
            this.tabProdStock.Controls.Add(this.tabPageStock);
            this.tabProdStock.Location = new System.Drawing.Point(-1, -1);
            this.tabProdStock.Name = "tabProdStock";
            this.tabProdStock.SelectedIndex = 0;
            this.tabProdStock.Size = new System.Drawing.Size(801, 449);
            this.tabProdStock.TabIndex = 0;
            // 
            // tabPageProd
            // 
            this.tabPageProd.Controls.Add(this.lblProdCarg);
            this.tabPageProd.Controls.Add(this.dgvProd);
            this.tabPageProd.Controls.Add(this.panel1);
            this.tabPageProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageProd.Name = "tabPageProd";
            this.tabPageProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProd.Size = new System.Drawing.Size(793, 423);
            this.tabPageProd.TabIndex = 0;
            this.tabPageProd.Text = "Productos";
            this.tabPageProd.UseVisualStyleBackColor = true;
            // 
            // lblProdCarg
            // 
            this.lblProdCarg.AutoSize = true;
            this.lblProdCarg.Location = new System.Drawing.Point(660, 304);
            this.lblProdCarg.Name = "lblProdCarg";
            this.lblProdCarg.Size = new System.Drawing.Size(9, 13);
            this.lblProdCarg.TabIndex = 9;
            this.lblProdCarg.Text = "|";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(317, 17);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(401, 272);
            this.dgvProd.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.lblUnidad);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Controls.Add(this.txtNomb);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtUnid);
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 272);
            this.panel1.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(21, 153);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(63, 203);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(17, 115);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(41, 13);
            this.lblUnidad.TabIndex = 7;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(63, 39);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(17, 42);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Codigo";
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(63, 77);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(100, 20);
            this.txtNomb.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(63, 150);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtUnid
            // 
            this.txtUnid.Location = new System.Drawing.Point(63, 112);
            this.txtUnid.Name = "txtUnid";
            this.txtUnid.Size = new System.Drawing.Size(100, 20);
            this.txtUnid.TabIndex = 3;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Controls.Add(this.lblStockCarg);
            this.tabPageStock.Controls.Add(this.dgvStock);
            this.tabPageStock.Controls.Add(this.panel2);
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(793, 423);
            this.tabPageStock.TabIndex = 1;
            this.tabPageStock.Text = "Stock";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // lblStockCarg
            // 
            this.lblStockCarg.AutoSize = true;
            this.lblStockCarg.Location = new System.Drawing.Point(636, 307);
            this.lblStockCarg.Name = "lblStockCarg";
            this.lblStockCarg.Size = new System.Drawing.Size(9, 13);
            this.lblStockCarg.TabIndex = 10;
            this.lblStockCarg.Text = "|";
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(333, 21);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(401, 272);
            this.dgvStock.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbxProd);
            this.panel2.Controls.Add(this.btnStock);
            this.panel2.Controls.Add(this.lblAdm);
            this.panel2.Controls.Add(this.lblCant);
            this.panel2.Controls.Add(this.lblProd);
            this.panel2.Controls.Add(this.txtCant);
            this.panel2.Location = new System.Drawing.Point(33, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 272);
            this.panel2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // cbxProd
            // 
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(63, 39);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(121, 21);
            this.cbxProd.TabIndex = 9;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(63, 203);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(75, 23);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Cargar";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Location = new System.Drawing.Point(10, 115);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(47, 13);
            this.lblAdm.TabIndex = 7;
            this.lblAdm.Text = "Admitido";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(9, 80);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(49, 13);
            this.lblCant.TabIndex = 6;
            this.lblCant.Text = "Cantidad";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(8, 42);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(50, 13);
            this.lblProd.TabIndex = 5;
            this.lblProd.Text = "Producto";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(63, 77);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabProdStock);
            this.Name = "formTienda";
            this.Text = "Tienda";
            this.tabProdStock.ResumeLayout(false);
            this.tabPageProd.ResumeLayout(false);
            this.tabPageProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageStock.ResumeLayout(false);
            this.tabPageStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProdStock;
        private System.Windows.Forms.TabPage tabPageProd;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtUnid;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label lblProdCarg;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Label lblStockCarg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

