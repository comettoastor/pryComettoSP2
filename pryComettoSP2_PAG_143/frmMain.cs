using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoSP2_PAG_143
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lstTipoCabaña_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoCabaña.SelectedIndex != -1)
            {
                lblCantidadPersonas.Enabled = true;
                lstCantidadPersonas.Enabled = true;
            }
        }

        private void lstCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCantidadPersonas.SelectedIndex != -1)
            {
                lblCantidadDias.Enabled = true;
                txtCantidadDias.Enabled = true;
            }
        }

        private void txtCantidadDias_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadDias.Text!="")
            {
                mrcAdicionales.Enabled = true;
                mrcFormaPago.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcFormaPago.Enabled = false;
            }
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTarjetas.SelectedIndex != -1)
            {
                mrcTitularReserva.Enabled = true;
            }
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                mrcTitularReserva.Enabled = true;
                lblTarjetas.Enabled = true;
                lstTarjetas.Enabled = true;
            }
            else
            {
                mrcTitularReserva.Enabled = false;
                lblTarjetas.Enabled = false;
                lstTarjetas.Enabled = false;
            }
        }

        private void txtNombreTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreTitular.Text != "")
            {
                lblTelefonoTitular.Enabled = true;
                txtTelefonoTitular.Enabled = true;
            }
            else
            {
                lblTelefonoTitular.Enabled = false;
                txtTelefonoTitular.Enabled = false;
            }
        }

        private void txtTelefonoTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoTitular.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked == true)
            {
                mrcTitularReserva.Enabled = true;
            }
            else
            {
                mrcTitularReserva.Enabled = false;
            }
        }

        private void txtCantidadDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblResumen.Text = "Tipo de cabaña: " + lstTipoCabaña.Text + "\nCantidad de personas: " + lstCantidadPersonas.Text;
        }
    }
}
