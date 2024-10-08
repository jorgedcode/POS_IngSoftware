using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMerchan_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Inicio login = new Inicio();
            login.Show();
            this.Close();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Caja login = new Caja();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_de_Ventas ReporteDeVentas = new Reporte_de_Ventas();
            ReporteDeVentas.Show();
            this.Close();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Proveedores Proveedores = new Proveedores();
            Proveedores.Show();
            this.Close();
        }
    }
}
