namespace pryManasseroTest
{
    partial class frmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lbRegistroIG = new System.Windows.Forms.Label();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grpAdiconal = new System.Windows.Forms.GroupBox();
            this.cbEnvío = new System.Windows.Forms.CheckBox();
            this.cbInstalación = new System.Windows.Forms.CheckBox();
            this.cbGarantía = new System.Windows.Forms.CheckBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbEquipo = new System.Windows.Forms.RadioButton();
            this.rdbRepuesto = new System.Windows.Forms.RadioButton();
            this.cmbProductoRegistrado = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpAdiconal.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(22, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Navy;
            this.btnRegistrar.Location = new System.Drawing.Point(392, 20);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(214, 95);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(180, 28);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de productos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Navy;
            this.btnSiguiente.Location = new System.Drawing.Point(405, 89);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(130, 38);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.lbRegistroIG);
            this.pPrincipal.Controls.Add(this.btnSiguiente);
            this.pPrincipal.Controls.Add(this.cmbProducto);
            this.pPrincipal.Controls.Add(this.btnRegistrar);
            this.pPrincipal.Controls.Add(this.lblNombre);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.txtNombre);
            this.pPrincipal.ForeColor = System.Drawing.Color.Navy;
            this.pPrincipal.Location = new System.Drawing.Point(22, 42);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(544, 166);
            this.pPrincipal.TabIndex = 6;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbRegistroIG
            // 
            this.lbRegistroIG.AutoSize = true;
            this.lbRegistroIG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroIG.Location = new System.Drawing.Point(28, 245);
            this.lbRegistroIG.Name = "lbRegistroIG";
            this.lbRegistroIG.Size = new System.Drawing.Size(20, 25);
            this.lbRegistroIG.TabIndex = 6;
            this.lbRegistroIG.Text = "-";
            // 
            // grpOpciones
            // 
            this.grpOpciones.BackColor = System.Drawing.Color.DarkGray;
            this.grpOpciones.Controls.Add(this.btnFinalizar);
            this.grpOpciones.Controls.Add(this.grpAdiconal);
            this.grpOpciones.Controls.Add(this.grpTipo);
            this.grpOpciones.Controls.Add(this.cmbProductoRegistrado);
            this.grpOpciones.Controls.Add(this.lblProducto);
            this.grpOpciones.ForeColor = System.Drawing.Color.Navy;
            this.grpOpciones.Location = new System.Drawing.Point(22, 42);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(541, 462);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "-";
            this.grpOpciones.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(354, 411);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(122, 34);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grpAdiconal
            // 
            this.grpAdiconal.BackColor = System.Drawing.Color.White;
            this.grpAdiconal.Controls.Add(this.cbEnvío);
            this.grpAdiconal.Controls.Add(this.cbInstalación);
            this.grpAdiconal.Controls.Add(this.cbGarantía);
            this.grpAdiconal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdiconal.Location = new System.Drawing.Point(84, 252);
            this.grpAdiconal.Name = "grpAdiconal";
            this.grpAdiconal.Size = new System.Drawing.Size(392, 140);
            this.grpAdiconal.TabIndex = 10;
            this.grpAdiconal.TabStop = false;
            this.grpAdiconal.Text = "Adicional";
            // 
            // cbEnvío
            // 
            this.cbEnvío.AutoSize = true;
            this.cbEnvío.BackColor = System.Drawing.Color.White;
            this.cbEnvío.Location = new System.Drawing.Point(20, 83);
            this.cbEnvío.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEnvío.Name = "cbEnvío";
            this.cbEnvío.Size = new System.Drawing.Size(87, 29);
            this.cbEnvío.TabIndex = 11;
            this.cbEnvío.Text = "Envío";
            this.cbEnvío.UseVisualStyleBackColor = false;
            // 
            // cbInstalación
            // 
            this.cbInstalación.AutoSize = true;
            this.cbInstalación.BackColor = System.Drawing.Color.White;
            this.cbInstalación.Location = new System.Drawing.Point(20, 42);
            this.cbInstalación.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInstalación.Name = "cbInstalación";
            this.cbInstalación.Size = new System.Drawing.Size(135, 29);
            this.cbInstalación.TabIndex = 10;
            this.cbInstalación.Text = "Instalación";
            this.cbInstalación.UseVisualStyleBackColor = false;
            this.cbInstalación.CheckedChanged += new System.EventHandler(this.cbInstalación_CheckedChanged);
            // 
            // cbGarantía
            // 
            this.cbGarantía.AutoSize = true;
            this.cbGarantía.BackColor = System.Drawing.Color.White;
            this.cbGarantía.ForeColor = System.Drawing.Color.Navy;
            this.cbGarantía.Location = new System.Drawing.Point(206, 42);
            this.cbGarantía.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGarantía.Name = "cbGarantía";
            this.cbGarantía.Size = new System.Drawing.Size(114, 29);
            this.cbGarantía.TabIndex = 9;
            this.cbGarantía.Text = "Garantía";
            this.cbGarantía.UseVisualStyleBackColor = false;
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.White;
            this.grpTipo.Controls.Add(this.rdbEquipo);
            this.grpTipo.Controls.Add(this.rdbRepuesto);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(84, 123);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(386, 100);
            this.grpTipo.TabIndex = 9;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbEquipo
            // 
            this.rdbEquipo.AutoSize = true;
            this.rdbEquipo.BackColor = System.Drawing.Color.White;
            this.rdbEquipo.Location = new System.Drawing.Point(206, 42);
            this.rdbEquipo.Name = "rdbEquipo";
            this.rdbEquipo.Size = new System.Drawing.Size(100, 29);
            this.rdbEquipo.TabIndex = 2;
            this.rdbEquipo.TabStop = true;
            this.rdbEquipo.Text = "Equipo";
            this.rdbEquipo.UseVisualStyleBackColor = false;
            // 
            // rdbRepuesto
            // 
            this.rdbRepuesto.AutoSize = true;
            this.rdbRepuesto.BackColor = System.Drawing.Color.White;
            this.rdbRepuesto.Location = new System.Drawing.Point(49, 42);
            this.rdbRepuesto.Name = "rdbRepuesto";
            this.rdbRepuesto.Size = new System.Drawing.Size(122, 29);
            this.rdbRepuesto.TabIndex = 7;
            this.rdbRepuesto.TabStop = true;
            this.rdbRepuesto.Text = "Repuesto";
            this.rdbRepuesto.UseVisualStyleBackColor = false;
            // 
            // cmbProductoRegistrado
            // 
            this.cmbProductoRegistrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductoRegistrado.FormattingEnabled = true;
            this.cmbProductoRegistrado.Location = new System.Drawing.Point(222, 50);
            this.cmbProductoRegistrado.Name = "cmbProductoRegistrado";
            this.cmbProductoRegistrado.Size = new System.Drawing.Size(140, 28);
            this.cmbProductoRegistrado.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblProducto.Location = new System.Drawing.Point(79, 52);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(96, 25);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(588, 522);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.pPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Productos";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpAdiconal.ResumeLayout(false);
            this.grpAdiconal.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbRepuesto;
        private System.Windows.Forms.ComboBox cmbProductoRegistrado;
        private System.Windows.Forms.GroupBox grpAdiconal;
        private System.Windows.Forms.RadioButton rdbEquipo;
        private System.Windows.Forms.Label lbRegistroIG;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox cbGarantía;
        private System.Windows.Forms.CheckBox cbEnvío;
        private System.Windows.Forms.CheckBox cbInstalación;
    }
}