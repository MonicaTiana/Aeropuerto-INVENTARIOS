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
    public partial class Add_Registros_Seguridad : Form
    {
        SqlCommand comando;//insert into, update, select, delete
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Add_Registros_Seguridad()
        {
            InitializeComponent();
            comboBoxdepa.Items.Add("Departamento de seguridad ");
            comboBoxtipo.Items.Add("ALTO");
            comboBoxtipo.Items.Add("MEDIO");
            comboBoxtipo.Items.Add("INERMEDIO");
            comboBoxtipo.Items.Add("BAJO");
            comboBoxtipoinv.Items.Add("Inventario fijo");
            comboBoxtipoinv.Items.Add("Inventario materia prima ");
            comboBoxarea.Items.Add("Registo de equipaje");
            comboBoxarea.Items.Add("Logistica");
            comboBoxarea.Items.Add("Personal");
            comboBoxarea.Items.Add("Inventarios");
            comboBoxarea.Items.Add("Venta de boletos");

        }

        private void Add_Registros_Seguridad_Load(object sender, EventArgs e)
        {
            string consulta = "Select distinct AREA from Seguridad";
            comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader area = comando.ExecuteReader();
            while (area.Read())
            {
                comboBoxarea.Items.Add(area["AREA"].ToString());

            }

            conexion.Close();
        }
        public void agregar(string tabla)
        {
            try
            {

                conexion.Open();
                MessageBox.Show("Conexion establecida con el servidor");
                //  DateTime date.Value{get; set;}
                comando = new SqlCommand("INSERT INTO Seguridad(NOMBRE,CANTIDAD, PRECIO, AREA, DEPARTAMENTO,MARCA,MODELO,TIPO_INVENTARIO, TIPO, FECHA) VALUES('" + this.txtnombre.Text + "','" + this.txtcantidad.Text + "','" + this.txtprecio.Text + "','" + this.comboBoxarea.Text + "','" + this.comboBoxdepa.Text + "','" + this.txtmarca.Text + "','" + this.txtmodelo.Text + "','" + this.comboBoxtipoinv.Text + "','" + this.comboBoxtipo.Text + "','" + this.txt_fecha.Text + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados exitosamente");
                conexion.Close();
                MessageBox.Show("Se cerró correctamente la sesión");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
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
            agregar(txtnombre.Text);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txtprecio.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txt_fecha.Clear();
            Num_serie.Text = "";
            comboBoxarea.Text = "";
            comboBoxdepa.Text = "";
            comboBoxtipo.Text = "";
            comboBoxtipoinv.Text = "";
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Modificar_Registro_Seguridad ir = new Modificar_Registro_Seguridad();
            ir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrar_Registros_Seguridad ir = new Borrar_Registros_Seguridad();
            ir.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Registro_Seguridad ir = new Buscar_Registro_Seguridad();
            ir.Show();
            this.Close();
        }

        private void comboBoxarea_SelectedIndexChanged(object sender, EventArgs e)
        {

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
