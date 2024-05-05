namespace pdv_windowsforms.cadastro
{
    partial class FrmCliente
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
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbInadimplente = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblInadimplente = new System.Windows.Forms.Label();
            this.lblCadFuncEndereco = new System.Windows.Forms.Label();
            this.lblCadFuncTelefone = new System.Windows.Forms.Label();
            this.lblCadFuncCPF = new System.Windows.Forms.Label();
            this.lblCadFuncNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgridListClientes = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorAberto = new System.Windows.Forms.TextBox();
            this.lblValorAberto = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictboxFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxStatusCliente = new System.Windows.Forms.GroupBox();
            this.radioDesbloqueado = new System.Windows.Forms.RadioButton();
            this.radioBLoqueado = new System.Windows.Forms.RadioButton();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.lblBuscarPorNome = new System.Windows.Forms.Label();
            this.txtBuscarPorCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarPorCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).BeginInit();
            this.groupBoxStatusCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(648, 47);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(86, 20);
            this.txtTelefone.TabIndex = 25;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(503, 47);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(84, 20);
            this.txtCpf.TabIndex = 24;
            // 
            // cbInadimplente
            // 
            this.cbInadimplente.FormattingEnabled = true;
            this.cbInadimplente.Location = new System.Drawing.Point(613, 109);
            this.cbInadimplente.Name = "cbInadimplente";
            this.cbInadimplente.Size = new System.Drawing.Size(121, 21);
            this.cbInadimplente.TabIndex = 26;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(59, 83);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(398, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 23;
            // 
            // lblInadimplente
            // 
            this.lblInadimplente.AutoSize = true;
            this.lblInadimplente.Location = new System.Drawing.Point(542, 115);
            this.lblInadimplente.Name = "lblInadimplente";
            this.lblInadimplente.Size = new System.Drawing.Size(67, 13);
            this.lblInadimplente.TabIndex = 22;
            this.lblInadimplente.Text = "Inadimplente";
            // 
            // lblCadFuncEndereco
            // 
            this.lblCadFuncEndereco.AutoSize = true;
            this.lblCadFuncEndereco.Location = new System.Drawing.Point(7, 86);
            this.lblCadFuncEndereco.Name = "lblCadFuncEndereco";
            this.lblCadFuncEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblCadFuncEndereco.TabIndex = 21;
            this.lblCadFuncEndereco.Text = "Endereço";
            // 
            // lblCadFuncTelefone
            // 
            this.lblCadFuncTelefone.AutoSize = true;
            this.lblCadFuncTelefone.Location = new System.Drawing.Point(593, 50);
            this.lblCadFuncTelefone.Name = "lblCadFuncTelefone";
            this.lblCadFuncTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblCadFuncTelefone.TabIndex = 20;
            this.lblCadFuncTelefone.Text = "Telefone";
            // 
            // lblCadFuncCPF
            // 
            this.lblCadFuncCPF.AutoSize = true;
            this.lblCadFuncCPF.Location = new System.Drawing.Point(470, 50);
            this.lblCadFuncCPF.Name = "lblCadFuncCPF";
            this.lblCadFuncCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCadFuncCPF.TabIndex = 19;
            this.lblCadFuncCPF.Text = "CPF";
            // 
            // lblCadFuncNome
            // 
            this.lblCadFuncNome.AutoSize = true;
            this.lblCadFuncNome.Location = new System.Drawing.Point(7, 44);
            this.lblCadFuncNome.Name = "lblCadFuncNome";
            this.lblCadFuncNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadFuncNome.TabIndex = 18;
            this.lblCadFuncNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 544);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(418, 544);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(325, 544);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(138, 544);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(42, 544);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtgridListClientes
            // 
            this.dtgridListClientes.AllowUserToAddRows = false;
            this.dtgridListClientes.AllowUserToDeleteRows = false;
            this.dtgridListClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgridListClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridListClientes.Location = new System.Drawing.Point(7, 223);
            this.dtgridListClientes.Name = "dtgridListClientes";
            this.dtgridListClientes.ReadOnly = true;
            this.dtgridListClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridListClientes.Size = new System.Drawing.Size(1049, 295);
            this.dtgridListClientes.TabIndex = 30;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(334, 47);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(123, 20);
            this.txtCod.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // txtValorAberto
            // 
            this.txtValorAberto.Location = new System.Drawing.Point(537, 83);
            this.txtValorAberto.Name = "txtValorAberto";
            this.txtValorAberto.Size = new System.Drawing.Size(197, 20);
            this.txtValorAberto.TabIndex = 39;
            // 
            // lblValorAberto
            // 
            this.lblValorAberto.AutoSize = true;
            this.lblValorAberto.Location = new System.Drawing.Point(466, 83);
            this.lblValorAberto.Name = "lblValorAberto";
            this.lblValorAberto.Size = new System.Drawing.Size(65, 13);
            this.lblValorAberto.TabIndex = 38;
            this.lblValorAberto.Text = "Valor Aberto";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(398, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "E-Mail";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(842, 184);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 43;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // pictboxFoto
            // 
            this.pictboxFoto.Location = new System.Drawing.Point(923, 44);
            this.pictboxFoto.Name = "pictboxFoto";
            this.pictboxFoto.Size = new System.Drawing.Size(133, 162);
            this.pictboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictboxFoto.TabIndex = 42;
            this.pictboxFoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 44;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatusCliente
            // 
            this.groupBoxStatusCliente.Controls.Add(this.radioDesbloqueado);
            this.groupBoxStatusCliente.Controls.Add(this.radioBLoqueado);
            this.groupBoxStatusCliente.Location = new System.Drawing.Point(740, 47);
            this.groupBoxStatusCliente.Name = "groupBoxStatusCliente";
            this.groupBoxStatusCliente.Size = new System.Drawing.Size(177, 100);
            this.groupBoxStatusCliente.TabIndex = 45;
            this.groupBoxStatusCliente.TabStop = false;
            this.groupBoxStatusCliente.Text = "Status do cliente?";
            // 
            // radioDesbloqueado
            // 
            this.radioDesbloqueado.AutoSize = true;
            this.radioDesbloqueado.Location = new System.Drawing.Point(7, 65);
            this.radioDesbloqueado.Name = "radioDesbloqueado";
            this.radioDesbloqueado.Size = new System.Drawing.Size(76, 17);
            this.radioDesbloqueado.TabIndex = 1;
            this.radioDesbloqueado.TabStop = true;
            this.radioDesbloqueado.Text = "Bloqueado";
            this.radioDesbloqueado.UseVisualStyleBackColor = true;
            // 
            // radioBLoqueado
            // 
            this.radioBLoqueado.AutoSize = true;
            this.radioBLoqueado.Location = new System.Drawing.Point(7, 31);
            this.radioBLoqueado.Name = "radioBLoqueado";
            this.radioBLoqueado.Size = new System.Drawing.Size(94, 17);
            this.radioBLoqueado.TabIndex = 0;
            this.radioBLoqueado.TabStop = true;
            this.radioBLoqueado.Text = "Desbloqueado";
            this.radioBLoqueado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(95, 12);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(362, 20);
            this.txtBuscarNome.TabIndex = 49;
            // 
            // lblBuscarPorNome
            // 
            this.lblBuscarPorNome.AutoSize = true;
            this.lblBuscarPorNome.Location = new System.Drawing.Point(7, 15);
            this.lblBuscarPorNome.Name = "lblBuscarPorNome";
            this.lblBuscarPorNome.Size = new System.Drawing.Size(89, 13);
            this.lblBuscarPorNome.TabIndex = 48;
            this.lblBuscarPorNome.Text = "Buscar por Nome";
            // 
            // txtBuscarPorCpf
            // 
            this.txtBuscarPorCpf.Location = new System.Drawing.Point(563, 12);
            this.txtBuscarPorCpf.Mask = "000.000.000-00";
            this.txtBuscarPorCpf.Name = "txtBuscarPorCpf";
            this.txtBuscarPorCpf.Size = new System.Drawing.Size(84, 20);
            this.txtBuscarPorCpf.TabIndex = 47;
            // 
            // lblBuscarPorCpf
            // 
            this.lblBuscarPorCpf.AutoSize = true;
            this.lblBuscarPorCpf.Location = new System.Drawing.Point(466, 15);
            this.lblBuscarPorCpf.Name = "lblBuscarPorCpf";
            this.lblBuscarPorCpf.Size = new System.Drawing.Size(81, 13);
            this.lblBuscarPorCpf.TabIndex = 46;
            this.lblBuscarPorCpf.Text = "Buscar por CPF";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1068, 577);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.lblBuscarPorNome);
            this.Controls.Add(this.txtBuscarPorCpf);
            this.Controls.Add(this.lblBuscarPorCpf);
            this.Controls.Add(this.groupBoxStatusCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictboxFoto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtValorAberto);
            this.Controls.Add(this.lblValorAberto);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgridListClientes);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cbInadimplente);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblInadimplente);
            this.Controls.Add(this.lblCadFuncEndereco);
            this.Controls.Add(this.lblCadFuncTelefone);
            this.Controls.Add(this.lblCadFuncCPF);
            this.Controls.Add(this.lblCadFuncNome);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).EndInit();
            this.groupBoxStatusCliente.ResumeLayout(false);
            this.groupBoxStatusCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ComboBox cbInadimplente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblInadimplente;
        private System.Windows.Forms.Label lblCadFuncEndereco;
        private System.Windows.Forms.Label lblCadFuncTelefone;
        private System.Windows.Forms.Label lblCadFuncCPF;
        private System.Windows.Forms.Label lblCadFuncNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgridListClientes;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorAberto;
        private System.Windows.Forms.Label lblValorAberto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictboxFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxStatusCliente;
        private System.Windows.Forms.RadioButton radioDesbloqueado;
        private System.Windows.Forms.RadioButton radioBLoqueado;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label lblBuscarPorNome;
        private System.Windows.Forms.MaskedTextBox txtBuscarPorCpf;
        private System.Windows.Forms.Label lblBuscarPorCpf;
    }
}