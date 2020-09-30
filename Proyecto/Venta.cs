using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Venta : Form
    {
        public Venta()
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int n = dgvVenta.Rows.Add();
            dgvVenta.Rows[n].Cells[0].Value = txtNombre.Text;
            dgvVenta.Rows[n].Cells[1].Value = txtApellidos.Text;
            dgvVenta.Rows[n].Cells[2].Value = txtDni.Text;
            dgvVenta.Rows[n].Cells[3].Value = dtpFecha.Text;
            dgvVenta.Rows[n].Cells[4].Value = label10.Text;
            dgvVenta.Rows[n].Cells[5].Value = txtCodD.Text;
            dgvVenta.Rows[n].Cells[6].Value = txtMonto.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)

        {
           
        }
    }
}
