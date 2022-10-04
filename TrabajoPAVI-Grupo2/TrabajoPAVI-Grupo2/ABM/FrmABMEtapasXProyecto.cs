using TPPAV1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace TPPAV1
{
    public partial class FrmABMEtapasXProyecto : Form
    {
        public FrmABMEtapasXProyecto()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboCodProyecto();
            CargarComboEtapa();
            btnActualizarEtapaXProyecto.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT cod_proyecto, id_etapa, fecha_inicio, fecha_fin FROM ETAPASxPROYECTO ORDER BY cod_proyecto ASC";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                gdrEtapasXProyecto.DataSource = table;

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

        private EtapaXProyecto ObtenerDatosEtapaXProyecto()
        {
            EtapaXProyecto ExP = new EtapaXProyecto();
            ExP.CodProductoEtapaXProyecto = (int)cmbCodProyecto.SelectedValue;
            ExP.IdEtapaXProyecto = cmbEtapa.SelectedValue.ToString();
            ExP.FechaInicioEtapaXProyecto = DateTime.Parse(txtFechaInicio.Text);
            ExP.FechaFinEtapaXProyecto = DateTime.Parse(txtFechaFin.Text);

            return ExP;
        }

        private void CargarComboCodProyecto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT codigo FROM PROYECTOS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCodProyecto.DataSource = tabla;
                cmbCodProyecto.DisplayMember = "codigo";
                cmbCodProyecto.ValueMember = "codigo";
                cmbCodProyecto.SelectedIndex = -1;



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

        private void CargarComboEtapa()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id_etapa FROM ETAPAS";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbEtapa.DataSource = tabla;
                cmbEtapa.DisplayMember = "id_etapa";
                cmbEtapa.ValueMember = "id_etapa";
                cmbEtapa.SelectedIndex = -1;



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
        private void FormABMEtapasXProyecto_Load(object sender, EventArgs e)
        {

        }



        /// ------------- AGREGAR ETAPA X PROYECTO -------------


        private bool AgregarEtapaXProyectoABD(EtapaXProyecto etapaXProyecto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ETAPASxProyecto (cod_proyecto, id_etapa, fecha_inicio, fecha_fin) VALUES (@cod_proyecto, @idEtapa, @fecha_inicio, @fecha_fin)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_proyecto", etapaXProyecto.CodProductoEtapaXProyecto);
                cmd.Parameters.AddWithValue("@idEtapa", etapaXProyecto.IdEtapaXProyecto);
                cmd.Parameters.AddWithValue("@fecha_inicio", etapaXProyecto.FechaInicioEtapaXProyecto);
                cmd.Parameters.AddWithValue("@fecha_fin", etapaXProyecto.FechaFinEtapaXProyecto);

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

        private void brnAgregarEtapaXProyecto_Click_1(object sender, EventArgs e)
        {
            EtapaXProyecto etapaXProyecto = ObtenerDatosEtapaXProyecto();
            bool resultado = AgregarEtapaXProyectoABD(etapaXProyecto);
            if (resultado)
            {
                MessageBox.Show("Etapa por Proyecto agregada con exito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar etapa por Proyecto");
            }

        }

        private void btnLimpiarCamposExP_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmbEtapa.SelectedIndex = -1;
            cmbCodProyecto.SelectedIndex = -1;
        }

        /// --------- ACTUALIZAR ETAPA X PROYECTO ----------


        private void gdrEtapasXProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionadoa = gdrEtapasXProyecto.Rows[indice];
            int cod_proyecto = int.Parse(filaSeleccionadoa.Cells["cod_proyecto"].Value.ToString());
            string id_etapa = filaSeleccionadoa.Cells["id_etapa"].Value.ToString();
            EtapaXProyecto etapaXProyecto = ObtenerEtapaXProyecto(cod_proyecto, id_etapa);
            LimpiarCampos();
            CargarCampos(etapaXProyecto);
            btnActualizarEtapaXProyecto.Enabled = true;
        }

        private EtapaXProyecto ObtenerEtapaXProyecto(int cod_proyecto, string id_etapa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            EtapaXProyecto etapaXProyecto = new EtapaXProyecto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ETAPASxPROYECTO WHERE cod_proyecto like @cod_proyecto AND id_etapa like @id_etapa";
                cmd.Parameters.AddWithValue("@cod_proyecto", cod_proyecto);
                cmd.Parameters.AddWithValue("@id_etapa", id_etapa);




                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    etapaXProyecto.CodProductoEtapaXProyecto = int.Parse(dr["cod_proyecto"].ToString());

                    etapaXProyecto.IdEtapaXProyecto = dr["id_etapa"].ToString();

                    if (dr["fecha_inicio"].ToString().Equals("")){
                        etapaXProyecto.FechaInicioEtapaXProyecto = DateTime.Parse("11/11/2222");
                    }
                    else
                    {
                        etapaXProyecto.FechaInicioEtapaXProyecto = DateTime.Parse(dr["fecha_inicio"].ToString());
                    }


                    if (dr["fecha_fin"].ToString().Equals(""))
                    {
                        etapaXProyecto.FechaFinEtapaXProyecto = DateTime.Parse("11/11/2222");
                    }
                    else
                    {
                        etapaXProyecto.FechaFinEtapaXProyecto = DateTime.Parse(dr["fecha_fin"].ToString());
                    }
                    
                   

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

            return etapaXProyecto;
        }

        private void CargarCampos(EtapaXProyecto etapaXProyecto)
        {

            /// ----- Paso fecha inicio a string -----
            DateTime fechaInicio = etapaXProyecto.FechaInicioEtapaXProyecto;
            if (fechaInicio.Equals(DateTime.Parse("11/11/2222")))
            {
                txtFechaInicio.Text = "";
            }
            else
            {
                string dia = "";
                string mes = "";
                string año = "";

                dia = fechaInicio.Date.Day.ToString();
                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }

                mes = fechaInicio.Date.Month.ToString();
                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                año = fechaInicio.Date.Year.ToString();
                txtFechaInicio.Text = dia + mes + año;
            }
            

            /// ----- Paso fecha fin a string -----
            DateTime fechaFin = etapaXProyecto.FechaFinEtapaXProyecto;
            if (fechaFin.Equals(DateTime.Parse("11/11/2222")))
            {
                txtFechaFin.Text = "";
            }
            else
            {
                string dia2 = "";
                string mes2 = "";
                string año2 = "";

                dia2 = fechaFin.Date.Day.ToString();
                if (dia2.Length == 1)
                {
                    dia2 = "0" + dia2;
                }

                mes2 = fechaFin.Date.Month.ToString();
                if (mes2.Length == 1)
                {
                    mes2 = "0" + mes2;
                }

                año2 = fechaFin.Date.Year.ToString();

                txtFechaFin.Text = dia2 + mes2 + año2;
            }
            


            cmbCodProyecto.SelectedValue = etapaXProyecto.CodProductoEtapaXProyecto;
            cmbEtapa.SelectedValue = etapaXProyecto.IdEtapaXProyecto;
        }

        private bool ActualizarEtapaXProyectoABD(EtapaXProyecto etapaXProyecto)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ETAPASxProyecto SET cod_proyecto = @cod_proyecto, id_etapa = @idEtapa, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin WHERE cod_proyecto like @cod_proyecto AND id_etapa like @idEtapa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_proyecto", etapaXProyecto.CodProductoEtapaXProyecto);
                cmd.Parameters.AddWithValue("@idEtapa", etapaXProyecto.IdEtapaXProyecto);
                cmd.Parameters.AddWithValue("@fecha_inicio", etapaXProyecto.FechaInicioEtapaXProyecto);
                cmd.Parameters.AddWithValue("@fecha_fin", etapaXProyecto.FechaFinEtapaXProyecto);


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


        private void btnActualizarEtapaXProyecto_Click(object sender, EventArgs e)
        {
            EtapaXProyecto etapaXProyecto = ObtenerDatosEtapaXProyecto();
            bool resultado = ActualizarEtapaXProyectoABD(etapaXProyecto);


            if (resultado)
            {
                MessageBox.Show("Etapa por Proyecto actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar Etapa por Proyecto");
            }
        }
        /// ---------- ELIMINAR ----------

        private bool Eliminar(EtapaXProyecto etapaXProyecto)
        {
            bool resultado2 = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM ETAPASxPROYECTO WHERE cod_proyecto = @cod_proyecto AND  id_etapa = @id_etapa ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_proyecto", etapaXProyecto.CodProductoEtapaXProyecto);
                cmd.Parameters.AddWithValue("@id_etapa", etapaXProyecto.IdEtapaXProyecto);

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

        private void btnEliminarEtapa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere eliminar la etapa de un proyecto?", "ELIMINAR ETAPA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EtapaXProyecto etapaXProyecto = ObtenerDatosEtapaXProyecto(); 
                bool resultado = Eliminar(etapaXProyecto);


                if (resultado)
                {
                    MessageBox.Show("Etapa de proyecto eliminada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar etapa de proyecto");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}