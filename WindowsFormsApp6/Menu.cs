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

        // Este botón es el de Salir
        private void btnMerchan_Click(object sender, EventArgs e)
        {
            Inicio login = new Inicio();
            login.Show();
            this.Close();
        }
        //

        // Este botón es de Mercancia
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmMercancia Mercancia = new frmMercancia();
            Mercancia.MdiParent = this;
            Mercancia.Show();
        }
        //

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja();
            caja.MdiParent = this;
            caja.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_de_Ventas ReporteDeVentas = new Reporte_de_Ventas();
            ReporteDeVentas.MdiParent = this;
            ReporteDeVentas.Show();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Proveedores Proveedores = new Proveedores();
            Proveedores.MdiParent = this;
            Proveedores.Show();
        }
    }
}
