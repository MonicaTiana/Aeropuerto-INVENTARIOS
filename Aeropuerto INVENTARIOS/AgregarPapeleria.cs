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
    public partial class AgregarPapeleria : Form
    {
        SqlCommand comando;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public AgregarPapeleria()
        {
            InitializeComponent();
            comboBoxdepa.Items.Add("Departamento de servicios");
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

        private void AgregarPapeleria_Load(object sender, EventArgs e)
        {
            string consulta = "Select distinct AREA from Papeleria";
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
                comando = new SqlCommand("INSERT INTO Papeleria(NOMBRE,CANTIDAD, PRECIO, AREA, DEPARTAMENTO,MARCA,MODELO,TIPO_INVENTARIO, TIPO, FECHA) VALUES('" + this.txtnombre.Text + "','" + this.txtcantidad.Text + "','" + this.txtprecio.Text + "','" + this.comboBoxarea.Text + "','" + this.comboBoxdepa.Text + "','" + this.txtmarca.Text + "','" + this.txtmodelo.Text + "','" + this.comboBoxtipoinv.Text + "','" + this.comboBoxtipo.Text + "','" + this.txt_fecha.Text + "')", conexion);
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

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txtprecio.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txt_fecha.Clear();
            Num_serie.Text = "";
            comboBoxarea.Text = "Seleccionar";
            comboBoxdepa.Text = "Seleccionar";
            comboBoxtipo.Text = "Seleccionar";
            comboBoxtipoinv.Text = "Seleccionar";
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                errorProvider1.SetError(txtnombre, "Ingrese el nombre");
                txtnombre.Focus();
                return;
            }
            errorProvider1.SetError(txtnombre, "");
            if (txtcantidad.Text == "")
            {
                errorProvider1.SetError(txtcantidad, "Ingrese la cantidad");
                txtcantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtcantidad, "");
            if (txtprecio.Text == "")
            {
                errorProvider1.SetError(txtprecio, "Ingrese el precio");
                txtprecio.Focus();
                return;
            }
            errorProvider1.SetError(txtprecio, "");
            if (txtmarca.Text == "")
            {
                errorProvider1.SetError(txtmarca, "Ingrese la marca");
                txtmarca.Focus();
                return;
            }
            errorProvider1.SetError(txtmarca, "");
            if (txtmodelo.Text == "")
            {
                errorProvider1.SetError(txtmodelo, "Ingrese el modelo");
                txtmodelo.Focus();
                return;
            }
            errorProvider1.SetError(txtmodelo, "");
            if (comboBoxarea.Text == "")
            {
                errorProvider1.SetError(comboBoxarea, "Seleccione un dato");
                comboBoxarea.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxarea, "");
            if (comboBoxdepa.Text == "")
            {
                errorProvider1.SetError(comboBoxdepa, "Seleccione un dato");
                comboBoxdepa.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxdepa, "");
            if (comboBoxtipoinv.Text == "")
            {
                errorProvider1.SetError(comboBoxtipoinv, "Seleccione un dato");
                comboBoxtipoinv.Focus();
                return;
            }
            errorProvider1.SetError(comboBoxtipoinv, "");
            if (comboBoxtipo.Text == "")
            {
                errorProvider1.SetError(comboBoxtipo, "Seleccione un dato");
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

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (txt_fecha.Text != string.Empty)
            {

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
    }

}
