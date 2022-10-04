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
    public partial class ABMProductos : Form
    {
        public ABMProductos()
        {
            InitializeComponent();
        }

        /*---------------------------------------INSERTAR PRODUCTOS--------------------------------------------------------------*/
        private bool InsertarProducto(string denominacion, string descripcion, string fechaFin)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Productos (Denominacion, Descripcion, FecFinDesarrollo ) VALUES (@denominacion, @descripcion, @fecfindesarrollo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", denominacion);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@fecfindesarrollo", fechaFin);
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

        /*---------------------------------------ACTUALIZAR CIUDADES--------------------------------------------------------------*/
        private void ActualizarProducto()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Productos SET Denominacion =  @denominacion, Descripcion = @Descripcion, FecFinDesarrollo = @FecFinDesarrollo WHERE CodProducto = @CodProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProducto", txtidProducto.Text);
                cmd.Parameters.AddWithValue("@denominacion", txtDenominacion.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@FecFinDesarrollo", txtFechaFin.Text);
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
        //---------------------------------------BORRAR PRODUCTOS----------------------------------------------------------

        private void BorrarProductos()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Productos WHERE codProducto = @codProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codProducto", txtidProducto.Text);
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




        //---------------------------------------CARGAR GRILLA PRODUCTOS----------------------------------------------------------
        private void CargarGrillaProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Productos";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaProductos.DataSource = tabla;
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

        //---------------------------------------BOTON ACTUALIZAR PRODUCTOS----------------------------------------------

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
            MessageBox.Show("Actualizado con éxito");
            CargarGrillaProductos();
        }



        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos();
            LimpiarCampos();
            btnGuardarProducto.Visible = true;
            btnActualizarProducto.Visible = false;
            btnEliminarProducto.Visible = false;
        }

        //---------------------------------------BOTON GUARDAR PRODUCTOS----------------------------------------------------------
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtDenominacion.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                try
                {
                    bool resultado = InsertarProducto(txtDenominacion.Text, txtDescripcion.Text, txtFechaFin.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Dado de alta con éxito!");
                        CargarGrillaProductos();
                        LimpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el producto 1");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar el producto" + ex.Message);
                }



            }
        }
        //---------------------------------------BOTON ELIMINAR PRODUCTOS----------------------------------------------------------
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            BorrarProductos();
            MessageBox.Show("Eliminado con éxito");
            CargarGrillaProductos();
        }

        //---------------------------------------BOTON LIMPIAR CAMPOS----------------------------------------------
        private void LimpiarCampos()
        {
            txtDenominacion.Text = "";
            txtDescripcion.Text = "";
            txtFechaFin.Text = "";
        }
        //---------------------------------------LOAD GRILLA PRODUCTOS-------------------------------------------------------
        private void Productos_Load(object sender, EventArgs e)
        {
            CargarGrillaProductos();
        }

        //---------------------------------------------Cargar campo seleccionado--------------------------------------------
        private void grillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtidProducto.Text = grillaProductos.CurrentRow.Cells[0].Value.ToString();
                txtDenominacion.Text = grillaProductos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = grillaProductos.CurrentRow.Cells[2].Value.ToString();
                txtFechaFin.Text = grillaProductos.CurrentRow.Cells[3].Value.ToString();
            }

            catch
            {
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos();
            LimpiarCampos();
            btnGuardarProducto.Visible = false;
            btnActualizarProducto.Visible = true;
            btnEliminarProducto.Visible = false;
        }

        private void btnElimOpc_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos();
            LimpiarCampos();
            btnGuardarProducto.Visible = false;
            btnActualizarProducto.Visible = false;
            btnEliminarProducto.Visible = true;
        }
        //--------------------Obtener Listado productos---------------------------------
        public static DataTable ObtenerListadoProductos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);



            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Productos";
                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblIdProducto_Click(object sender, EventArgs e)
        {

        }

        private void txtDenominacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblDenominacion_Click(object sender, EventArgs e)
        {

        }
    }

}

