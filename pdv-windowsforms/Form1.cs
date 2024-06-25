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
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Construtor
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
            cadastro.FrmFuncionario frm=new cadastro.FrmFuncionario();

            frm.ShowDialog();
        }
        private void MenuCadCargos_Click(object sender, EventArgs e)
        {
            cadastro.FrmCargo frmCargo = new cadastro.FrmCargo();
            frmCargo.ShowDialog();
        }

        private void MenuCadClientes_Click(object sender, EventArgs e)
        {
            cadastro.FrmCliente frmCliente = new cadastro.FrmCliente();
            frmCliente.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Método para selecionar uma cor aleatória para o tema da lista de cores (pode usar uma cor se quiser)
        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

    }//
}
