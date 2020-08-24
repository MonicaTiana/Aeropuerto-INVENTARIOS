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
    public partial class Modificar_Registro_Seguridad : Form
    {
        SqlCommand comando;//insert into, update, select, delete
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Modificar_Registro_Seguridad()
        {
            InitializeComponent();
        }

        private void Modificar_Registro_Seguridad_Load(object sender, EventArgs e)
        {
            deshabilitar();
            DataTable dato1 = cargar_comoarea();
            foreach (DataRow fila in dato1.Rows)
            {
                comboBoxarea.Items.Add(Convert.ToString(fila["AREA"]));
            }
            DataTable dato2 = cargar_comodepa();
            foreach (DataRow fila in dato2.Rows)
            {
                comboBoxdepa.Items.Add(Convert.ToString(fila["DEPARTAMENTO"]));
            }
            DataTable dato3 = cargar_combotipoinv();
            foreach (DataRow fila in dato3.Rows)
            {
                comboBoxtipoinv.Items.Add(Convert.ToString(fila["TIPO_INVENTARIO"]));
            }
            DataTable dato4 = cargar_comobotipo();
            foreach (DataRow fila in dato4.Rows)
            {
                comboBoxtipo.Items.Add(Convert.ToString(fila["TIPO"]));
            }
            DataTable dato5 = cargar_comoarea1();
            foreach (DataRow fila in dato5.Rows)
            {
                comboarea1.Items.Add(Convert.ToString(fila["AREA"]));
            }
        }
        private void deshabilitar()
        {
            lb_Codigo.Enabled = false;
            txtnombre.Enabled = false;
            txtcantidad.Enabled = false;
            txtprecio.Enabled = false;
            comboBoxarea.Enabled = false;
            comboBoxdepa.Enabled = false;
            txtmarca.Enabled = false;
            txtmodelo.Enabled = false;
            comboBoxtipoinv.Enabled = false;
            comboBoxtipo.Enabled = false;
        }
        private void habilitar()
        {

            lb_Codigo.Enabled = true;
            txtnombre.Enabled = true;
            txtcantidad.Enabled = true;
            txtprecio.Enabled = true;
            comboBoxarea.Enabled = true;
            comboBoxdepa.Enabled = true;
            txtmarca.Enabled = true;
            txtmodelo.Enabled = true;
            comboBoxtipoinv.Enabled = true;
            comboBoxtipo.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txtcodigo1.Text == "")
            {
                errorProvider1.SetError(txtcodigo1, "ingresa el codigo");
                txtcodigo1.Focus();
                return;
            }
            errorProvider1.SetError(txtcodigo1, "");
            //if (txtnom1.Text == "")
            //{
            //    errorProvider1.SetError(txtnom1, "Ingres el nombre");
            //    txtnom1.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txtnom1, "");
            //if (comboarea1.Text == "")
            //{
            //    errorProvider1.SetError(comboarea1, "Selecciona una opcion");
            //    comboarea1.Focus();
            //    return;
            //}
            //errorProvider1.SetError(comboarea1, "");
            if (txtcodigo1.Text != string.Empty)
            {

                buscar_codigo(Convert.ToInt16(txtcodigo1.Text));
                habilitar();
                txtcodigo1.Enabled = false;
                txtnom1.Enabled = false;
                comboarea1.Enabled = false;
                btn_buscar.Enabled = false;



            }
            else if (txtnom1.Text != string.Empty)
            {

            }
            else if (comboarea1.Text != string.Empty)
            {

            }
            else
            {
                MessageBox.Show("Dato incorrecto");
            }
        }
        private void actualizar(int Codigo)
        {
            conexion.Open();
            string consulta = "UPDATE Seguridad set  NOMBRE=@NOMBRE, CANTIDAD=@Cantidad,PRECIO=@Precio, AREA=@Area,DEPARTAMENTO=@Departamento, MARCA=@Marca,MODELO=@Modelo,TIPO_INVENTARIO=@TI,TIPO=@Tipo,FECHA=@Fecha where id_codigo=" + Codigo;
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.Add(new SqlParameter("@NOMBRE", txtnombre.Text));
            comando.Parameters.Add(new SqlParameter("@Cantidad", txtcantidad.Text));
            comando.Parameters.Add(new SqlParameter("@Precio", txtprecio.Text));
            comando.Parameters.Add(new SqlParameter("@Area", comboBoxarea.Text));
            comando.Parameters.Add(new SqlParameter("@Departamento", comboBoxdepa.Text));
            comando.Parameters.Add(new SqlParameter("@Marca", txtmarca.Text));
            comando.Parameters.Add(new SqlParameter("@Modelo", txtmodelo.Text));
            comando.Parameters.Add(new SqlParameter("@TI", comboBoxtipoinv.Text));
            comando.Parameters.Add(new SqlParameter("@Tipo", comboBoxtipo.Text));
            comando.Parameters.Add(new SqlParameter("@Fecha", txt_fecha.Text));
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        private DataTable cargar_comoarea()
        {
            string consulta = "Select distinct  AREA from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comoarea1()
        {
            string consulta = "Select distinct  AREA from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comodepa()
        {
            string consulta = "Select distinct  DEPARTAMENTO from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_combotipoinv()
        {
            string consulta = "Select distinct TIPO_INVENTARIO from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comobotipo()
        {
            string consulta = "Select distinct TIPO from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            deshabilitar();
            txtcodigo1.Enabled = true;
            txtnom1.Enabled = true;
            comboarea1.Enabled = true;
            btn_buscar.Enabled = true;
            actualizar(Convert.ToInt16(txtcodigo1.Text));
            txtcantidad.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            comboBoxarea.Text = "";
            comboBoxdepa.Text = "";
            comboBoxtipoinv.Text = "";
            comboBoxtipo.Text = "";
        }
        private void buscar_codigo(int codigo)
        {
            conexion.Open();
            DataSet tabla = new DataSet();
            string consulta = "select * from Seguridad where id_codigo=" + codigo;
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Seguridad");

            lb_Codigo.Text = tabla.Tables["Seguridad"].Rows[0][0].ToString();
            txtnombre.Text = tabla.Tables["Seguridad"].Rows[0][1].ToString();
            txtcantidad.Text = tabla.Tables["Seguridad"].Rows[0][2].ToString();
            txtprecio.Text = tabla.Tables["Seguridad"].Rows[0][3].ToString();
            comboBoxarea.Text = tabla.Tables["Seguridad"].Rows[0][4].ToString();
            comboBoxdepa.Text = tabla.Tables["Seguridad"].Rows[0][5].ToString();
            txtmarca.Text = tabla.Tables["Seguridad"].Rows[0][6].ToString();
            txtmodelo.Text = tabla.Tables["Seguridad"].Rows[0][7].ToString();
            comboBoxtipoinv.Text = tabla.Tables["Seguridad"].Rows[0][8].ToString();
            comboBoxtipo.Text = tabla.Tables["Seguridad"].Rows[0][9].ToString();
            txt_fecha.Text = tabla.Tables["Seguridad"].Rows[0][10].ToString();
            conexion.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
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

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcodigo1_KeyPress(object sender, KeyPressEventArgs e)
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
