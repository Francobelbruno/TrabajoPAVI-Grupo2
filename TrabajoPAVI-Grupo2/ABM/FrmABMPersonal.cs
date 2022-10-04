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

namespace TrabajoPAVI_Grupo2.ABM
{
    public partial class FrmABMPersonal : Form
    {
        public FrmABMPersonal()
        {
            InitializeComponent();
        }

        private void FrmABMPersonal_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cargarComboMotivosEgresos();
            comboUsuarios();
            comboBarrios();
            cargarGrilla();
            CargarComboProyectos();
        }

        /*------------------------------- LIMPIAR CAMPOS ----------------------------*/
        private void bttnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            cmbUsuarios.SelectedIndex = -1;
            txtNroCalle.Text = "";
            txtFechaNacimiento.Text = "";
            txtDocumento.Text = "";
            txtApellido.Text = "";
            cmbMotivoEgreso.SelectedIndex = -1;
            cmbBarrios.SelectedIndex = -1;
        }

        private void CargarComboProyectos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                string consulta = "SELECT * FROM Proyectos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbProyecto.DataSource = tabla;
                cmbProyecto.DisplayMember = "Descripcion";
                cmbProyecto.ValueMember = "Codigo";
                cmbProyecto.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
                throw;
            }
            finally
            {
                cn.Close();

            }
        }
        private void cargarComboMotivosEgresos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM MOTIVO_EGRESOS";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbMotivoEgreso.DataSource = tabla;
                cmbMotivoEgreso.DisplayMember = "descripcion";
                cmbMotivoEgreso.ValueMember = "id_motivo";
                cmbMotivoEgreso.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }

        }
        private void comboBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Barrios";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbBarrios.DataSource = tabla;
                cmbBarrios.DisplayMember = "Nombre";
                cmbBarrios.ValueMember = "id_Barrio";
                cmbBarrios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }
        }
        private void comboUsuarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuarios";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbUsuarios.DataSource = tabla;
                cmbUsuarios.DisplayMember = "nombre_Usuario";
                cmbUsuarios.ValueMember = "id_Usuario";
                cmbUsuarios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.UsuarioPersonal = (int)cmbUsuarios.SelectedValue;
            per.LegajoPersonal = int.Parse(txtLegajo.Text.Trim());
            per.DocumentoPersonal = txtDocumento.Text.Trim();
            per.NombrePersonal = txtNombre.Text.Trim();
            per.ApellidoPersonal = txtApellido.Text.Trim();
            per.FechaIngresoPersonal = DateTime.Parse(dateTimeFechaEgreso.Text.Trim());
            per.FechaEgresoPersonal = DateTime.Parse(dateTimeFechaEgreso.Text.Trim());
            per.MotivoEgresoPersonal = (int)cmbMotivoEgreso.SelectedValue;
            per.IdBarrioPersonal = (int)cmbBarrios.SelectedValue;
            per.CallePersonal = txtCalle.Text.Trim();
            per.NroCallePersonal = int.Parse(txtNroCalle.Text.Trim());
            per.FecNacimientoPersonal = DateTime.Parse(txtFechaNacimiento.Text.Trim());
            per.CodigoProyectoPersonal = (int)cmbProyecto.SelectedValue;
            //  per.CodigoProyectoPersonal = int.Parse(txtCodigoProyecto.Text.Trim());


            if (rbttn1.Checked)
            {
                per.TipoDocPersonal = 1;
            }
            else if (rbttn2.Checked)
            {
                per.TipoDocPersonal = 2;
            }
            else
            {
                per.TipoDocPersonal = 3;
            }
            /*AGREGAR PERSONA CON EXITO*/

            try
            {
                bool resultado = AgregarPersonalBD(per);
                if (resultado == true)
                {
                    MessageBox.Show("Persona agregada con exito");
                    cargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al cargar datos...");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private bool AgregarPersonalBD(Personal per)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Personal(Tipo_documento, Nro_Documento, Apellido, Nombres, id_usuario, Fecha_Ingreso, Fecha_Egreso, Motivo_Egreso, Id_Barrio, Calle, Nro_Calle, Fecha_Nacimiento, Cod_Proyecto_asignado) VALUES ( @Tipo_documento, @nro_documento, @Apellido, @Nombres, @id_suario, @Fecha_Ingreso, @Fecha_Egreso, @Motivo_Egreso, @Id_Barrio, @Calle, @Nro_Calle, @Fecha_Nacimiento,@Cod_Proyecto_asignado)";

                cmd.Parameters.AddWithValue("@Tipo_documento", per.TipoDocPersonal);
                cmd.Parameters.AddWithValue("@nro_Documento", per.DocumentoPersonal);
                cmd.Parameters.AddWithValue("@Apellido", per.ApellidoPersonal);
                cmd.Parameters.AddWithValue("@Nombres", per.NombrePersonal);
                cmd.Parameters.AddWithValue("@id_usuario", per.UsuarioPersonal);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", per.FechaIngresoPersonal);
                cmd.Parameters.AddWithValue("@Fecha_Egreso", per.FechaEgresoPersonal);
                cmd.Parameters.AddWithValue("@Motivo_Egreso", per.MotivoEgresoPersonal);
                cmd.Parameters.AddWithValue("@Id_Barrio", per.IdBarrioPersonal);
                cmd.Parameters.AddWithValue("@Calle", per.CallePersonal);
                cmd.Parameters.AddWithValue("@Nro_Calle", per.NroCallePersonal);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", per.FecNacimientoPersonal);
                cmd.Parameters.AddWithValue("@Cod_Proyecto_Asignado", per.CodigoProyectoPersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }
            return resultado;
        }

        private void Eliminar(Personal per)
        {
            bool resultado2 = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Personal WHERE  nro_documento = @nro_documento AND Nombres=@nom";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_documento", per.DocumentoPersonal);
                cmd.Parameters.AddWithValue("@nom", per.NombrePersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.NombrePersonal = txtNombrePersonal.Text.Trim();
            per.DocumentoPersonal = txtDocumentoPersonal.Text.Trim();

            /*ELIMINAR PERSONA CON EXITO*/
            Eliminar(per);
            MessageBox.Show("Personal Eliminado...");
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Legajo, Nombres, Apellido, nro_documento, cod_Proyecto_asignado FROM Personal";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                GrillaDelPersonal.DataSource = tabla;
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
        private void ModificarPersonal(Personal per)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Personal SET Tipo_documento= @Tipo_documento, nro_documento = @nro_documento, Apellido = @Apellido, Nombres = @Nombres, id_usuario = @id_usuario, Fecha_Ingreso = @Fecha_Ingreso, Fecha_Egreso = @Fecha_Egreso, Motivo_Egreso = @Motivo_Egreso, Id_Barrio =  @Id_Barrio, Calle = @Calle, Nro_Calle =  @Nro_Calle, Fecha_Nacimiento = @Fecha_Nacimiento, Cod_Proyecto_asignado = @Cod_Proyecto_asignado";
                
      
                cmd.Parameters.AddWithValue("@Tipo_documento", per.TipoDocPersonal);
                cmd.Parameters.AddWithValue("@nro_Documento", per.DocumentoPersonal);
                cmd.Parameters.AddWithValue("@Apellido", per.ApellidoPersonal);
                cmd.Parameters.AddWithValue("@Nombres", per.NombrePersonal);
                cmd.Parameters.AddWithValue("@id_usuario", per.UsuarioPersonal);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", per.FechaIngresoPersonal);
                cmd.Parameters.AddWithValue("@Fecha_Egreso", per.FechaEgresoPersonal);
                cmd.Parameters.AddWithValue("@Motivo_Egreso", per.MotivoEgresoPersonal);
                cmd.Parameters.AddWithValue("@Id_Barrio", per.IdBarrioPersonal);
                cmd.Parameters.AddWithValue("@Calle", per.CallePersonal);
                cmd.Parameters.AddWithValue("@Nro_Calle", per.NroCallePersonal);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", per.FecNacimientoPersonal);
                cmd.Parameters.AddWithValue("@Cod_Proyecto_Asignado", per.CodigoProyectoPersonal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();


                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.UsuarioPersonal = (int)cmbUsuarios.SelectedValue;
            per.LegajoPersonal = int.Parse(txtLegajo.Text.Trim());
            per.DocumentoPersonal = txtDocumento.Text.Trim();
            per.NombrePersonal = txtNombre.Text.Trim();
            per.ApellidoPersonal = txtApellido.Text.Trim();
            per.FechaIngresoPersonal = DateTime.Parse(dateTimeFechaEgreso.Text.Trim());
            per.FechaEgresoPersonal = DateTime.Parse(dateTimeFechaEgreso.Text.Trim());
            per.MotivoEgresoPersonal = (int)cmbMotivoEgreso.SelectedValue;
            per.IdBarrioPersonal = (int)cmbBarrios.SelectedValue;
            per.CallePersonal = txtCalle.Text.Trim();
            per.NroCallePersonal = int.Parse(txtNroCalle.Text.Trim());
            per.FecNacimientoPersonal = DateTime.Parse(txtFechaNacimiento.Text.Trim());
            // per.CodigoProyectoPersonal = int.Parse(txtCodigoProyecto.Text.Trim());


            if (rbttn1.Checked)
            {
                per.TipoDocPersonal = 1;
            }
            else if (rbttn2.Checked)
            {
                per.TipoDocPersonal = 2;
            }
            else
            {
                per.TipoDocPersonal = 3;
            }
            ModificarPersonal(per);
            cargarGrilla();
        }
    }

}
