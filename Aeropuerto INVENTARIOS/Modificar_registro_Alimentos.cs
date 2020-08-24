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

namespace Aeropuerto_INVENTARIOS
{
    public partial class Modificar_registro_Alimentos : Form
    {
        SqlCommand comando;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Modificar_registro_Alimentos()
        {
            InitializeComponent();
            comboBoxarea.Text = "Seleccionar";
            comboBoxdepa.Text = "Seleccionar";
            comboBoxtipo.Text = "Seleccionar";
            comboBoxtipoinv.Text = "Seleccionar";
        }
        public void Habilitar()
        {
            lbl_codigo.Enabled = true;
            txtnombre.Enabled = true;
            txtcantidad.Enabled = true;
            txtprecio.Enabled = true;
            comboBoxarea.Enabled = true;
            comboBoxdepa.Enabled = true;
            txtmarca.Enabled = true;
            txtmodelo.Enabled = true;
            comboBoxtipoinv.Enabled = true;
            comboBoxtipo.Enabled = true;
            txt_fecha.Enabled = true;
            btn_guardar.Enabled = true;
        }
        public void Deshabilitar()
        {
            lbl_codigo.Enabled = false;
            txtnombre.Enabled = false;
            txtcantidad.Enabled = false;
            txtprecio.Enabled = false;
            comboBoxarea.Enabled = false;
            comboBoxdepa.Enabled = false;
            txtmarca.Enabled = false;
            txtmodelo.Enabled = false;
            comboBoxtipoinv.Enabled = false;
            comboBoxtipo.Enabled = false;
            txt_fecha.Enabled = false;
            btn_guardar.Enabled = false;
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Registro_Alimentos regresar = new Registro_Alimentos();
            regresar.Show();
            this.Close();
        }
        private void Modificar_registro_Alimentos_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            DataTable dato1 = Cargar_tipo_inv();
            foreach (DataRow filas in dato1.Rows)
            {
                comboBoxtipoinv.Items.Add(Convert.ToString(filas["TIPO_INVENTARIO"]));
            }
            DataTable dato2 = Cargar_tipo();
            foreach (DataRow filas in dato2.Rows)
            {
                comboBoxtipo.Items.Add(Convert.ToString(filas["TIPO"]));
            }
            DataTable dato3 = Cargar_area();
            foreach (DataRow filas in dato3.Rows)
            {
                comboBoxarea.Items.Add(Convert.ToString(filas["AREA"]));
            }
            DataTable dato4 = Cargar_depa();
            foreach (DataRow filas in dato4.Rows)
            {
                comboBoxdepa.Items.Add(Convert.ToString(filas["DEPARTAMENTO"]));
            }
        }
        private DataTable Cargar_tipo_inv()
        {
            string consulta = "select TIPO_INVENTARIO from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        private DataTable Cargar_area()
        {
            string consulta = "select AREA from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        private DataTable Cargar_depa()
        {
            string consulta = "select DEPARTAMENTO from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        private DataTable Cargar_tipo()
        {
            string consulta = "select TIPO from Alimentos" +
                "";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        public void Actualizar(int id)
        {
            conexion.Open();
            //si el id es autoincremental nunca lo vamos a poder actualizar
            string consulta = "update Alimentos set NOMBRE = @NOMBRE, CANTIDAD = @CANTIDAD, PRECIO = @PRECIO, AREA = @AREA, DEPARTAMENTO = @DEPARTAMENTO, MARCA = @MARCA, MODELO = @MODELO, TIPO_INVENTARIO = @TIPO_INV, TIPO = @TIPO, FECHA = @FECHA where id_codigo =  " + id;
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add(new SqlParameter("@NOMBRE", txtnombre.Text));
            comando.Parameters.Add(new SqlParameter("@CANTIDAD", txtcantidad.Text));
            comando.Parameters.Add(new SqlParameter("@PRECIO", txtprecio.Text));
            comando.Parameters.Add(new SqlParameter("@AREA", comboBoxarea.Text));
            comando.Parameters.Add(new SqlParameter("@DEPARTAMENTO", comboBoxdepa.Text));
            comando.Parameters.Add(new SqlParameter("@MARCA", txtmarca.Text));
            comando.Parameters.Add(new SqlParameter("@MODELO", txtmodelo.Text));
            comando.Parameters.Add(new SqlParameter("@TIPO_INV", comboBoxtipoinv.Text));
            comando.Parameters.Add(new SqlParameter("@TIPO", comboBoxtipo.Text));
            comando.Parameters.Add(new SqlParameter("@FECHA", txt_fecha.Text));
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void BuscarID(int id)
        {
            conexion.Open();
            DataSet tabla = new DataSet();
            string consulta = "select * from Alimentos where id_codigo = " + id;
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla, "Alimentos");
            lbl_codigo.Text = tabla.Tables["Alimentos"].Rows[0][0].ToString();
            txtnombre.Text = tabla.Tables["Alimentos"].Rows[0][1].ToString();
            txtcantidad.Text = tabla.Tables["Alimentos"].Rows[0][2].ToString();
            txtprecio.Text = tabla.Tables["Alimentos"].Rows[0][3].ToString();
            comboBoxarea.Text = tabla.Tables["Alimentos"].Rows[0][4].ToString();
            comboBoxdepa.Text = tabla.Tables["Alimentos"].Rows[0][5].ToString();
            txtmarca.Text = tabla.Tables["Alimentos"].Rows[0][6].ToString();
            txtmodelo.Text = tabla.Tables["Alimentos"].Rows[0][7].ToString();
            comboBoxtipoinv.Text = tabla.Tables["Alimentos"].Rows[0][8].ToString();
            comboBoxtipo.Text = tabla.Tables["Alimentos"].Rows[0][9].ToString();
            txt_fecha.Text = tabla.Tables["Alimentos"].Rows[0][10].ToString();
            conexion.Close();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscar_codigo.Text != string.Empty)
            {
                BuscarID(Convert.ToInt16(txt_buscar_codigo.Text));
                Habilitar();
                txt_buscar_codigo.Enabled = false;
                txt_buscar_marca.Enabled = false;
                txt_buscar_nombre.Enabled = false;
                btn_buscar.Enabled = false;
            }
            else if (txt_buscar_nombre.Text != string.Empty)
            {

            }
            else if (txt_buscar_marca.Text != string.Empty)
            {

            }
            else
            {
                MessageBox.Show("Dato incorrecto o no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            txt_buscar_codigo.Enabled = true;
            txt_buscar_marca.Enabled = true;
            txt_buscar_nombre.Enabled = true;
            Deshabilitar();
            Actualizar(Convert.ToInt16(lbl_codigo.Text));
        }

        private void btn_buscar_MouseHover(object sender, EventArgs e)
        {
            btn_buscar.BackColor = Color.LightGreen;

        }

        private void btn_buscar_MouseLeave(object sender, EventArgs e)
        {
            btn_buscar.BackColor = Color.Transparent;
        }

        private void btn_guardar_MouseHover(object sender, EventArgs e)
        {
            btn_guardar.BackColor = Color.LightGreen;
        }

        private void btn_guardar_MouseLeave(object sender, EventArgs e)
        {
            btn_guardar.BackColor = Color.Transparent;
        }

        private void btn_volver_MouseHover(object sender, EventArgs e)
        {
            btn_volver.BackColor = Color.LightGreen;

        }

        private void btn_volver_MouseLeave(object sender, EventArgs e)
        {

            btn_volver.BackColor = Color.Transparent;
        }

        private void txt_fecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_buscar_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscar_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo letras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo letras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
