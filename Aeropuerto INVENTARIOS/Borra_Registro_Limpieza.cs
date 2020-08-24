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
    public partial class Borra_Registro_Limpieza : Form
    {
        DataTable tabla = new DataTable();
        SqlCommand comando;//insert into, update, select, delete
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Borra_Registro_Limpieza()
        {
            InitializeComponent();
        }

        private void Borra_Registro_Limpieza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Limpiesa' Puede moverla o quitarla según sea necesario.
            this.limpiesaTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Limpiesa);

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
            string consulta = "delete from Limpiesa where id_codigo ='" + id + "'";
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
            string consulta = "delete from Limpiesa where NOMBRE ='" + cm + "'";
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
            // conexion.Open();
            string consulta = "Select id_codigo,NOMBRE  from Limpiesa";
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
                string consulta = "delete from Limpiesa where id_codigo='" + id_codigo + "'";
                comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaprar = new SqlDataAdapter(comando);
                adaprar.Fill(table, "Limpiesa");
                Cargar_Data();
                MessageBox.Show("Se elimino el seguridad correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_Data()
        {
            // conexion.Open();
            string consulta = "Select* from Limpiesa";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
