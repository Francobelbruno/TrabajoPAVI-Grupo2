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

namespace PruebaPAV
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
            mskTelefono.Text = "";
            txtEmail.Text = "";
            txtCalle.Text = "";
            mskNro.Text = "";
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

                dgwClientes.DataSource = tabla;

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
            if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtEmail.Text.Trim() == "" || cmbBarrio.SelectedIndex == -1 || mskTelefono.Text.Trim() == "" || mskNro.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos por favor!!");
            }
            else
            {
                try
                {
                    barrioId = (int)cmbBarrio.SelectedValue;
                    bool resultado = insertarCliente(txtNombre.Text.Trim(), txtApellido.Text.Trim(), int.Parse(mskTelefono.Text.Trim()), barrioId, txtCalle.Text.Trim(), int.Parse(mskNro.Text.Trim()), txtEmail.Text.Trim());
                    if (resultado)
                    {
                        MessageBox.Show("Cliente cargado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar cliente");
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Cliente");
                }
            }

        }

        private bool insertarCliente(string nombre, string apellido, int telefono, int barrio, string calle, int nro, string email)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string query = "INSERT INTO Clientes(nombres,apellido,telefono,calle,nro_calle,email,id_barrio) VALUE(@nombre,@apellido,@telefono,@calle,@nro,@email,@idBarrio)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@idBarrio", barrio);
                cmd.Parameters.AddWithValue("@calle", calle);
                cmd.Parameters.AddWithValue("@nro", nro);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
