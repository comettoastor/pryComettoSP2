namespace pryComettoSP2_PAG_143
{
    partial class frmMain
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
            this.mrcTipoCabaña = new System.Windows.Forms.GroupBox();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lstTipoCabaña = new System.Windows.Forms.ComboBox();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.lblTipoCabaña = new System.Windows.Forms.Label();
            this.lstCantidadPersonas = new System.Windows.Forms.ComboBox();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.mrcFormaPago = new System.Windows.Forms.GroupBox();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.mrcTitularReserva = new System.Windows.Forms.GroupBox();
            this.txtTelefonoTitular = new System.Windows.Forms.TextBox();
            this.lblTelefonoTitular = new System.Windows.Forms.Label();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.mrcTipoCabaña.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormaPago.SuspendLayout();
            this.mrcTitularReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipoCabaña
            // 
            this.mrcTipoCabaña.Controls.Add(this.lblCantidadDias);
            this.mrcTipoCabaña.Controls.Add(this.lblCantidadPersonas);
            this.mrcTipoCabaña.Controls.Add(this.lstTipoCabaña);
            this.mrcTipoCabaña.Controls.Add(this.txtCantidadDias);
            this.mrcTipoCabaña.Controls.Add(this.lblTipoCabaña);
            this.mrcTipoCabaña.Controls.Add(this.lstCantidadPersonas);
            this.mrcTipoCabaña.Location = new System.Drawing.Point(26, 12);
            this.mrcTipoCabaña.Name = "mrcTipoCabaña";
            this.mrcTipoCabaña.Size = new System.Drawing.Size(535, 82);
            this.mrcTipoCabaña.TabIndex = 0;
            this.mrcTipoCabaña.TabStop = false;
            this.mrcTipoCabaña.Text = "Tipo de cabaña";
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Enabled = false;
            this.lblCantidadDias.Location = new System.Drawing.Point(394, 37);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(30, 13);
            this.lblCantidadDias.TabIndex = 9;
            this.lblCantidadDias.Text = "Días";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Enabled = false;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(200, 37);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblCantidadPersonas.TabIndex = 8;
            this.lblCantidadPersonas.Text = "Personas";
            // 
            // lstTipoCabaña
            // 
            this.lstTipoCabaña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoCabaña.FormattingEnabled = true;
            this.lstTipoCabaña.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoCabaña.Location = new System.Drawing.Point(54, 34);
            this.lstTipoCabaña.Name = "lstTipoCabaña";
            this.lstTipoCabaña.Size = new System.Drawing.Size(95, 21);
            this.lstTipoCabaña.TabIndex = 7;
            this.lstTipoCabaña.SelectedIndexChanged += new System.EventHandler(this.lstTipoCabaña_SelectedIndexChanged);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Enabled = false;
            this.txtCantidadDias.Location = new System.Drawing.Point(430, 34);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(77, 20);
            this.txtCantidadDias.TabIndex = 3;
            this.txtCantidadDias.TextChanged += new System.EventHandler(this.txtCantidadDias_TextChanged);
            this.txtCantidadDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDias_KeyPress);
            // 
            // lblTipoCabaña
            // 
            this.lblTipoCabaña.AutoSize = true;
            this.lblTipoCabaña.Location = new System.Drawing.Point(20, 37);
            this.lblTipoCabaña.Name = "lblTipoCabaña";
            this.lblTipoCabaña.Size = new System.Drawing.Size(28, 13);
            this.lblTipoCabaña.TabIndex = 1;
            this.lblTipoCabaña.Text = "Tipo";
            // 
            // lstCantidadPersonas
            // 
            this.lstCantidadPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCantidadPersonas.Enabled = false;
            this.lstCantidadPersonas.FormattingEnabled = true;
            this.lstCantidadPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.lstCantidadPersonas.Location = new System.Drawing.Point(257, 34);
            this.lstCantidadPersonas.Name = "lstCantidadPersonas";
            this.lstCantidadPersonas.Size = new System.Drawing.Size(84, 21);
            this.lstCantidadPersonas.TabIndex = 2;
            this.lstCantidadPersonas.SelectedIndexChanged += new System.EventHandler(this.lstCantidadPersonas_SelectedIndexChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(18, 31);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 4;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(23, 31);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 5;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(467, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevision);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Enabled = false;
            this.mrcAdicionales.Location = new System.Drawing.Point(26, 100);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(235, 133);
            this.mrcAdicionales.TabIndex = 10;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(23, 91);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkTelevision.TabIndex = 7;
            this.chkTelevision.Text = "Televisión";
            this.chkTelevision.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(23, 61);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 6;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // mrcFormaPago
            // 
            this.mrcFormaPago.Controls.Add(this.lstTarjetas);
            this.mrcFormaPago.Controls.Add(this.lblTarjetas);
            this.mrcFormaPago.Controls.Add(this.optTarjeta);
            this.mrcFormaPago.Controls.Add(this.optEfectivo);
            this.mrcFormaPago.Enabled = false;
            this.mrcFormaPago.Location = new System.Drawing.Point(288, 100);
            this.mrcFormaPago.Name = "mrcFormaPago";
            this.mrcFormaPago.Size = new System.Drawing.Size(273, 133);
            this.mrcFormaPago.TabIndex = 11;
            this.mrcFormaPago.TabStop = false;
            this.mrcFormaPago.Text = "Forma de pago";
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.Enabled = false;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Items.AddRange(new object[] {
            "MasterCard",
            "VISA",
            "Naranja"});
            this.lstTarjetas.Location = new System.Drawing.Point(18, 91);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(192, 21);
            this.lstTarjetas.TabIndex = 10;
            this.lstTarjetas.SelectedIndexChanged += new System.EventHandler(this.lstTarjetas_SelectedIndexChanged);
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Enabled = false;
            this.lblTarjetas.Location = new System.Drawing.Point(15, 65);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 10;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(150, 31);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 12;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // mrcTitularReserva
            // 
            this.mrcTitularReserva.Controls.Add(this.txtTelefonoTitular);
            this.mrcTitularReserva.Controls.Add(this.lblTelefonoTitular);
            this.mrcTitularReserva.Controls.Add(this.txtNombreTitular);
            this.mrcTitularReserva.Controls.Add(this.lblNombreTitular);
            this.mrcTitularReserva.Enabled = false;
            this.mrcTitularReserva.Location = new System.Drawing.Point(26, 250);
            this.mrcTitularReserva.Name = "mrcTitularReserva";
            this.mrcTitularReserva.Size = new System.Drawing.Size(535, 125);
            this.mrcTitularReserva.TabIndex = 10;
            this.mrcTitularReserva.TabStop = false;
            this.mrcTitularReserva.Text = "Titular de la reserva";
            // 
            // txtTelefonoTitular
            // 
            this.txtTelefonoTitular.Enabled = false;
            this.txtTelefonoTitular.Location = new System.Drawing.Point(92, 66);
            this.txtTelefonoTitular.Name = "txtTelefonoTitular";
            this.txtTelefonoTitular.Size = new System.Drawing.Size(424, 20);
            this.txtTelefonoTitular.TabIndex = 9;
            this.txtTelefonoTitular.TextChanged += new System.EventHandler(this.txtTelefonoTitular_TextChanged);
            // 
            // lblTelefonoTitular
            // 
            this.lblTelefonoTitular.AutoSize = true;
            this.lblTelefonoTitular.Enabled = false;
            this.lblTelefonoTitular.Location = new System.Drawing.Point(20, 69);
            this.lblTelefonoTitular.Name = "lblTelefonoTitular";
            this.lblTelefonoTitular.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonoTitular.TabIndex = 8;
            this.lblTelefonoTitular.Text = "Teléfonos";
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(92, 38);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(424, 20);
            this.txtNombreTitular.TabIndex = 3;
            this.txtNombreTitular.TextChanged += new System.EventHandler(this.txtNombreTitular_TextChanged);
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Location = new System.Drawing.Point(20, 41);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTitular.TabIndex = 1;
            this.lblNombreTitular.Text = "Nombre";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(567, 49);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 13);
            this.lblResumen.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 445);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.mrcTitularReserva);
            this.Controls.Add(this.mrcFormaPago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTipoCabaña);
            this.Name = "frmMain";
            this.Text = "Reserva de cabañas";
            this.mrcTipoCabaña.ResumeLayout(false);
            this.mrcTipoCabaña.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormaPago.ResumeLayout(false);
            this.mrcFormaPago.PerformLayout();
            this.mrcTitularReserva.ResumeLayout(false);
            this.mrcTitularReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipoCabaña;
        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.ComboBox lstTipoCabaña;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label lblTipoCabaña;
        private System.Windows.Forms.ComboBox lstCantidadPersonas;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.GroupBox mrcFormaPago;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox mrcTitularReserva;
        private System.Windows.Forms.TextBox txtTelefonoTitular;
        private System.Windows.Forms.Label lblTelefonoTitular;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Label lblResumen;
    }
}

