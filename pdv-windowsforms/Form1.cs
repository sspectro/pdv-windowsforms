using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

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

        //Abre form filho
        private void openChildForm(Form childForm, object btnSender)
        {
            //verifica se tem um form em active form. Caso tenha, então, fecha para abrir outro
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        //Função para retornar o Form1 a forma inicial
        private void reset()
        {
            deactivateButton();
            lblTitle.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(0, 156, 136);
            //39; 39; 58
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            btnCloseChildForm.Visible = false;
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
            //activateButton(sender);
            openChildForm(new cadastro.FrmCliente(), sender);
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            openChildForm(new cadastro.FrmCargo(), sender);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            openChildForm(new cadastro.FrmFuncionario(), sender);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Caso queira incluir mensagem de aviso ao fechar o form, use o código comentado
            //var res = MessageBox.Show("Deseja realmente Fechar?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (res == DialogResult.Yes)
            //{ 
            //    Application.Exit();
            //}

            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            toolStripStatusHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }//
}
