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
                chkCocina.Enabled = true;
                chkHeladera.Enabled = true;
                chkTelevision.Enabled = true;
                mrcFormaPago.Enabled = true;
                optEfectivo.Enabled = true;
                optTarjeta.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                chkCocina.Enabled = false;
                chkHeladera.Enabled = false;
                chkTelevision.Enabled = false;
                mrcFormaPago.Enabled = false;
                optEfectivo.Enabled = false;
                optTarjeta.Enabled = false;
            }
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTarjetas.SelectedIndex != -1)
            {
                mrcTitularReserva.Enabled = true;
                lblNombreTitular.Enabled = true;
                txtNombreTitular.Enabled = true;
            }
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lblTarjetas.Enabled = true;
                lstTarjetas.Enabled = true;
            }
            else
            {
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
    }
}
