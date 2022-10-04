using TPPAV1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPAVI_Grupo2;

/// PROBLEMAS   - DEJA AGREGAR ETAPA AUNQUE YA EXISTA EL ID
///             - DEJA ACTUALIZAR ETAPA Y CAMBIAR EL ID
///             - AL ACTUALIZAR SI SE CAMBIA EL ID Y ESTE NO EXISTE TE DICE QUE SE ACTUALIZÓ PERO NO PASÓ NADA

namespace trabajoPAVI_Grupo2
{
    public partial class formABMEtapa : Form
    {
        public formABMEtapa()
        {
            InitializeComponent();
            CargarGrilla();
            btnActualizarEtapa.Enabled = false;
            FrmABMEtapasXProyecto ventana = new FrmABMEtapasXProyecto();
            ventana.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// ----------------------- FUNCIONES PARA CARGAR, OBTENER Y LIMPIAR DATOS DE CAMPOS -----------------------

        private void LimpiarCamposEtapas()
        {
            txtIdEtapa.Text = "";
            txtDescripcionEtapa.Text = "";
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Etapas";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                gdrEtapas.DataSource = table;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private Etapa ObtenerDatosEtapa()
        {
            Etapa etapa = new Etapa();
            etapa.IdEtapa = txtIdEtapa.Text;
            etapa.DescripcionEtapa = txtDescripcionEtapa.Text;

            return etapa;
        }

        private void CargarCampos(Etapa etapa)
        {
            txtIdEtapa.Text = etapa.IdEtapa.ToString();
            txtDescripcionEtapa.Text = etapa.DescripcionEtapa;
        }


        /// ----------------------- AGREGAR ETAPA -----------------------
        private void btnAgregarEtapa_Click(object sender, EventArgs e)
        {
            Etapa etapa = ObtenerDatosEtapa();
            bool resultado = AgregarEtapaABD(etapa);

            if (resultado)
            {
                MessageBox.Show("Etapa agregada con exito");
                LimpiarCamposEtapas();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar etapa");
            }
        }

        
        private bool AgregarEtapaABD(Etapa etapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ETAPAS (descripcion) VALUES (@Descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEtapa", etapa.IdEtapa);
                cmd.Parameters.AddWithValue("@Descripcion", etapa.DescripcionEtapa);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }


        /// ----------------------- MODIFICAR ETAPA -----------------------
        private void gdrEtapas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionadoa = gdrEtapas.Rows[indice];
            string id = filaSeleccionadoa.Cells["id_etapa"].Value.ToString();
            Etapa etapa = ObtenerEtapa(id);
            LimpiarCamposEtapas();
            CargarCampos(etapa);
            btnActualizarEtapa.Enabled = true;
        }

        private Etapa ObtenerEtapa(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Etapa etapa = new Etapa();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ETAPAS where id_etapa like @id";
                cmd.Parameters.AddWithValue("@id", id);




                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    etapa.IdEtapa = dr["id_etapa"].ToString();

                    etapa.DescripcionEtapa = dr["descripcion"].ToString();

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

            return etapa;


        }




        private bool ActualizarEtapaABD(Etapa etapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ETAPAS SET id_etapa = @idEtapa, descripcion = @Descripcion WHERE id_etapa like @idEtapa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEtapa", etapa.IdEtapa);
                cmd.Parameters.AddWithValue("@Descripcion", etapa.DescripcionEtapa);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private void btnActualizarEtapa_Click(object sender, EventArgs e)
        {
            Etapa etapa = ObtenerDatosEtapa();
            bool resultado = ActualizarEtapaABD(etapa);


            if (resultado)
            {
                MessageBox.Show("Etapa actualizada con exito");
                LimpiarCamposEtapas();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar etapa");
            }
        }

        private void btnLimpiarCamposExP_Click(object sender, EventArgs e)
        {
            LimpiarCamposEtapas();
        }

        private void btnEliminarEtapa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar la etapa?", "ELIMINAR ETAPA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Etapa etapa = ObtenerDatosEtapa();
                bool resultado = Eliminar(etapa);


                if (resultado)
                {
                    MessageBox.Show("Etapa eliminada con exito"); 
                    LimpiarCamposEtapas();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar etapa");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private bool Eliminar(Etapa etapa)
        {
            bool resultado2 = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM ETAPAS WHERE  id_etapa = @id_etapa ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_etapa", etapa.IdEtapa);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }

}