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
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictboxFoto = new System.Windows.Forms.PictureBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCadFuncCargo = new System.Windows.Forms.Label();
            this.lblCadFuncEndereco = new System.Windows.Forms.Label();
            this.lblCadFuncTelefone = new System.Windows.Forms.Label();
            this.lblCadFuncCPF = new System.Windows.Forms.Label();
            this.lblCadFuncNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgridListFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(59, 69);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(176, 20);
            this.txtTelefone.TabIndex = 25;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(468, 9);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(184, 20);
            this.txtCpf.TabIndex = 24;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(577, 68);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 29;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // pictboxFoto
            // 
            this.pictboxFoto.Location = new System.Drawing.Point(659, 9);
            this.pictboxFoto.Name = "pictboxFoto";
            this.pictboxFoto.Size = new System.Drawing.Size(133, 122);
            this.pictboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictboxFoto.TabIndex = 28;
            this.pictboxFoto.TabStop = false;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(363, 68);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 26;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(56, 131);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(564, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 20);
            this.txtNome.TabIndex = 23;
            // 
            // lblCadFuncCargo
            // 
            this.lblCadFuncCargo.AutoSize = true;
            this.lblCadFuncCargo.Location = new System.Drawing.Point(322, 71);
            this.lblCadFuncCargo.Name = "lblCadFuncCargo";
            this.lblCadFuncCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCadFuncCargo.TabIndex = 22;
            this.lblCadFuncCargo.Text = "Cargo";
            // 
            // lblCadFuncEndereco
            // 
            this.lblCadFuncEndereco.AutoSize = true;
            this.lblCadFuncEndereco.Location = new System.Drawing.Point(4, 134);
            this.lblCadFuncEndereco.Name = "lblCadFuncEndereco";
            this.lblCadFuncEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblCadFuncEndereco.TabIndex = 21;
            this.lblCadFuncEndereco.Text = "Endereço";
            // 
            // lblCadFuncTelefone
            // 
            this.lblCadFuncTelefone.AutoSize = true;
            this.lblCadFuncTelefone.Location = new System.Drawing.Point(4, 72);
            this.lblCadFuncTelefone.Name = "lblCadFuncTelefone";
            this.lblCadFuncTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblCadFuncTelefone.TabIndex = 20;
            this.lblCadFuncTelefone.Text = "Telefone";
            // 
            // lblCadFuncCPF
            // 
            this.lblCadFuncCPF.AutoSize = true;
            this.lblCadFuncCPF.Location = new System.Drawing.Point(435, 12);
            this.lblCadFuncCPF.Name = "lblCadFuncCPF";
            this.lblCadFuncCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCadFuncCPF.TabIndex = 19;
            this.lblCadFuncCPF.Text = "CPF";
            // 
            // lblCadFuncNome
            // 
            this.lblCadFuncNome.AutoSize = true;
            this.lblCadFuncNome.Location = new System.Drawing.Point(4, 12);
            this.lblCadFuncNome.Name = "lblCadFuncNome";
            this.lblCadFuncNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadFuncNome.TabIndex = 18;
            this.lblCadFuncNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(418, 498);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(325, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(138, 498);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(42, 498);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtgridListFuncionarios
            // 
            this.dtgridListFuncionarios.AllowUserToAddRows = false;
            this.dtgridListFuncionarios.AllowUserToDeleteRows = false;
            this.dtgridListFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridListFuncionarios.Location = new System.Drawing.Point(7, 177);
            this.dtgridListFuncionarios.Name = "dtgridListFuncionarios";
            this.dtgridListFuncionarios.ReadOnly = true;
            this.dtgridListFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridListFuncionarios.Size = new System.Drawing.Size(785, 295);
            this.dtgridListFuncionarios.TabIndex = 30;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgridListFuncionarios);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictboxFoto);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCadFuncCargo);
            this.Controls.Add(this.lblCadFuncEndereco);
            this.Controls.Add(this.lblCadFuncTelefone);
            this.Controls.Add(this.lblCadFuncCPF);
            this.Controls.Add(this.lblCadFuncNome);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictboxFoto;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCadFuncCargo;
        private System.Windows.Forms.Label lblCadFuncEndereco;
        private System.Windows.Forms.Label lblCadFuncTelefone;
        private System.Windows.Forms.Label lblCadFuncCPF;
        private System.Windows.Forms.Label lblCadFuncNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgridListFuncionarios;
    }
}