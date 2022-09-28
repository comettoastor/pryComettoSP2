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
            if (lstTipoCabaña.SelectedItem == "A")
            {
                lstCantidadPersonas.Items.Clear();
                lstCantidadPersonas.Items.Add(1);
                lstCantidadPersonas.Items.Add(2);
                lstCantidadPersonas.Items.Add(3);
                lstCantidadPersonas.Items.Add(4);
            }
            if (lstTipoCabaña.SelectedItem == "B")
            {
                lstCantidadPersonas.Items.Clear();
                lstCantidadPersonas.Items.Add(1);
                lstCantidadPersonas.Items.Add(2);
                lstCantidadPersonas.Items.Add(3);
                lstCantidadPersonas.Items.Add(4);
                lstCantidadPersonas.Items.Add(5);
                lstCantidadPersonas.Items.Add(6);
                lstCantidadPersonas.Items.Add(7);
                lstCantidadPersonas.Items.Add(8);
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
            if (txtCantidadDias.Text != "")
            {
                mrcAdicionales.Enabled = true;
                mrcFormaPago.Enabled = true;
                if (lstTarjetas.SelectedIndex != -1)
                {
                    mrcTitularReserva.Enabled = true;
                }
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcFormaPago.Enabled = false;
                mrcTitularReserva.Enabled = false;
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
                lblTarjetas.Enabled = true;
                lstTarjetas.Enabled = true;
            }
            else
            {
                lblTarjetas.Enabled = false;
                lstTarjetas.Enabled = false;
            }
            if (optTarjeta.Checked == true && lstTarjetas.SelectedIndex != -1)
            {
                mrcTitularReserva.Enabled = true;
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
                MessageBox.Show("Ingrese únicamente números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstTipoCabaña.SelectedIndex != -1 && lstCantidadPersonas.SelectedIndex != -1 && txtCantidadDias.Text !="" && (lstTarjetas.SelectedIndex!= -1 || optEfectivo.Checked == true) && txtNombreTitular.Text != "" && txtTelefonoTitular.Text != "")
            {
                lblResumen.Text = "Tipo de cabaña: " + lstTipoCabaña.Text;
                lblResumen.Text += "\nCantidad de personas: " + lstCantidadPersonas.Text;
                lblResumen.Text += "\nDías: " + txtCantidadDias.Text;
                lblResumen.Text += "\nAdicionales:";
                
                if (chkCocina.Checked == true)
                {
                    lblResumen.Text += "\n- Cocina: Si";
                }
                else
                {
                    lblResumen.Text += "\n- Cocina: No";
                }
                if (chkHeladera.Checked == true)
                {
                    lblResumen.Text += "\n- Heladera: Si";
                }
                else
                {
                    lblResumen.Text += "\n- Heladera: No";
                }
                if (chkTelevision.Checked == true)
                {
                    lblResumen.Text += "\n- Televisión: Si";
                }
                else
                {
                    lblResumen.Text += "\n- Televisión: No";
                }
                if (optEfectivo.Checked == true)
                {
                    lblResumen.Text += "\nForma de pago: Efectivo";
                }
                else
                {
                    lblResumen.Text += "\nForma de pago: Tarjeta\n- Tarjeta: " + lstTarjetas.SelectedItem;
                }
                lblResumen.Text += "\nNombre: " + txtNombreTitular.Text + "\nTeléfono: " + txtTelefonoTitular.Text;
                MessageBox.Show("Datos Ingresados Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefonoTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Cargar Datos Iniciales de los controles de mrcTipoCabaña según el PDF

            //lstTipoCabaña.SelectedIndex = 0;
            //lstCantidadPersonas.SelectedIndex = 0;
            //txtCantidadDias.Text = "1";
        }
    }
}
