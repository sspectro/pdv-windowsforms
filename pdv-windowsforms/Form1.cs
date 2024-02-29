using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv_windowsforms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSairPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCadFuncionario_Click(object sender, EventArgs e)
        {
            cadastro.FrmCadastro frm=new cadastro.FrmCadastro();

            frm.ShowDialog();
        }
    }
}
