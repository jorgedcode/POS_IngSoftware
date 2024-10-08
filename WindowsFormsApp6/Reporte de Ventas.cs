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
    public partial class Reporte_de_Ventas : Form
    {
        public Reporte_de_Ventas()
        {
            InitializeComponent();
        }
        
        /*
        private void inventarioVPruebaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioVPruebaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pruebaDataSet1);

        }*/

        private void Reporte_de_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet1.InventarioVPrueba' Puede moverla o quitarla según sea necesario.
            this.inventarioVPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVPrueba);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet1.InventarioVTicketsPrueba' Puede moverla o quitarla según sea necesario.
            this.inventarioVTicketsPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVTicketsPrueba);
            rdbtnTodos.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
            /*
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
            else
            {
                
                if (rdbtnMonth.Checked == true || rdbtnToday.Checked == true || rdbtn3Months.Checked == true || rdbtnAñoAct.Checked == true)
                {

                    int dia = int.Parse(DateTime.Now.Day.ToString()), mes = int.Parse(DateTime.Now.Month.ToString()), año = int.Parse(DateTime.Now.Year.ToString());
                    if (rdbtnToday.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarHoyTicket(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, dia, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketHoy(this.pruebaDataSet1.InventarioVPrueba, ticket, dia, mes, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVTicketsPrueba, dia, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVPrueba, dia, mes, año);
                        }
                    }
                    if (rdbtnMonth.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicketUltimoMes(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketUltimoMes(this.pruebaDataSet1.InventarioVPrueba, ticket, mes, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVTicketsPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
                            this.inventarioVPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
                        }
                    }
                    if (rdbtn3Months.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicket3Meses(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, mes - 2, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicket3Meses(this.pruebaDataSet1.InventarioVPrueba, ticket, mes - 2, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVTicketsPrueba, mes - 2, año);
                            this.inventarioVPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVPrueba, mes - 2, año);
                        }
                    }
                    if (rdbtnAñoAct.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicketAñoActual(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketAñoActual(this.pruebaDataSet1.InventarioVPrueba, ticket, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVTicketsPrueba, año);
                            this.inventarioVPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVPrueba, año);
                        }
                    }
                }
                else
                {
                    if (textBox1.Text != "" && rdbtnTodos.Checked == true)
                    {
                        this.inventarioVTicketsPruebaTableAdapter.BuscarPorNumeroTicket(this.pruebaDataSet1.InventarioVTicketsPrueba, int.Parse(textBox1.Text.ToString()));
                    }
                    else
                    {
                        this.inventarioVTicketsPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVTicketsPrueba);
                    }
                }
            }
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten Numeros.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            else
            {
                textBox2.Text = textBox1.Text;
                if (rdbtnMonth.Checked == true || rdbtnToday.Checked == true || rdbtn3Months.Checked == true || rdbtnAñoAct.Checked == true)
                {

                    int dia = int.Parse(DateTime.Now.Day.ToString()), mes = int.Parse(DateTime.Now.Month.ToString()), año = int.Parse(DateTime.Now.Year.ToString());
                    if (rdbtnToday.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarHoyTicket(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, dia, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketHoy(this.pruebaDataSet1.InventarioVPrueba, ticket, dia, mes, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVTicketsPrueba, dia, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVPrueba, dia, mes, año);
                        }
                    }
                    if (rdbtnMonth.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicketUltimoMes(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, mes, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketUltimoMes(this.pruebaDataSet1.InventarioVPrueba, ticket, mes, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVTicketsPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
                            this.inventarioVPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
                        }
                    }
                    if (rdbtn3Months.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicket3Meses(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, mes - 2, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicket3Meses(this.pruebaDataSet1.InventarioVPrueba, ticket, mes - 2, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVTicketsPrueba, mes - 2, año);
                            this.inventarioVPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVPrueba, mes - 2, año);
                        }
                    }
                    if (rdbtnAñoAct.Checked == true)
                    {
                        if (textBox1.Text != "")
                        {
                            int ticket = int.Parse(textBox1.Text.ToString());
                            this.inventarioVTicketsPruebaTableAdapter.LlenarTicketAñoActual(this.pruebaDataSet1.InventarioVTicketsPrueba, ticket, año);
                            this.inventarioVPruebaTableAdapter.LlenarTicketAñoActual(this.pruebaDataSet1.InventarioVPrueba, ticket, año);
                        }
                        else
                        {
                            this.inventarioVTicketsPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVTicketsPrueba, año);
                            this.inventarioVPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVPrueba, año);
                        }
                    }
                }
                else
                {
                    if (textBox1.Text != "" && rdbtnTodos.Checked == true)
                    {
                        this.inventarioVTicketsPruebaTableAdapter.BuscarPorNumeroTicket(this.pruebaDataSet1.InventarioVTicketsPrueba, int.Parse(textBox1.Text.ToString()));
                    }
                    else
                    {
                        this.inventarioVTicketsPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVTicketsPrueba);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten Numeros.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            else
            {
                if (rdbtnMonth.Checked == true || rdbtnToday.Checked == true || rdbtn3Months.Checked == true || rdbtnAñoAct.Checked == true)
                {

                    int dia = int.Parse(DateTime.Now.Day.ToString()), mes = int.Parse(DateTime.Now.Month.ToString()), año = int.Parse(DateTime.Now.Year.ToString());
                    if (rdbtnToday.Checked == true)
                    {
                        if (textBox2.Text != "")
                        {
                            int ticket = int.Parse(textBox2.Text.ToString());

                            this.inventarioVPruebaTableAdapter.LlenarTicketHoy(this.pruebaDataSet1.InventarioVPrueba, ticket, dia, mes, año);
                        }
                        else
                        {

                            this.inventarioVPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVPrueba, dia, mes, año);
                        }
                    }
                    if (rdbtnMonth.Checked == true)
                    {
                        if (textBox2.Text != "")
                        {
                            int ticket = int.Parse(textBox2.Text.ToString());

                            this.inventarioVPruebaTableAdapter.LlenarTicketUltimoMes(this.pruebaDataSet1.InventarioVPrueba, ticket, mes, año);
                        }
                        else
                        {

                            this.inventarioVPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
                        }
                    }
                    if (rdbtn3Months.Checked == true)
                    {
                        if (textBox2.Text != "")
                        {
                            int ticket = int.Parse(textBox2.Text.ToString());

                            this.inventarioVPruebaTableAdapter.LlenarTicket3Meses(this.pruebaDataSet1.InventarioVPrueba, ticket, mes - 2, año);
                        }
                        else
                        {
                            this.inventarioVPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVPrueba, mes - 2, año);
                        }
                    }
                    if (rdbtnAñoAct.Checked == true)
                    {
                        if (textBox2.Text != "")
                        {
                            int ticket = int.Parse(textBox2.Text.ToString());
                            this.inventarioVPruebaTableAdapter.LlenarTicketAñoActual(this.pruebaDataSet1.InventarioVPrueba, ticket, año);
                        }
                        else
                        {
                            this.inventarioVPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVPrueba, año);
                        }
                    }
                }
                else
                {
                    if (textBox2.Text != "" && rdbtnTodos.Checked == true)
                    {
                        this.inventarioVPruebaTableAdapter.BuscarPorTicket(this.pruebaDataSet1.InventarioVPrueba, int.Parse(textBox2.Text.ToString()));
                    }
                    else
                    {
                        this.inventarioVPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVPrueba);
                    }
                }
            }
        }

        private void rdbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            int mes = int.Parse(DateTime.Now.Month.ToString());
            this.inventarioVTicketsPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVTicketsPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
            this.inventarioVPruebaTableAdapter.UltimoMes(this.pruebaDataSet1.InventarioVPrueba, mes, decimal.Parse(DateTime.Now.ToString("yyyy")));
        }

        private void rdbtnToday_CheckedChanged(object sender, EventArgs e)
        {
            int dia = int.Parse(DateTime.Now.Day.ToString());
            int mes = int.Parse(DateTime.Now.Month.ToString());
            int año = int.Parse(DateTime.Now.Year.ToString());
            this.inventarioVTicketsPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVTicketsPrueba, dia, mes, año);
            this.inventarioVPruebaTableAdapter.LlenarHoy(this.pruebaDataSet1.InventarioVPrueba, dia, mes, año);
        }

        private void rdbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.inventarioVTicketsPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVTicketsPrueba);
            this.inventarioVPruebaTableAdapter.Fill(this.pruebaDataSet1.InventarioVPrueba);
        }

        private void rdbtn3Months_CheckedChanged(object sender, EventArgs e)
        {
            int meses = int.Parse(DateTime.Now.Month.ToString()) - 2;
            int año = int.Parse(DateTime.Now.Year.ToString());
            this.inventarioVTicketsPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVTicketsPrueba, meses, año);
            this.inventarioVPruebaTableAdapter.LlenarUlt3Meses(this.pruebaDataSet1.InventarioVPrueba, meses, año);
        }

        private void rdbtnAñoAct_CheckedChanged(object sender, EventArgs e)
        {
            int año = int.Parse(DateTime.Now.Year.ToString());
            this.inventarioVTicketsPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVTicketsPrueba, año);
            this.inventarioVPruebaTableAdapter.LlenarAñoActual(this.pruebaDataSet1.InventarioVPrueba, año);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }
    }
}
