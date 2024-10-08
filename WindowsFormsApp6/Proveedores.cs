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

namespace WindowsFormsApp6
{
    public partial class Proveedores : Form
    {
        string connectionString;
        SqlConnection cn;

        int IdProveedor = 0;

        public Proveedores()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp6.Properties.Settings.cn"].ConnectionString;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'origenProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.origenProveedores.Proveedores);

        }

        public void limpiarTextBox()
        {
            tbNombre.Text = "";
            tbTelefono.Text = "";
            tbCorreo.Text = "";
            tbDireccion.Text = "";
            tbCP.Text = "";
            tbCiudad.Text = "";
            tbEstado.Text = "";
            tbPais.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" && tbTelefono.Text != "" && tbCorreo.Text != "" && tbDireccion.Text != "" && tbCP.Text != "" && tbCiudad.Text != "" && tbEstado.Text != "" && tbPais.Text != "")
            {
                cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand comandoInsertarProveedores = new SqlCommand("INSERT INTO Proveedores (Nombre, Telefono, Correo, Direccion, Codigo_Postal, Ciudad, Estado, Pais) VALUES ('" + tbNombre.Text.ToString() + "', " + tbTelefono.Text + ", '" + tbCorreo.Text.ToString() + "', '" + tbDireccion.Text.ToString() + "', " + tbCP.Text + ", '" + tbCiudad.Text.ToString() + "', '" + tbEstado.Text.ToString() + "', '" + tbPais.Text.ToString() + "')", cn);
                comandoInsertarProveedores.ExecuteNonQuery();
                cn.Close();
                this.proveedoresTableAdapter.Fill(this.origenProveedores.Proveedores);
                limpiarTextBox();
            }
            else
            {
                MessageBox.Show("Llene todos los datos para registrar un nuevo Proveedor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand comandoBuscarProveedor = new SqlCommand("SELECT Id, Nombre, Telefono, Correo, Direccion, Codigo_Postal, Ciudad, Estado, Pais FROM Proveedores WHERE Nombre = '"+tbNombre.Text.ToString()+"'", cn);
                SqlDataReader reader = comandoBuscarProveedor.ExecuteReader();
                if (reader.Read())
                {
                    IdProveedor = int.Parse(reader.GetValue(0).ToString());
                    tbNombre.Text = reader.GetValue(1).ToString();
                    tbTelefono.Text = reader.GetValue(2).ToString();
                    tbCorreo.Text = reader.GetValue(3).ToString();
                    tbDireccion.Text = reader.GetValue(4).ToString();
                    tbCP.Text = reader.GetValue(5).ToString();
                    tbCiudad.Text = reader.GetValue(6).ToString();
                    tbEstado.Text = reader.GetValue(7).ToString();
                    tbPais.Text = reader.GetValue(8).ToString();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningun proveedor con ese nombre");
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del Proveedor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(IdProveedor != 0 && tbNombre.Text != "" && tbTelefono.Text != "" && tbCorreo.Text != "" && tbDireccion.Text != "" && tbCP.Text != "" && tbCiudad.Text != "" && tbEstado.Text != "" && tbPais.Text != "")
            {
                cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand commmandActualizarProveedor = new SqlCommand("Update Proveedores set Nombre = '" + tbNombre.Text.ToString() + "', Telefono = "+tbTelefono.Text+", Correo = '"+tbCorreo.Text.ToString()+"', Direccion = '"+tbDireccion.Text.ToString()+"', Codigo_Postal = "+tbCP.Text+", Ciudad = '"+tbCiudad.Text.ToString()+"', Estado = '"+tbEstado.Text.ToString()+"', Pais = '"+tbPais.Text.ToString()+"' WHERE Id = " + IdProveedor, cn);
                commmandActualizarProveedor.ExecuteNonQuery();
                cn.Close();
                this.proveedoresTableAdapter.Fill(this.origenProveedores.Proveedores);
                limpiarTextBox();
                IdProveedor = 0;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdProveedor != 0 && tbNombre.Text != "" && tbTelefono.Text != "" && tbCorreo.Text != "" && tbDireccion.Text != "" && tbCP.Text != "" && tbCiudad.Text != "" && tbEstado.Text != "" && tbPais.Text != "")
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    cn = new SqlConnection(connectionString);
                    cn.Open();
                    SqlCommand commmandEliminarProveedor = new SqlCommand("DELETE FROM Proveedores WHERE Id = " + IdProveedor + " AND Nombre = '" + tbNombre.Text.ToString() + "'", cn);
                    if (commmandEliminarProveedor.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("El nombre escrito no coincide con la busqueda hecha");
                    }
                    cn.Close();
                    this.proveedoresTableAdapter.Fill(this.origenProveedores.Proveedores);
                    limpiarTextBox();
                }
            }
            else
            {
                MessageBox.Show("Primero busque el Proveedor que desea eliminar");
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)43)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros.");
            }
        }
    }
}
