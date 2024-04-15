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
            this.btnRepProd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.txtCodBorr = new System.Windows.Forms.TextBox();
            this.lblProdCarg = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModfProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCargarProd = new System.Windows.Forms.Button();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUnid = new System.Windows.Forms.TextBox();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrarStock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorrStock = new System.Windows.Forms.TextBox();
            this.lblStockCarg = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbCaducado = new System.Windows.Forms.CheckBox();
            this.btnModfStock = new System.Windows.Forms.Button();
            this.dtpAdmit = new System.Windows.Forms.DateTimePicker();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.btnCargarStock = new System.Windows.Forms.Button();
            this.lblAdm = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRepStock = new System.Windows.Forms.Button();
            this.tabProdStock.SuspendLayout();
            this.tabPageProd.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tabPageProd.BackColor = System.Drawing.Color.MistyRose;
            this.tabPageProd.Controls.Add(this.btnRepProd);
            this.tabPageProd.Controls.Add(this.panel3);
            this.tabPageProd.Controls.Add(this.lblProdCarg);
            this.tabPageProd.Controls.Add(this.dgvProd);
            this.tabPageProd.Controls.Add(this.panel1);
            this.tabPageProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageProd.Name = "tabPageProd";
            this.tabPageProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProd.Size = new System.Drawing.Size(793, 423);
            this.tabPageProd.TabIndex = 0;
            this.tabPageProd.Text = "Productos";
            // 
            // btnRepProd
            // 
            this.btnRepProd.Location = new System.Drawing.Point(416, 305);
            this.btnRepProd.Name = "btnRepProd";
            this.btnRepProd.Size = new System.Drawing.Size(75, 23);
            this.btnRepProd.TabIndex = 13;
            this.btnRepProd.Text = "Reporte";
            this.btnRepProd.UseVisualStyleBackColor = true;
            this.btnRepProd.Click += new System.EventHandler(this.btnRepProd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnBorrarProd);
            this.panel3.Controls.Add(this.lblBorrar);
            this.panel3.Controls.Add(this.txtCodBorr);
            this.panel3.Location = new System.Drawing.Point(239, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 128);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "BORRAR";
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.Location = new System.Drawing.Point(26, 89);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(64, 23);
            this.btnBorrarProd.TabIndex = 9;
            this.btnBorrarProd.Text = "Borrar";
            this.btnBorrarProd.UseVisualStyleBackColor = true;
            this.btnBorrarProd.Click += new System.EventHandler(this.btnBorrarProd_Click);
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Location = new System.Drawing.Point(35, 47);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(40, 13);
            this.lblBorrar.TabIndex = 10;
            this.lblBorrar.Text = "Codigo";
            // 
            // txtCodBorr
            // 
            this.txtCodBorr.Location = new System.Drawing.Point(13, 63);
            this.txtCodBorr.Name = "txtCodBorr";
            this.txtCodBorr.Size = new System.Drawing.Size(88, 20);
            this.txtCodBorr.TabIndex = 9;
            // 
            // lblProdCarg
            // 
            this.lblProdCarg.AutoSize = true;
            this.lblProdCarg.Location = new System.Drawing.Point(562, 305);
            this.lblProdCarg.Name = "lblProdCarg";
            this.lblProdCarg.Size = new System.Drawing.Size(9, 13);
            this.lblProdCarg.TabIndex = 9;
            this.lblProdCarg.Text = "|";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(375, 17);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(401, 272);
            this.dgvProd.TabIndex = 7;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btnModfProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.btnCargarProd);
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
            // btnModfProd
            // 
            this.btnModfProd.Location = new System.Drawing.Point(106, 226);
            this.btnModfProd.Name = "btnModfProd";
            this.btnModfProd.Size = new System.Drawing.Size(75, 23);
            this.btnModfProd.TabIndex = 12;
            this.btnModfProd.Text = "Modificar";
            this.btnModfProd.UseVisualStyleBackColor = true;
            this.btnModfProd.Click += new System.EventHandler(this.btnModfProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "CARGAR";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(22, 176);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // btnCargarProd
            // 
            this.btnCargarProd.Location = new System.Drawing.Point(25, 226);
            this.btnCargarProd.Name = "btnCargarProd";
            this.btnCargarProd.Size = new System.Drawing.Size(75, 23);
            this.btnCargarProd.TabIndex = 1;
            this.btnCargarProd.Text = "Cargar";
            this.btnCargarProd.UseVisualStyleBackColor = true;
            this.btnCargarProd.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(18, 138);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(41, 13);
            this.lblUnidad.TabIndex = 7;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(64, 62);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(18, 65);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Codigo";
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(64, 100);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(100, 20);
            this.txtNomb.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(64, 173);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtUnid
            // 
            this.txtUnid.Location = new System.Drawing.Point(64, 135);
            this.txtUnid.Name = "txtUnid";
            this.txtUnid.Size = new System.Drawing.Size(100, 20);
            this.txtUnid.TabIndex = 3;
            // 
            // tabPageStock
            // 
            this.tabPageStock.BackColor = System.Drawing.Color.MistyRose;
            this.tabPageStock.Controls.Add(this.btnRepStock);
            this.tabPageStock.Controls.Add(this.panel4);
            this.tabPageStock.Controls.Add(this.lblStockCarg);
            this.tabPageStock.Controls.Add(this.dgvStock);
            this.tabPageStock.Controls.Add(this.panel2);
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(793, 423);
            this.tabPageStock.TabIndex = 1;
            this.tabPageStock.Text = "Stock";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnBorrarStock);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtBorrStock);
            this.panel4.Location = new System.Drawing.Point(237, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 128);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "BORRAR";
            // 
            // btnBorrarStock
            // 
            this.btnBorrarStock.Location = new System.Drawing.Point(26, 89);
            this.btnBorrarStock.Name = "btnBorrarStock";
            this.btnBorrarStock.Size = new System.Drawing.Size(64, 23);
            this.btnBorrarStock.TabIndex = 9;
            this.btnBorrarStock.Text = "Borrar";
            this.btnBorrarStock.UseVisualStyleBackColor = true;
            this.btnBorrarStock.Click += new System.EventHandler(this.btnBorrarStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            // 
            // txtBorrStock
            // 
            this.txtBorrStock.Location = new System.Drawing.Point(13, 63);
            this.txtBorrStock.Name = "txtBorrStock";
            this.txtBorrStock.Size = new System.Drawing.Size(88, 20);
            this.txtBorrStock.TabIndex = 9;
            // 
            // lblStockCarg
            // 
            this.lblStockCarg.AutoSize = true;
            this.lblStockCarg.Location = new System.Drawing.Point(580, 309);
            this.lblStockCarg.Name = "lblStockCarg";
            this.lblStockCarg.Size = new System.Drawing.Size(9, 13);
            this.lblStockCarg.TabIndex = 10;
            this.lblStockCarg.Text = "|";
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(375, 21);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(401, 272);
            this.dgvStock.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.chbCaducado);
            this.panel2.Controls.Add(this.btnModfStock);
            this.panel2.Controls.Add(this.dtpAdmit);
            this.panel2.Controls.Add(this.cbxProd);
            this.panel2.Controls.Add(this.btnCargarStock);
            this.panel2.Controls.Add(this.lblAdm);
            this.panel2.Controls.Add(this.lblCant);
            this.panel2.Controls.Add(this.lblProd);
            this.panel2.Controls.Add(this.txtCant);
            this.panel2.Location = new System.Drawing.Point(19, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 272);
            this.panel2.TabIndex = 7;
            // 
            // chbCaducado
            // 
            this.chbCaducado.AutoSize = true;
            this.chbCaducado.Location = new System.Drawing.Point(63, 153);
            this.chbCaducado.Name = "chbCaducado";
            this.chbCaducado.Size = new System.Drawing.Size(75, 17);
            this.chbCaducado.TabIndex = 13;
            this.chbCaducado.Text = "Caducado";
            this.chbCaducado.UseVisualStyleBackColor = true;
            // 
            // btnModfStock
            // 
            this.btnModfStock.Location = new System.Drawing.Point(109, 204);
            this.btnModfStock.Name = "btnModfStock";
            this.btnModfStock.Size = new System.Drawing.Size(75, 23);
            this.btnModfStock.TabIndex = 12;
            this.btnModfStock.Text = "Modificar";
            this.btnModfStock.UseVisualStyleBackColor = true;
            this.btnModfStock.Click += new System.EventHandler(this.btnModfStock_Click);
            // 
            // dtpAdmit
            // 
            this.dtpAdmit.CustomFormat = "";
            this.dtpAdmit.Location = new System.Drawing.Point(63, 115);
            this.dtpAdmit.Name = "dtpAdmit";
            this.dtpAdmit.Size = new System.Drawing.Size(100, 20);
            this.dtpAdmit.TabIndex = 11;
            // 
            // cbxProd
            // 
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(63, 39);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(121, 21);
            this.cbxProd.TabIndex = 9;
            // 
            // btnCargarStock
            // 
            this.btnCargarStock.Location = new System.Drawing.Point(13, 204);
            this.btnCargarStock.Name = "btnCargarStock";
            this.btnCargarStock.Size = new System.Drawing.Size(75, 23);
            this.btnCargarStock.TabIndex = 1;
            this.btnCargarStock.Text = "Cargar";
            this.btnCargarStock.UseVisualStyleBackColor = true;
            this.btnCargarStock.Click += new System.EventHandler(this.btnStock_Click);
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
            // btnRepStock
            // 
            this.btnRepStock.Location = new System.Drawing.Point(418, 309);
            this.btnRepStock.Name = "btnRepStock";
            this.btnRepStock.Size = new System.Drawing.Size(75, 23);
            this.btnRepStock.TabIndex = 14;
            this.btnRepStock.Text = "Reporte";
            this.btnRepStock.UseVisualStyleBackColor = true;
            this.btnRepStock.Click += new System.EventHandler(this.btnRepStock_Click);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageStock.ResumeLayout(false);
            this.tabPageStock.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Button btnCargarProd;
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
        private System.Windows.Forms.Button btnCargarStock;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Label lblStockCarg;
        private System.Windows.Forms.DateTimePicker dtpAdmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBorrarProd;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.TextBox txtCodBorr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrarStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBorrStock;
        private System.Windows.Forms.Button btnModfProd;
        private System.Windows.Forms.Button btnModfStock;
        private System.Windows.Forms.CheckBox chbCaducado;
        private System.Windows.Forms.Button btnRepProd;
        private System.Windows.Forms.Button btnRepStock;
    }
}

