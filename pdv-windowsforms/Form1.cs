using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pdv_windowsforms
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Construtor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
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

        // Ativa/destca botão clicado
        private void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                btnCloseChildForm.Visible = true;
                if (currentButton != (Button)btnSender)
                {
                    deactivateButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.changeColorBrightness(color, -0.3);

                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.changeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        //Desativa botão selecionado
        private void deactivateButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }
    }//
}
