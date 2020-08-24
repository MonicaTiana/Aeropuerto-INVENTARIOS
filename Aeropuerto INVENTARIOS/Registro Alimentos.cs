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
    public partial class Registro_Alimentos : Form
    {
        SqlCommand comando, comando2, comando3, comando4;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        ToolTip tt2 = new ToolTip();
        public Registro_Alimentos()
        {
            InitializeComponent();
            comboBoxarea.Text = "Seleccionar";
            comboBoxdepa.Text = "Seleccionar";
            comboBoxtipo.Text = "Seleccionar";
            comboBoxtipoinv.Items.Add("Inventario fijo");
            comboBoxtipoinv.Items.Add("Inventario materia prima ");
        }

        public void Agregar(string tabla)
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexion establecida con el servidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando = new SqlCommand("INSERT INTO Alimentos(NOMBRE, CANTIDAD, PRECIO, AREA, DEPARTAMENTO, MARCA, MODELO, TIPO_INVENTARIO, TIPO, FECHA) VALUES('"  + this.txtnombre.Text + "','" + this.txtcantidad.Text + "','" + this.txtprecio.Text + "','" + this.comboBoxarea.Text + "','" + this.comboBoxdepa.Text + "','" + this.txtmarca.Text + "','" + this.txtmodelo.Text + "','" + this.comboBoxtipoinv + "','" + this.comboBoxtipo.Text + "','" + this.txt_fecha.Text + "')", conexion);
                comando.ExecuteNonQuery();
               // MessageBox.Show("Datos guardados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
                //MessageBox.Show("Se cerró correctamente la sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
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
                MessageBox.Show("Ingresar solo numeros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
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
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
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
                MessageBox.Show("Ingresar solo numeros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Registro_Alimentos_Load(object sender, EventArgs e)
        {
           
            tt2.SetToolTip(this.txtmodelo, "Ingresa el modelo del alimento");
            tt2.SetToolTip(this.txtmarca, "Ingresa la marca del alimento");
            tt2.SetToolTip(this.txtprecio, "Ingresa el precio por cada alimento");
            tt2.SetToolTip(this.txtcantidad, "Ingresa la cantidad de alimentos");
            tt2.SetToolTip(this.txtnombre, "Ingresa el nombre del alimento");
            tt2.SetToolTip(this.txt_fecha, "Ingresa la fecha dd-MM-yyyy");

            string consulta = "Select distinct AREA from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader area = comando.ExecuteReader();
            while (area.Read())
            {
                comboBoxarea.Items.Add(area["AREA"].ToString());
            }
            conexion.Close();
            string consulta2 = "Select distinct DEPARTAMENTO from Alimentos";
            comando2 = new SqlCommand(consulta2, conexion);
            conexion.Open();
            SqlDataReader departamento = comando2.ExecuteReader();
            while (departamento.Read())
            {
                comboBoxdepa.Items.Add(departamento["Departamento"].ToString());
            }
            conexion.Close();
            string consulta3 = "Select distinct TIPO_INVENTARIO from Alimentos";
            comando3 = new SqlCommand(consulta3, conexion);
            //conexion.Open();
            //SqlDataReader tipo_inv = comando3.ExecuteReader();
            //while (tipo_inv.Read())
            //{
            //    comboBoxtipoinv.Items.Add(tipo_inv["TIPO_INVENTARIO"].ToString());
            //}
            //conexion.Close();
            string consulta4 = "Select distinct TIPO from Alimentos";
            comando4 = new SqlCommand(consulta4, conexion);
            conexion.Open();
            SqlDataReader tipo = comando4.ExecuteReader();
            while (tipo.Read())
            {
                comboBoxtipo.Items.Add(tipo["TIPO"].ToString());
            }
            conexion.Close();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            //    M_E_N_U MENU = new M_E_N_U();
            //    MENU.Show();
            //    this.Close();
        }
        private void btn_modificar_MouseHover(object sender, EventArgs e)
        {
            btn_modificar.BackColor = Color.LightGreen;
        }
        private void btn_modificar_MouseLeave(object sender, EventArgs e)
        {
            btn_modificar.BackColor = Color.Transparent;
        }
        private void btn_borrar_MouseHover(object sender, EventArgs e)
        {
            btn_borrar.BackColor = Color.LightGreen;
        }
        private void btn_borrar_MouseLeave(object sender, EventArgs e)
        {
            btn_borrar.BackColor = Color.Transparent;
        }
        private void btn_buscar_MouseHover(object sender, EventArgs e)
        {
            btn_buscar.BackColor = Color.LightGreen;
        }
        private void btn_buscar_MouseLeave(object sender, EventArgs e)
        {
            btn_buscar.BackColor = Color.Transparent;
        }
        private void btn_eliminar_MouseHover(object sender, EventArgs e)
        {
            btn_eliminar.BackColor = Color.LightGreen;
        }
        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            btn_eliminar.BackColor = Color.Transparent;
        }

        private void btn_menu_MouseHover(object sender, EventArgs e)
        {
            btn_menu.BackColor = Color.LightGreen;
        }
        private void btn_menu_MouseLeave(object sender, EventArgs e)
        {
            btn_menu.BackColor = Color.Transparent; //ml
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
        {
            Form1 ir = new Form1();
            ir.Show();
            this.Close();
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 47)//
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo numeros y diagonal para separar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Modificar_registro_Alimentos ir = new Modificar_registro_Alimentos();
            ir.Show();
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Borrar_registro_alimentos ir = new Borrar_registro_alimentos();
            ir.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Alimento ir = new Buscar_Alimento();
            ir.Show();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            txtprecio.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txt_fecha.Clear();
            comboBoxarea.Text = "Seleccionar";
            comboBoxdepa.Text = "Seleccionar";
            comboBoxtipo.Text = "Seleccionar";
            comboBoxtipoinv.Text = "Seleccionar";
        }

        private void btnagregar_MouseHover_1(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.LightGreen;
        }
        private void btnagregar_MouseLeave_1(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.Transparent;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                errorProvider1.SetError(txtnombre, "ingresa el nombre");
                txtnombre.Focus();
                return;
            }
            errorProvider1.SetError(txtnombre, "");
            if (txtcantidad.Text == "")
            {
                errorProvider1.SetError(txtcantidad, "Ingres la cantidad");
                txtcantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtcantidad, "");
            if (txtprecio.Text == "")
            {
                errorProvider1.SetError(txtprecio, "ingresa el precio");
                txtprecio.Focus();
                return;
            }
            errorProvider1.SetError(txtprecio, "");
            if (txtmarca.Text == "")
            {
                errorProvider1.SetError(txtmarca, "Ingresa la marca");
                txtmarca.Focus();
                return;
            }
            errorProvider1.SetError(txtmarca, "");
            if (txtmodelo.Text == "")
            {
                errorProvider1.SetError(txtmodelo, "ingresa el modelo");
                txtmodelo.Focus();
                return;
            }
            errorProvider1.SetError(txtmodelo, "");
            if (comboBoxarea.Text == "")
            {
                errorProvider1.SetError(comboBoxarea, "Selecciona un dato");
                comboBoxarea.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxarea, "");
            if (comboBoxdepa.Text == "")
            {
                errorProvider1.SetError(comboBoxdepa, "Selecciona un dato");
                comboBoxdepa.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxdepa, "");
            if (comboBoxtipoinv.Text == "")
            {
                errorProvider1.SetError(comboBoxtipoinv, "Selecciona un dato");
                comboBoxtipoinv.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxtipoinv, "");
            if (comboBoxtipo.Text == "")
            {
                errorProvider1.SetError(comboBoxtipo, "Selecciona un dato");
                comboBoxtipo.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxtipo, "");
            if (txt_fecha.Text == "")
            {
                errorProvider1.SetError(txt_fecha, "Seleccione un dato");
                txt_fecha.Focus();
                return;
            }
            errorProvider1.SetError(txt_fecha, "");
            Agregar(txtnombre.Text);
        }
    }
}
