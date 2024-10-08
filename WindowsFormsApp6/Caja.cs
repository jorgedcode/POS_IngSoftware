using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace WindowsFormsApp6
{
    public partial class Caja : Form
    {
        string connectionString;
        SqlConnection cn;

        //Actualiza el precio total, cada que añades o eliminas algo
        void RefrescarGrid()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Columna3"].Value);
            }
            label4.Text = total.ToString();


        }

        //Insertar Informacion a Inventario de Ventas ( DE LOS TICKETS )
        void InventarioTickets(String Fecha)
        {
            int Num_Articulos = 0;
            double Total, Pago, Cambio;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                Num_Articulos = Num_Articulos + Convert.ToInt32(row.Cells["Columna1"].Value);
            }
            Total = double.Parse(label4.Text);
            Pago = double.Parse(label2.Text);
            Cambio = double.Parse(label5.Text);
            cn = new SqlConnection(connectionString);

            //Saca el Numero de Ticket que le corresponde a esa venta
            int Ticket = 0;
            cn.Open();
            SqlCommand comandoObtenerIdTicket = new SqlCommand("SELECT TOP 1 * FROM InventarioVTicketsPrueba ORDER BY Numero_Ticket DESC", cn);
            SqlDataReader reader = comandoObtenerIdTicket.ExecuteReader();
            if (reader.Read())
            {
                Ticket = int.Parse(reader.GetValue(0).ToString()) + 1;
            } else
            {
                Ticket = 1;
            }
            cn.Close();

            cn.Open();
            SqlCommand comandoInsertarTickets = new SqlCommand("INSERT INTO InventarioVTicketsPrueba (Numero_Ticket, Fecha, Num_Articulos, Total, Pago, Cambio) VALUES ("+Ticket+", convert(datetime, '" + Fecha + "',5), "+Num_Articulos+", "+ Total +", "+ Pago +", "+ Cambio +")", cn);
            comandoInsertarTickets.ExecuteNonQuery();
            cn.Close();
        }

        //Insertar Productos a inventario de ventas
        void InventarioVentas(String Fecha)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {

                String Producto = dataGridView1.Rows[i].Cells["Columna0"].Value.ToString();
                int Cantidad_Vendida = int.Parse(dataGridView1.Rows[i].Cells["Columna1"].Value.ToString());
                double Total = double.Parse(dataGridView1.Rows[i].Cells["Columna3"].Value.ToString()),
                    Precio_Unit = double.Parse(dataGridView1.Rows[i].Cells["Columna2"].Value.ToString());
                int Ticket = 0, Id = 0;
                cn = new SqlConnection(connectionString);
                //Saca el Numero de Ticket que le corresponde a esa venta
                cn.Open();
                SqlCommand comandoObtenerIdTicket = new SqlCommand("SELECT TOP 1 * FROM InventarioVTicketsPrueba ORDER BY Numero_Ticket DESC", cn);
                SqlDataReader reader = comandoObtenerIdTicket.ExecuteReader();
                while (reader.Read())
                {
                    Ticket = int.Parse(reader.GetValue(0).ToString());
                }
                cn.Close();
                //Saca el Id/Codigo del Producto
                cn.Open();
                SqlCommand commandid = new SqlCommand("Select Id From Prueba where Nombre = '" + Producto + "'", cn);
                SqlDataReader readerid = commandid.ExecuteReader();
                while (readerid.Read())
                {
                    Id = int.Parse(readerid.GetValue(0).ToString());
                }
                cn.Close();
                //Inserta los productos en el inventario de ventas
                cn.Open();
                SqlCommand comandoInsertarProductosInven = new SqlCommand("INSERT INTO InventarioVPrueba (Producto, Codigo, Precio_Unit, Cantidad_Vendida, Ticket, Fecha, Total) VALUES ('" + Producto + "', " + Id + ", " + Precio_Unit + ", " + Cantidad_Vendida + ", " + Ticket + ", convert(datetime, '" + Fecha + "',5), " + Total + ")", cn);
                comandoInsertarProductosInven.ExecuteNonQuery();
                cn.Close();

            }

        }

        //Actualiza el Stock del producto comprado
        void Actualizar_Stock()
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand commandRestarStock = new SqlCommand("Select Cant_Stock From Prueba where Id = " + textBox1.Text, cn);

            SqlDataReader reader = commandRestarStock.ExecuteReader();
            double stock_restante = 0, stock = 1;
            while (reader.Read())
            {
                stock = double.Parse(reader.GetValue(0).ToString());
                stock_restante = stock - double.Parse(textBox2.Text);
            }
            cn.Close();
            cn.Open();
            SqlCommand commmandActualizarStock = new SqlCommand("Update Prueba set Cant_Stock = " + stock_restante + " WHERE Id = " + textBox1.Text, cn);
            commmandActualizarStock.ExecuteNonQuery();
            cn.Close();

            //Codigo para cuando en el Stock del producto queden 5 o menos avise que hay que volver a pedir
            cn.Open();
            SqlCommand commandCheck = new SqlCommand("Select Cant_Stock, Nombre From Prueba where Id = " + textBox1.Text, cn);
            SqlDataReader readerCheck = commandCheck.ExecuteReader();
            while (readerCheck.Read())
            {
                int producto = Convert.ToInt32(readerCheck.GetValue(0).ToString());
                if (producto <= 5)
                {
                    MessageBox.Show("AVISO: En el inventario solo hay: "+ readerCheck.GetValue(0).ToString() +" de "+ readerCheck.GetValue(1).ToString());
                }
            }
            cn.Close();
        }

        //Codigo para que al quitar un producto de la lista se vuelva a poner en el stock
        void Devolver_A_Stock()
        {
            int cantidad_dev = Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value);
            String nombre_dev = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString();
            cn = new SqlConnection(connectionString);
            cn.Open();
            SqlCommand commandStock = new SqlCommand("Select Cant_Stock From Prueba where Nombre = '" + nombre_dev + "'", cn);

            SqlDataReader reader = commandStock.ExecuteReader();
            double NuevoStock = 0, stock = 1;
            while (reader.Read())
            {
                stock = double.Parse(reader.GetValue(0).ToString());
                NuevoStock = stock + cantidad_dev;
            }
            cn.Close();
            cn.Open();
            SqlCommand commmandActualizarStock = new SqlCommand("Update Prueba set Cant_Stock = " + NuevoStock + " WHERE Nombre = '" + nombre_dev + "'", cn);
            commmandActualizarStock.ExecuteNonQuery();
            cn.Close();
        }





        public Caja()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp6.Properties.Settings.cn"].ConnectionString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //Codigo para que al poner un producto se ponga automaticamente 1 en el textbox2 cantidad
                textBox2.Text = "1";

                cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand command = new SqlCommand("Select*From Prueba where Id = " + textBox1.Text, cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    label9.Text = reader.GetValue(1).ToString();
                    label13.Text = reader.GetValue(2).ToString();
                    label11.Text = reader.GetValue(3).ToString();

                }
                cn.Close();
            }
            else {
                label9.Text = "";
                label13.Text = "";
                label11.Text = "";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text != "") {





                label2.Text = Microsoft.VisualBasic.Interaction.InputBox("Pago del cliente","Pago");

               

                if (label2.Text != "")
                {
                    double Cambio = Convert.ToDouble(label2.Text) - Convert.ToDouble(label4.Text);
                    label5.Text = Cambio.ToString();

                    DialogResult dialogresult = MessageBox.Show("El cambio del cliente es: " + Cambio.ToString("c"), "Cambio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    // Impresion
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();

                    //Actualiza el Reporte de Ventas
                    String Fecha = DateTime.Now.ToString("yyyyMMdd hh:mm:ss");
                    InventarioTickets(Fecha);
                    InventarioVentas(Fecha);

                    dataGridView1.Rows.Clear();
                    RefrescarGrid();
                    textBox1.Focus();
                    label2.Text = "";
                    label5.Text = "";


                }

            }


        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //SACAR NUMERO DE TICKET
            int Ticket = 0;
            cn.Open();
            SqlCommand comandoObtenerIdTicket = new SqlCommand("SELECT TOP 1 * FROM InventarioVTicketsPrueba ORDER BY Numero_Ticket DESC", cn);
            SqlDataReader reader = comandoObtenerIdTicket.ExecuteReader();
            if (reader.Read())
            {
                Ticket = int.Parse(reader.GetValue(0).ToString()) + 1;
            }
            else
            {
                Ticket = 1;
            }
            cn.Close();
            Font font = new Font("Arial", 9);
            int ancho = 300, padY = 20;
            Console.WriteLine();
            DateTime dateOnly = DateTime.Now;



            e.Graphics.DrawString("---Nombre absurdamente largo---", font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
            e.Graphics.DrawString("Direccion: Direccion de Local", font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
            e.Graphics.DrawString("Telefono: 867-555-5555", font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
            e.Graphics.DrawString("Fecha: " + dateOnly.ToString("dd/MM/yyyy"), font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
            e.Graphics.DrawString("Hora: " + dateOnly.ToString("HH:mm"), font, Brushes.Black, new RectangleF(160, padY, ancho, 20));
            e.Graphics.DrawString("Venta Numero: " + Ticket.ToString(), font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
            e.Graphics.DrawString("Producto                         Cant.         Total", font, Brushes.Black, new RectangleF(0, padY += 40, ancho, 20));
            e.Graphics.DrawString("Total :", font, Brushes.Black, new RectangleF(120, padY + 240, ancho, 20));
            e.Graphics.DrawString("$" + label4.Text, font, Brushes.Black, new RectangleF(200, padY + 240, ancho, 20));

            e.Graphics.DrawString("Pago:", font, Brushes.Black, new RectangleF(120, padY + 260, ancho, 20));
            e.Graphics.DrawString("$" + label2.Text, font, Brushes.Black, new RectangleF(200, padY + 260, ancho, 20));

            e.Graphics.DrawString("Cambio :", font, Brushes.Black, new RectangleF(120, padY + 280, ancho, 20));
            e.Graphics.DrawString("$" + label5.Text, font, Brushes.Black, new RectangleF(200, padY + 280, ancho, 20));

            e.Graphics.DrawString("¡Gracias por su compra!", font, Brushes.Black, new RectangleF(45, padY + 300, ancho, 20));



            //Cuenta de celdad

            int celda = dataGridView1.Rows.Count;
            for (int i = 0; i < celda - 1; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, Brushes.Black, new RectangleF(150, padY, ancho, 20));
                e.Graphics.DrawString("$" + dataGridView1.Rows[i].Cells[3].Value.ToString(), font, Brushes.Black, new RectangleF(200, padY, ancho, 20));
            }




            //Referencia 300px
            //  e.Graphics.DrawString(" Gracias por su compra, ya larguese", font, Brushes.Black, new RectangleF(0, padY += 20, ancho, 20));





        }





        private void Caja_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Presionar ENTER para agregar producto
            if (textBox1.Text != "" && textBox2.Text != "" && e.KeyChar == (char)13)
            {
             
                if (label9.Text != "" && label11.Text != "" )
                {

                    textBox2.Focus();

                }
                else { MessageBox.Show("Datos no validos o campos no completos");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                  
            
            }
        }









        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && e.KeyChar == (char)13)
            {
                String Producto, Cantidad, Precio_Uni, Total;
                double iCant, iPrec_Unit, iPrec_Total;
                iCant = double.Parse(textBox2.Text);
                iPrec_Unit = double.Parse(label11.Text);
                iPrec_Total = iCant * iPrec_Unit;

                Producto = label9.Text;
                Cantidad = textBox2.Text;

                Precio_Uni = iPrec_Unit.ToString("N");


                Total = iPrec_Total.ToString("N");


                dataGridView1.Rows.Add(Producto, Cantidad, Precio_Uni, Total);
                RefrescarGrid();
                Actualizar_Stock();
                textBox1.Text = ""; textBox2.Text = "";
                textBox1.Focus();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int celda = dataGridView1.Rows.Count;
            Devolver_A_Stock();
            dataGridView1.Rows.Remove(dataGridView1.Rows[celda-2]);
            RefrescarGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

       
    }
}
