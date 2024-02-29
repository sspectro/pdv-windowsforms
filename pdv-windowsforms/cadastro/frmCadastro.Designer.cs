namespace pdv_windowsforms.cadastro
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lblCadFuncNome = new System.Windows.Forms.Label();
            this.lblCadFuncCPF = new System.Windows.Forms.Label();
            this.lblCadFuncTelefone = new System.Windows.Forms.Label();
            this.lblCadFuncEndereco = new System.Windows.Forms.Label();
            this.lblCadFuncCargo = new System.Windows.Forms.Label();
            this.lblCadFuncFoto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.cmboxCargo = new System.Windows.Forms.ComboBox();
            this.pictboxFoto = new System.Windows.Forms.PictureBox();
            this.dtgridListFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadFuncNome
            // 
            this.lblCadFuncNome.AutoSize = true;
            this.lblCadFuncNome.Location = new System.Drawing.Point(21, 21);
            this.lblCadFuncNome.Name = "lblCadFuncNome";
            this.lblCadFuncNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadFuncNome.TabIndex = 0;
            this.lblCadFuncNome.Text = "Nome";
            // 
            // lblCadFuncCPF
            // 
            this.lblCadFuncCPF.AutoSize = true;
            this.lblCadFuncCPF.Location = new System.Drawing.Point(475, 21);
            this.lblCadFuncCPF.Name = "lblCadFuncCPF";
            this.lblCadFuncCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCadFuncCPF.TabIndex = 1;
            this.lblCadFuncCPF.Text = "CPF";
            // 
            // lblCadFuncTelefone
            // 
            this.lblCadFuncTelefone.AutoSize = true;
            this.lblCadFuncTelefone.Location = new System.Drawing.Point(21, 81);
            this.lblCadFuncTelefone.Name = "lblCadFuncTelefone";
            this.lblCadFuncTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblCadFuncTelefone.TabIndex = 2;
            this.lblCadFuncTelefone.Text = "Telefone";
            // 
            // lblCadFuncEndereco
            // 
            this.lblCadFuncEndereco.AutoSize = true;
            this.lblCadFuncEndereco.Location = new System.Drawing.Point(21, 143);
            this.lblCadFuncEndereco.Name = "lblCadFuncEndereco";
            this.lblCadFuncEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblCadFuncEndereco.TabIndex = 3;
            this.lblCadFuncEndereco.Text = "Endereço";
            // 
            // lblCadFuncCargo
            // 
            this.lblCadFuncCargo.AutoSize = true;
            this.lblCadFuncCargo.Location = new System.Drawing.Point(475, 106);
            this.lblCadFuncCargo.Name = "lblCadFuncCargo";
            this.lblCadFuncCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCadFuncCargo.TabIndex = 4;
            this.lblCadFuncCargo.Text = "Cargo";
            // 
            // lblCadFuncFoto
            // 
            this.lblCadFuncFoto.AutoSize = true;
            this.lblCadFuncFoto.Location = new System.Drawing.Point(641, 21);
            this.lblCadFuncFoto.Name = "lblCadFuncFoto";
            this.lblCadFuncFoto.Size = new System.Drawing.Size(28, 13);
            this.lblCadFuncFoto.TabIndex = 5;
            this.lblCadFuncFoto.Text = "Foto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(73, 81);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(169, 20);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(73, 140);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(364, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(508, 18);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 20);
            this.txtCPF.TabIndex = 9;
            // 
            // cmboxCargo
            // 
            this.cmboxCargo.FormattingEnabled = true;
            this.cmboxCargo.Location = new System.Drawing.Point(516, 103);
            this.cmboxCargo.Name = "cmboxCargo";
            this.cmboxCargo.Size = new System.Drawing.Size(121, 21);
            this.cmboxCargo.TabIndex = 10;
            // 
            // pictboxFoto
            // 
            this.pictboxFoto.Location = new System.Drawing.Point(676, 18);
            this.pictboxFoto.Name = "pictboxFoto";
            this.pictboxFoto.Size = new System.Drawing.Size(119, 83);
            this.pictboxFoto.TabIndex = 11;
            this.pictboxFoto.TabStop = false;
            // 
            // dtgridListFuncionarios
            // 
            this.dtgridListFuncionarios.AllowUserToAddRows = false;
            this.dtgridListFuncionarios.AllowUserToDeleteRows = false;
            this.dtgridListFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridListFuncionarios.Location = new System.Drawing.Point(24, 178);
            this.dtgridListFuncionarios.Name = "dtgridListFuncionarios";
            this.dtgridListFuncionarios.ReadOnly = true;
            this.dtgridListFuncionarios.Size = new System.Drawing.Size(771, 295);
            this.dtgridListFuncionarios.TabIndex = 12;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 485);
            this.Controls.Add(this.dtgridListFuncionarios);
            this.Controls.Add(this.pictboxFoto);
            this.Controls.Add(this.cmboxCargo);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCadFuncFoto);
            this.Controls.Add(this.lblCadFuncCargo);
            this.Controls.Add(this.lblCadFuncEndereco);
            this.Controls.Add(this.lblCadFuncTelefone);
            this.Controls.Add(this.lblCadFuncCPF);
            this.Controls.Add(this.lblCadFuncNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.Text = "Cadastro Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictboxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridListFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadFuncNome;
        private System.Windows.Forms.Label lblCadFuncCPF;
        private System.Windows.Forms.Label lblCadFuncTelefone;
        private System.Windows.Forms.Label lblCadFuncEndereco;
        private System.Windows.Forms.Label lblCadFuncCargo;
        private System.Windows.Forms.Label lblCadFuncFoto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.ComboBox cmboxCargo;
        private System.Windows.Forms.PictureBox pictboxFoto;
        private System.Windows.Forms.DataGridView dtgridListFuncionarios;
    }
}