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
    public partial class BorrarMantenimiento : Form
    {
        SqlCommand comando;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public BorrarMantenimiento()
        {
            InitializeComponent();
        }

        private void BorrarMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Mantenimento' Puede moverla o quitarla según sea necesario.
            this.mantenimentoTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Mantenimento);

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (txt_numserie.Text != "" && txtnom.Text == "")
            {
                if (eliminar(Convert.ToInt16(txt_numserie.Text)))
                {
                    MessageBox.Show("Se elimino el dato correctamnete");
                    cargar_data();
                }
                else
                {
                    MessageBox.Show("No se elimino el dato");
                }
            }
            if (txt_numserie.Text == "" && txtnom.Text != "")
            {
                if (eliminar_compañia(Convert.ToString(txtnom.Text)))
                {
                    MessageBox.Show("Se elimino el dato correctamnete");
                    cargar_data();
                }
                else
                {
                    MessageBox.Show("No se elimino el dato");
                }
            }
            if (txt_numserie.Text == "" && txtnom.Text == "")
            {
                MessageBox.Show("Ingresa un dato para eliminarlo");

            }
            if (txt_numserie.Text != "" && txtnom.Text != "")
            {
                MessageBox.Show("Elija un solo dato");
            }
        }
        private bool eliminar(int id)
        {
            conexion.Open();
            string consulta = "delete from Mantenimento where id_codigo ='" + id + "'";
            comando = new SqlCommand(consulta, conexion);
            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool eliminar_compañia(string cm)
        {
            conexion.Open();
            string consulta = "delete from Mantenimento where NOMBRE ='" + cm + "'";
            comando = new SqlCommand(consulta, conexion);
            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cargar_data()
        {
            string consulta = "Select id_codigo,NOMBRE  from Mantenimento";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataSet table = new DataSet();
                string id_codigo;
                id_codigo = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                conexion.Open();
                string consulta = "delete from Mantenimento where id_codigo='" + id_codigo + "'";
                comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaprar = new SqlDataAdapter(comando);
                adaprar.Fill(table, "Mantenimento");
                Cargar_Data();
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_Data()
        {
            string consulta = "Select* from Mantenimento";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_numserie_KeyPress(object sender, KeyPressEventArgs e)
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
