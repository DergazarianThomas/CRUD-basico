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
            this.tabProdStock = new System.Windows.Forms.TabControl();
            this.tabPageProd = new System.Windows.Forms.TabPage();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabProdStock.SuspendLayout();
            this.tabPageProd.SuspendLayout();
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
            this.tabPageProd.Controls.Add(this.button1);
            this.tabPageProd.Controls.Add(this.textBox1);
            this.tabPageProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageProd.Name = "tabPageProd";
            this.tabPageProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProd.Size = new System.Drawing.Size(793, 423);
            this.tabPageProd.TabIndex = 0;
            this.tabPageProd.Text = "Productos";
            this.tabPageProd.UseVisualStyleBackColor = true;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(793, 423);
            this.tabPageStock.TabIndex = 1;
            this.tabPageStock.Text = "Stock";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProdStock;
        private System.Windows.Forms.TabPage tabPageProd;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

