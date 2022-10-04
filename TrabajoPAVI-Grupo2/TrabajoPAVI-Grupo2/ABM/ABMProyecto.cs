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
    public partial class ABMProyecto : Form
    {
        public ABMProyecto()
        {
            InitializeComponent();
            OcultarCampos();
        }

        private void OcultarCampos()
        {
            txtIdProyecto.Hide();
            lblIDProyecto.Hide();
        }

        private void MostrarCampos()
        {
            txtIdProyecto.Show();
            lblIDProyecto.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------FUNCIONALIDAD BOTON CANCELAR---------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }

        //---------------------------------------------FUNCIONALIDAD BOTON LIMPIAR CAMPOS---------------------------------------
        private void LimpiarCampos()
        {

            txtIdCliente.Text = "";
            txtDescripcion.Text = "";
            mskdFechaInicio.Text = "";
            txtIdProyecto.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //----------------------------------------------CONFIGURACION DE ALTA(BOTON Y BD)----------------------------------------
        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Equals(" ") || mskdFechaInicio.Text.Equals(" ") || txtDescripcion.Text.Equals(" "))
            {
                MessageBox.Show("Los datos estan incompletos");
                txtIdCliente.Focus();
            }
            else
            {
                string descripcion = txtDescripcion.Text.Trim();
                string idCliente = txtIdCliente.Text.Trim();
                string fechaInicio = mskdFechaInicio.Text.Trim();

                bool resultado = false;

                try
                {
                    resultado = AgregarProyecto(descripcion, idCliente, fechaInicio);

                    if (resultado == true)
                    {
                        MessageBox.Show("Proyecto cargado correctamente");
                        CargarGrillaProyectos();
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar proyecto!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar proyecto!!");
                }
                finally
                {
                    LimpiarCampos();
                    txtDescripcion.Focus();
                }
            }
        }
        private bool AgregarProyecto(string descripcion, string idCliente, string fechaInicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Proyectos(Descripcion, IdCliente, FecInicio ) " +
                                  "VALUES (@descrip, @codCliente, @fechaInicio)";
                cmd.Parameters.Clear();



                cmd.Parameters.AddWithValue("@descrip", descripcion);
                cmd.Parameters.AddWithValue("@codCliente", idCliente);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        private void ABM_Proyecto_Load(object sender, EventArgs e)
        {
        }
        //----------------------------------------CONFIGURACION DE MODIFICACION----------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Equals(" ") || mskdFechaInicio.Text.Equals(" ") || txtDescripcion.Text.Equals(" "))
            {
                MessageBox.Show("Los datos NO estan completos");
                txtIdCliente.Focus();
            }
            else
            {
                SolicitarID ventana = new SolicitarID(txtIdCliente.Text, txtDescripcion.Text, mskdFechaInicio.Text);
                ventana.Show();
                CargarGrillaProyectos();



            }

        }
        //----------------------------------------CONFIGURACION DE BAJA(BOTON Y BD)---------------------------------------------
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Equals(" ") || mskdFechaInicio.Text.Equals(" ") || txtDescripcion.Text.Equals(" "))
            {
                MessageBox.Show("Los datos estan incompletos");
                txtIdCliente.Focus();
            }
            else
            {
                MostrarCampos();
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                if (txtIdProyecto.Text.Equals(" "))
                {
                    MessageBox.Show("El ID de proyecto no puede estar vacio");
                }
                else
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand();

                        string consulta = "DELETE FROM Proyectos WHERE CodProyecto = @idProy";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idProy", txtIdProyecto.Text);

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;

                        cn.Open();
                        cmd.Connection = cn;
                        cmd.ExecuteNonQuery();
                        CargarGrillaProyectos();
                        LimpiarCampos();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CargarGrillaProyectos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Proyectos";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaProyecto.DataSource = tabla;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrillaProyectos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskdFechaInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
