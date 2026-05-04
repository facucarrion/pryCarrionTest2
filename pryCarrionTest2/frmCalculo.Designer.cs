namespace pryManasseroTest
{
    partial class frmCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCostoBase = new System.Windows.Forms.Label();
            this.lblNumCostoBase = new System.Windows.Forms.Label();
            this.lblCostoInstalacion = new System.Windows.Forms.Label();
            this.lblNumCostoInstalacion = new System.Windows.Forms.Label();
            this.lblNumCostoEnvio = new System.Windows.Forms.Label();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.lblNumCostoGarantia = new System.Windows.Forms.Label();
            this.lblCostoGarantia = new System.Windows.Forms.Label();
            this.lblNumCostoIva = new System.Windows.Forms.Label();
            this.lblCostoIva = new System.Windows.Forms.Label();
            this.lblNumCostoTotal = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCostoBase
            // 
            this.lblCostoBase.AutoSize = true;
            this.lblCostoBase.Location = new System.Drawing.Point(17, 45);
            this.lblCostoBase.Name = "lblCostoBase";
            this.lblCostoBase.Size = new System.Drawing.Size(61, 13);
            this.lblCostoBase.TabIndex = 0;
            this.lblCostoBase.Text = "Costo Base";
            this.lblCostoBase.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblNumCostoBase
            // 
            this.lblNumCostoBase.AutoSize = true;
            this.lblNumCostoBase.Location = new System.Drawing.Point(196, 45);
            this.lblNumCostoBase.Name = "lblNumCostoBase";
            this.lblNumCostoBase.Size = new System.Drawing.Size(40, 13);
            this.lblNumCostoBase.TabIndex = 3;
            this.lblNumCostoBase.Text = "$00.00";
            // 
            // lblCostoInstalacion
            // 
            this.lblCostoInstalacion.AutoSize = true;
            this.lblCostoInstalacion.Location = new System.Drawing.Point(17, 106);
            this.lblCostoInstalacion.Name = "lblCostoInstalacion";
            this.lblCostoInstalacion.Size = new System.Drawing.Size(88, 13);
            this.lblCostoInstalacion.TabIndex = 4;
            this.lblCostoInstalacion.Text = "Costo Instalación";
            this.lblCostoInstalacion.Click += new System.EventHandler(this.lblCostoInstalacion_Click);
            // 
            // lblNumCostoInstalacion
            // 
            this.lblNumCostoInstalacion.AutoSize = true;
            this.lblNumCostoInstalacion.Location = new System.Drawing.Point(196, 106);
            this.lblNumCostoInstalacion.Name = "lblNumCostoInstalacion";
            this.lblNumCostoInstalacion.Size = new System.Drawing.Size(40, 13);
            this.lblNumCostoInstalacion.TabIndex = 5;
            this.lblNumCostoInstalacion.Text = "$00.00";
            // 
            // lblNumCostoEnvio
            // 
            this.lblNumCostoEnvio.AutoSize = true;
            this.lblNumCostoEnvio.Location = new System.Drawing.Point(196, 74);
            this.lblNumCostoEnvio.Name = "lblNumCostoEnvio";
            this.lblNumCostoEnvio.Size = new System.Drawing.Size(40, 13);
            this.lblNumCostoEnvio.TabIndex = 7;
            this.lblNumCostoEnvio.Text = "$00.00";
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(17, 74);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(66, 13);
            this.lblCostoEnvio.TabIndex = 6;
            this.lblCostoEnvio.Text = "Costo Envío";
            // 
            // lblNumCostoGarantia
            // 
            this.lblNumCostoGarantia.AutoSize = true;
            this.lblNumCostoGarantia.Location = new System.Drawing.Point(196, 139);
            this.lblNumCostoGarantia.Name = "lblNumCostoGarantia";
            this.lblNumCostoGarantia.Size = new System.Drawing.Size(40, 13);
            this.lblNumCostoGarantia.TabIndex = 9;
            this.lblNumCostoGarantia.Text = "$00.00";
            // 
            // lblCostoGarantia
            // 
            this.lblCostoGarantia.AutoSize = true;
            this.lblCostoGarantia.Location = new System.Drawing.Point(17, 139);
            this.lblCostoGarantia.Name = "lblCostoGarantia";
            this.lblCostoGarantia.Size = new System.Drawing.Size(79, 13);
            this.lblCostoGarantia.TabIndex = 8;
            this.lblCostoGarantia.Text = "Costo Garantía";
            // 
            // lblNumCostoIva
            // 
            this.lblNumCostoIva.AutoSize = true;
            this.lblNumCostoIva.Location = new System.Drawing.Point(196, 172);
            this.lblNumCostoIva.Name = "lblNumCostoIva";
            this.lblNumCostoIva.Size = new System.Drawing.Size(40, 13);
            this.lblNumCostoIva.TabIndex = 11;
            this.lblNumCostoIva.Text = "$00.00";
            // 
            // lblCostoIva
            // 
            this.lblCostoIva.AutoSize = true;
            this.lblCostoIva.Location = new System.Drawing.Point(17, 172);
            this.lblCostoIva.Name = "lblCostoIva";
            this.lblCostoIva.Size = new System.Drawing.Size(54, 13);
            this.lblCostoIva.TabIndex = 10;
            this.lblCostoIva.Text = "Costo IVA";
            // 
            // lblNumCostoTotal
            // 
            this.lblNumCostoTotal.AutoSize = true;
            this.lblNumCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCostoTotal.Location = new System.Drawing.Point(196, 206);
            this.lblNumCostoTotal.Name = "lblNumCostoTotal";
            this.lblNumCostoTotal.Size = new System.Drawing.Size(46, 13);
            this.lblNumCostoTotal.TabIndex = 13;
            this.lblNumCostoTotal.Text = "$00.00";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(18, 206);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(61, 13);
            this.lblCostoTotal.TabIndex = 12;
            this.lblCostoTotal.Text = "Costo Total";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(15, 15);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(87, 16);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "Costo Base";
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 293);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblNumCostoTotal);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblNumCostoIva);
            this.Controls.Add(this.lblCostoIva);
            this.Controls.Add(this.lblNumCostoGarantia);
            this.Controls.Add(this.lblCostoGarantia);
            this.Controls.Add(this.lblNumCostoEnvio);
            this.Controls.Add(this.lblCostoEnvio);
            this.Controls.Add(this.lblNumCostoInstalacion);
            this.Controls.Add(this.lblCostoInstalacion);
            this.Controls.Add(this.lblNumCostoBase);
            this.Controls.Add(this.lblCostoBase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalculo";
            this.Text = "Detalle Precio";
            this.Load += new System.EventHandler(this.frmCalculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostoBase;
        private System.Windows.Forms.Label lblNumCostoBase;
        private System.Windows.Forms.Label lblCostoInstalacion;
        private System.Windows.Forms.Label lblNumCostoInstalacion;
        private System.Windows.Forms.Label lblNumCostoEnvio;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.Label lblNumCostoGarantia;
        private System.Windows.Forms.Label lblCostoGarantia;
        private System.Windows.Forms.Label lblNumCostoIva;
        private System.Windows.Forms.Label lblCostoIva;
        private System.Windows.Forms.Label lblNumCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblProducto;
    }
}