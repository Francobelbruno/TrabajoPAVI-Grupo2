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

namespace TrabajoPAVI_Grupo2.ABM
{
    public partial class frmABMCUsuario : Form
    {
        public frmABMCUsuario()
        {
            InitializeComponent();
        }

        //Agregar usuario
        
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                try
                {

                    bool resultado = InsertarUsuario(txtNombreUsuario.Text, txtContraseña.Text);

                    if (resultado)
                    {
                        LimpiarCampos();
                        MessageBox.Show("Cargado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar ");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar" + ex.Message);
                }

            }
        }

        private bool InsertarUsuario(string nombre_usuario, string contraseña)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO USUARIOS (nombre_usuario, password) VALUES (@nombre_usuario, @password)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("@password", contraseña);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        
        }
         //Limpiar campos
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
        }
        //Consultar usuarios
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "" && txtNombreUsuario.Text.Trim() == "" )
            {
                MessageBox.Show("Ingrese algun dato");
            }
            else
            {
                try
                {
                    ConsultarGrilla();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ConsultarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM USUARIOS ";
                int contador = 0;
            
                if (txtNombreUsuario.Text.Trim() != "")
                {
                    consulta = consulta + "Nombre = @nombre_usuario";
                    contador = contador + 1;
                }
                if (contador == 0)
                {
                    MessageBox.Show("Ingrese algun dato para buscar");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre_usuario", txtNombreUsuario.Text.Trim());
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        //Eliminar usuario
        private void brnEliminar_Click(object sender, EventArgs e)
        {
            BorrarUsuario();
            MessageBox.Show("Eliminado con éxito");
            LimpiarCampos();
            CargarGrillaUsuarios();
        }

        private void BorrarUsuario()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM USUARIOS WHERE nombre_usuario = @nombre_usuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_usuario", txtNombreUsuario.Text);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


        }

        private void CargarGrillaUsuarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM USUARIOS";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                datosUsuarios.DataSource = tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        //Modificar usuario

        private void ModificarUsuario()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE USUARIOS SET nombre_usuario =  @nombre_usuario ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre_usuario", txtNombreUsuario.Text);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
            LimpiarCampos();
            CargarGrillaUsuarios();
            MessageBox.Show("Actualizado con exito");
        }
    }

}
