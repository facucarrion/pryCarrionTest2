using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroTest
{
    public partial class frmCalculo : Form
    {
        public frmCalculo(string producto, string varTipoProducto, List<string> lstAdicionales)
        {
            InitializeComponent();

            string varProductoRecibido = producto;
            string varTipoProductoRecibido = varTipoProducto;
            List<string> lstAdicionalesRecibidas = lstAdicionales;

            int costoBase = 0;
            double costoTotal = 0;

            if (varTipoProducto == "Equipo")
            {
                costoBase = 1000000;
            } else if (varTipoProducto == "Repuesto")
            {
                costoBase = 350000;
            }

            costoTotal = costoBase;

            foreach (var adicional in lstAdicionalesRecibidas)
            {
                if (adicional == "Envio") costoTotal += costoBase * 0.05;
                if (adicional == "Instalacion") costoTotal += costoBase * 0.15;
                if (adicional == "Garantia") costoTotal += costoTotal * 0.20;
            }

            costoTotal += costoTotal * 0.21;

            lblCosto.Text = "$" + costoTotal.ToString();
        }

        private void lblConsignas_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {

        }
    }
}
