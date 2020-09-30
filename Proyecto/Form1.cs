using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void AbrirFormularioMenu()
        {
            if (txtUsu.Text == "Usuario" && txtPass.Text == "123")
                this.DialogResult = DialogResult.OK;

            else
            {
                labelError.Visible = true;
                this.DialogResult = DialogResult.None;
                txtUsu.Clear();
                txtUsu.Focus();
                txtPass.Clear();
                txtPass.Focus();
                return;
            }


            {
                Menu ventana1 = new Menu();
                ventana1.Show();
                this.Hide();

            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AbrirFormularioMenu();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
