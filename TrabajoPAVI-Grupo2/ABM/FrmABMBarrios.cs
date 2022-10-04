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

namespace TrabajoPAVI_Grupo2
{
    public partial class FrmBarrios : Form
    {
        public FrmBarrios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Ciudades ";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCiudad.DataSource = tabla;
                cmbCiudad.DisplayMember = "Nombres";
                cmbCiudad.ValueMember = "id_ciudad";
                cmbCiudad.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            CargarGrillaBarrios();
        }

        //---------------------------------------Boton Consultar--------------------------------------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreBarrio.Text.Trim() == "" && txtCodPos.Text.Trim() == "" && cmbCiudad.SelectedIndex == -1)
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
        //---------------------------------------LIMPIAR CAMPOS--------------------------------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreBarrio.Text = "";
            txtCodPos.Text = "";
            cmbCiudad.SelectedIndex = -1;
            txtIdBarrio.Text = "";
            CargarGrillaBarrios();
        }

        //---------------------------------------CARGAR GRILLA--------------------------------------------------------------
        private void CargarGrillaBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM BARRIOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dataBarrio.DataSource = tabla;
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

        //---------------------------------------INSERTAR BARRIO--------------------------------------------------------------
        private bool InsertarBarrio(string nombre, string codigoPostal, int ciudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO BARRIOS (Nombre, Codigo_Postal, Id_Ciudad ) VALUES (@nombre, @codigo_Postal, @id_Ciudad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@codigo_Postal", codigoPostal);
                cmd.Parameters.AddWithValue("@id_Ciudad", ciudad);
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

        //---------------------------------------BOTON AGREGAR--------------------------------------------------------------

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int ciudadId;
            if (txtNombreBarrio.Text.Trim() == "" || txtCodPos.Text.Trim() == "" || cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                try
                {
                    ciudadId = (int)cmbCiudad.SelectedValue;
                    bool resultado = InsertarBarrio(txtNombreBarrio.Text, txtCodPos.Text, ciudadId);

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

            CargarGrillaBarrios();

        }
        //---------------------------------------MODIFICAR BARRIO--------------------------------------------------------------
        private void ModificarBarrio()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE BARRIOS SET Nombre =  @nombre, Codigo_Postal = @codigo_Postal, Id_Ciudad = @id_Ciudad WHERE Id_Barrio = @id_Barrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", txtNombreBarrio.Text);
                cmd.Parameters.AddWithValue("@codigo_Postal", txtCodPos.Text);
                cmd.Parameters.AddWithValue("@id_Ciudad", (int)cmbCiudad.SelectedValue);
                cmd.Parameters.AddWithValue("@id_Barrio", txtIdBarrio.Text);
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
        //---------------------------------------BOTON MODIFICAR--------------------------------------------------------------
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            ModificarBarrio();
            LimpiarCampos();
            CargarGrillaBarrios();
            MessageBox.Show("Actualizado con exito");
        }


        //---------------------------------------BORRAR BARRIO--------------------------------------------------------------
        private void BorrarBarrio()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM BARRIOS WHERE IdBarrio = @idBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Barrio", txtIdBarrio.Text);
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
        //---------------------------------------BOTON ELIMINAR-------------------------------------------------------------
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            BorrarBarrio();
            MessageBox.Show("Eliminado con éxito");
            LimpiarCampos();
            CargarGrillaBarrios();
        }

        //---------------------------------------CONSULTAR GRILLA--------------------------------------------------------------
        private void ConsultarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM BARRIOS WHERE ";
                int contador = 0;
                bool ciudad = false;

                if (txtNombreBarrio.Text.Trim() != "")
                {

                    consulta = consulta + "Nombre = @Nombre";
                    contador = contador + 1;
                }

                if (txtCodPos.Text.Trim() != "")
                {
                    if (contador == 0)
                    {
                        consulta = consulta + "Codigo_Postal = @codigo_Postal";
                        contador = contador + 1;
                    }
                    else
                    {
                        consulta = consulta + " AND Codigo_Postal = @codigo_Postal";

                    }

                }

                if (cmbCiudad.SelectedIndex != -1)
                {
                    ciudad = true;
                    if (contador == 0)
                    {
                        consulta = consulta + "Id_Ciudad = @id_Ciudad";
                        contador = contador + 1;
                    }
                    else
                    {
                        consulta = consulta + " AND Id_Ciudad = @id_Ciudad";
                    }

                }

                if (contador == 0)
                {
                    MessageBox.Show("Ingrese algun dato para buscar");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", txtNombreBarrio.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo_Postal", txtCodPos.Text.Trim());
                    if (ciudad)
                    {
                        cmd.Parameters.AddWithValue("@id_Ciudad", (int)cmbCiudad.SelectedValue);
                    }
                    cmd.Parameters.AddWithValue("@id_Barrio", txtIdBarrio.Text.Trim());
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;


                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    dataBarrio.DataSource = tabla;

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

    }
}

