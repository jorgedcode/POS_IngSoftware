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
    public partial class frmMercancia : Form
    {
        public frmMercancia()
        {
            InitializeComponent();
        }

        private void pruebaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pruebaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pruebaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet.Prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter.Fill(this.pruebaDataSet.Prueba);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet.Prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter.Fill(this.pruebaDataSet.Prueba);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pruebaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void pruebaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pruebaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pruebaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pruebaDataSet);

        }

        private void pruebaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            int celda = pruebaDataGridView.Rows.Count;

            
                idTextBox.Text = (celda - 1).ToString();
            
                
            
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)46 && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }

        private void cant_StockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }
    }
}
