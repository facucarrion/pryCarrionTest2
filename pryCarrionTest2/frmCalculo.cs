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

            lblProducto.Text = producto;

            lblCostoBase.Text += " " + varTipoProducto;
            lblNumCostoBase.Text = "$" + costoBase.ToString();

            costoTotal = costoBase;

            foreach (var adicional in lstAdicionalesRecibidas) 
            {
                if (adicional == "Envio") {
                    costoTotal += costoBase * 0.05;
                    lblNumCostoEnvio.Text = "$" + (costoBase * 0.05).ToString();
                }
                
                if (adicional == "Instalacion") {
                    costoTotal += costoBase * 0.15;
                    lblNumCostoInstalacion.Text = "$" + (costoBase * 0.15).ToString();
                }
            
                if (adicional == "Garantia") {
                    costoTotal += costoTotal * 0.20;
                    lblNumCostoGarantia.Text = "$" + (costoTotal * 0.20).ToString();
                }
            }

            lblNumCostoIva.Text = "$" + (costoTotal * 0.21).ToString();
            costoTotal += costoTotal * 0.21;

            lblNumCostoTotal.Text = "$" + costoTotal.ToString();
        }

        private void lblConsignas_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {

        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        private void lblCostoInstalacion_Click(object sender, EventArgs e)
        {

        }
    }
}
