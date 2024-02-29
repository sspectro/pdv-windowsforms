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
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCadFuncFoto);
            this.Controls.Add(this.lblCadFuncCargo);
            this.Controls.Add(this.lblCadFuncEndereco);
            this.Controls.Add(this.lblCadFuncTelefone);
            this.Controls.Add(this.lblCadFuncCPF);
            this.Controls.Add(this.lblCadFuncNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.Text = "Cadastro Funcionário";
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
    }
}