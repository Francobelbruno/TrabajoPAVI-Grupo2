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
    public partial class abmClientes : Form
    {
        public abmClientes()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrillaClientes();
        }
        private void LimpiarCampos()

        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            cmbBarrio.SelectedIndex = -1;

        }
        //---------------------------------------CARGA ABM--------------------------------------------------------------

        private void abmClientes_Load(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM BARRIOS ";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrio.DataSource = tabla;
                cmbBarrio.DisplayMember = "nombre";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            CargarGrillaClientes();

        }

        //---------------------------------------CARGAR GRILLA CLIENTES----------------------------------------------------------
        private void CargarGrillaClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Clientes";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                dataCliente.DataSource = tabla;

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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int barrioId;
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtCalle.Text.Trim() == "" || txtNroCalle.Text.Trim() == "" || txtMail.Text.Trim() == "" || cmbBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                try
                {
                    barrioId = (int)cmbBarrio.SelectedValue;
                    bool resultado = InsertarCliente(txtApellido.Text.Trim(), txtNombre.Text.Trim(), txtTelefono.Text.Trim(), barrioId, txtCalle.Text.Trim(), txtNroCalle.Text.Trim(), txtMail.Text.Trim());

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

            CargarGrillaClientes();
        }

        private bool InsertarCliente(string apellido, string nombre, string telefono, int barrio, string calle, string nroCalle, string email)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Clientes (Apellido, Nombres, Telefono, Id_Barrio, Calle, Nro_Calle, Email ) VALUES (@apellido, @nombre, @telefono,@idBarrio, @calle, @nroCalle , @email)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idBarrio", barrio);
                cmd.Parameters.AddWithValue("@calle", calle);
                cmd.Parameters.AddWithValue("@nroCalle", nroCalle);
                cmd.Parameters.AddWithValue("@email", email);
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


        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = dataCliente.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dataCliente.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dataCliente.CurrentRow.Cells[3].Value.ToString();
            cmbBarrio.SelectedValue = dataCliente.CurrentRow.Cells[4].Value.ToString();
            txtCalle.Text = dataCliente.CurrentRow.Cells[5].Value.ToString();
            txtNroCalle.Text = dataCliente.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dataCliente.CurrentRow.Cells[7].Value.ToString();
        }

        //---------------------------------------MODIFICAR CLIENTE--------------------------------------------------------------
        private void ModificarCliente()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Clientes SET Apellido =  @Apellido, Nombres =  @nombre, Telefono = @telefono, IdBarrio = @idBarrio, Calle = @calle, NroCalle = @nroCalle, Email = @email WHERE IdCliente = @idCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", txtIdCliente.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@idBarrio", (int)cmbBarrio.SelectedValue);
                cmd.Parameters.AddWithValue("@Calle", txtCalle.Text.Trim());
                cmd.Parameters.AddWithValue("@nroCalle", txtNroCalle.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtMail.Text.Trim());
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

        //---------------------------------------BOTON MODIFICAR --------------------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            LimpiarCampos();
            CargarGrillaClientes();
            MessageBox.Show("Actualizado con exito");
        }
        //---------------------------------------BORRAR CLIENTE--------------------------------------------------------------
        private void BorrarCliente()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Clientes WHERE Id_Cliente = @idCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCliente", txtIdCliente.Text);
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarCliente();
            MessageBox.Show("Eliminado con exito");
            LimpiarCampos();
            CargarGrillaClientes();
        }

        // Consultar Grilla

        private void ConsultarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Clientes WHERE ";
                int contador = 0;
                bool barrio = false;

                if (txtApellido.Text.Trim() != "")
                {

                    consulta = consulta + "Apellido = @apellido";
                    contador = contador + 1;
                }

                if (txtNombre.Text.Trim() != "")
                {
                    if (contador == 0)
                    {
                        consulta = consulta + "Nombres = @nombre";
                        contador = contador + 1;
                    }
                    else
                    {
                        consulta = consulta + " AND Nombres = @nombre";

                    }

                }

                if (cmbBarrio.SelectedIndex != -1)
                {
                    barrio = true;
                    if (contador == 0)
                    {
                        consulta = consulta + "Id_Barrio = @idBarrio";
                        contador = contador + 1;
                    }
                    else
                    {
                        consulta = consulta + " AND Id_Barrio = @idBarrio";
                    }

                }

                if (txtMail.Text.Trim() != "")
                {
                    if (contador == 0)
                    {
                        consulta = consulta + "Email = @email";
                        contador = contador + 1;
                    }
                    else
                    {
                        consulta = consulta + " AND Email = @email";

                    }

                }


                if (contador == 0)
                {
                    MessageBox.Show("Ingrese algun dato");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    if (barrio)
                    {
                        cmd.Parameters.AddWithValue("@idBarrio", (int)cmbBarrio.SelectedValue);
                    }
                    cmd.Parameters.AddWithValue("@email", txtMail.Text.Trim());
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    MessageBox.Show(consulta);

                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    DataTable tabla = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    dataCliente.DataSource = tabla;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarGrilla();
        }


    }
}
