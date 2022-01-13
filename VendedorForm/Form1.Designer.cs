namespace VendedorForm
{
    partial class Form1
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
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCambiarComision = new System.Windows.Forms.Button();
            this.btnCrearVendedor2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(12, 64);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(119, 58);
            this.btnCrearVendedor.TabIndex = 0;
            this.btnCrearVendedor.Text = "Crear vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 153);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCambiarComision
            // 
            this.btnCambiarComision.Location = new System.Drawing.Point(335, 334);
            this.btnCambiarComision.Name = "btnCambiarComision";
            this.btnCambiarComision.Size = new System.Drawing.Size(119, 58);
            this.btnCambiarComision.TabIndex = 2;
            this.btnCambiarComision.Text = "Cambiar Comision";
            this.btnCambiarComision.UseVisualStyleBackColor = true;
            this.btnCambiarComision.Click += new System.EventHandler(this.btnCambiarComision_Click);
            // 
            // btnCrearVendedor2
            // 
            this.btnCrearVendedor2.Location = new System.Drawing.Point(197, 64);
            this.btnCrearVendedor2.Name = "btnCrearVendedor2";
            this.btnCrearVendedor2.Size = new System.Drawing.Size(119, 58);
            this.btnCrearVendedor2.TabIndex = 3;
            this.btnCrearVendedor2.Text = "Crear vendedor";
            this.btnCrearVendedor2.UseVisualStyleBackColor = true;
            this.btnCrearVendedor2.Click += new System.EventHandler(this.btnCrearVendedor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor2);
            this.Controls.Add(this.btnCambiarComision);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCrearVendedor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVendedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCambiarComision;
        private System.Windows.Forms.Button btnCrearVendedor2;
    }
}

