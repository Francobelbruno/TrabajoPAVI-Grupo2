using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPAVI_Grupo2.Entidades;

namespace TrabajoPAVI_Grupo2.Forms
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre y password");
            }
            else
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;
                try
                {
                    resultado = ValidarUsuario(nombreUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario();
                        FrmPrincipal ventana = new FrmPrincipal(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no existente...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                    throw;
                }
            }
        }
        private bool ValidarUsuario(string nombreUsuario, string password)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuarios WHERE nombre_Usuario like @nombre_usuario AND @Password like password ";
                cmd.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }

        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
    
}
