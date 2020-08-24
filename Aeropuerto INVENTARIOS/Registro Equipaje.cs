using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;


namespace Aeropuerto_INVENTARIOS
{
    public partial class Registro_Equipaje : Form
    {
        ToolTip tt1 = new ToolTip();
        SqlCommand comando, comando2, comando3, comando4;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");


        public Registro_Equipaje()
        {
            InitializeComponent();

            comboBoxdepa.Text = "Seleccionar";
            comboBoxtipo.Text = "Seleccionar";
            comboBoxarea.Items.Add("Equipaje");
            comboBoxtipoinv.Items.Add("Inventario fijo");
            comboBoxtipoinv.Items.Add("Inventario materia prima ");
        }

        public void Agregar(string tabla)
        {
            try
            {
                conexion.Open();
              //  MessageBox.Show("Conexion establecida con el servidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando = new SqlCommand("INSERT INTO Equipaje(NOMBRE, CANTIDAD, PRECIO, AREA, DEPARTAMENTO, MARCA, MODELO, TIPO_INVENTARIO, TIPO, FECHA) VALUES('" +  this.txtnombre.Text + "','" + this.txtcantidad.Text + "','" + this.txtprecio.Text + "','" + this.comboBoxarea.Text + "','" + this.comboBoxdepa.Text + "','" + this.txtmarca.Text + "','" + this.txtmodelo.Text + "','" + this.comboBoxtipoinv + "','" + this.comboBoxtipo.Text + "','" + this.txt_fecha.Text+ "')", conexion);
                comando.ExecuteNonQuery();
               // MessageBox.Show("Datos guardados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
              //  MessageBox.Show("Se cerró correctamente la sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btn_menu_Click(object sender, EventArgs e)
        //{
        //    M_E_N_U MENU = new M_E_N_U();
        //    MENU.Show();
        //    this.Close();
        //}
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

        private void tooltip(object sender, System.EventHandler e)
        {
            tt1.AutoPopDelay = 5000;
            tt1.InitialDelay = 1000;
            tt1.ReshowDelay = 500;
            tt1.ShowAlways = true;
        }
        public void solo_letras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingresar solo letras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnagregar_MouseHover(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.DarkRed;
        }
        private void btnagregar_MouseLeave(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.Transparent;
        }
        private void btn_menu_MouseHover(object sender, EventArgs e)
        {
            btn_menu.BackColor = Color.DarkRed;
        }
        private void btn_menu_MouseLeave(object sender, EventArgs e)
        {
            btn_menu.BackColor = Color.Transparent;
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



        private void btn_modificar_MouseHover(object sender, EventArgs e)
        {
            btn_modificar.BackColor = Color.DarkRed;
        }

        private void btn_modificar_MouseLeave(object sender, EventArgs e)
        {
            btn_modificar.BackColor = Color.Transparent;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Borrar_Registro_equipaje borrar = new Borrar_Registro_equipaje();
            borrar.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Equipaje buscar = new Buscar_Equipaje();
            buscar.Show();
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
            Modificar_Registro_Equipaje Modificar = new Modificar_Registro_Equipaje();
            Modificar.Show();
            this.Close();
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
        private void Registro_Equipaje_Load(object sender, EventArgs e)
        {
            tt1.SetToolTip(this.txtmodelo, "Ingresa el modelo del equipaje");
            tt1.SetToolTip(this.txtmarca, "Ingresa la marca del equipaje");
            tt1.SetToolTip(this.txtcantidad, "Ingresa la cantidad de maletas");
            tt1.SetToolTip(this.txtnombre, "Ingresa el nombre del dueño");
            tt1.SetToolTip(this.txtprecio, "Ingresa el precio por peso del equipaje extra");
            tt1.SetToolTip(this.txt_fecha, "Ingresa la fecha dd-MM-yyyy");
            //--------------
            //string consulta = "Select distinct AREA from Equipaje";
            //comando = new SqlCommand(consulta, conexion);
            //conexion.Open();
            //SqlDataReader area = comando.ExecuteReader();
            //while (area.Read())
            //{
            //    comboBoxarea.Items.Add(area["AREA"].ToString());
            //}
            //conexion.Close();
            string consulta2 = "Select distinct DEPARTAMENTO from Equipaje";
            comando2 = new SqlCommand(consulta2, conexion);
            conexion.Open();
            SqlDataReader departamento = comando2.ExecuteReader();
            while (departamento.Read())
            {
                comboBoxdepa.Items.Add(departamento["Departamento"].ToString());
            }
            conexion.Close();
            string consulta3 = "Select distinct TIPO_INVENTARIO from Equipaje";
            comando3 = new SqlCommand(consulta3, conexion);
            //conexion.Open();
            //SqlDataReader tipo_inv = comando3.ExecuteReader();
            //while (tipo_inv.Read())
            //{
            //    comboBoxtipoinv.Items.Add(tipo_inv["TIPO_INVENTARIO"].ToString());
            //}
            //conexion.Close();
            string consulta4 = "Select distinct TIPO from Equipaje";
            comando4 = new SqlCommand(consulta4, conexion);
            conexion.Open();
            SqlDataReader tipo = comando4.ExecuteReader();
            while (tipo.Read())
            {
                comboBoxtipo.Items.Add(tipo["TIPO"].ToString());
            }
            conexion.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
           
        }


    }
}
