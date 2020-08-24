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
    public partial class Borrar_registro_alimentos : Form
    {
        SqlCommand comando;
        int contador = 0;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Borrar_registro_alimentos()
        {
            InitializeComponent();
        }

        private void Borrar_registro_alimentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Alimentos' Puede moverla o quitarla según sea necesario.
            this.alimentosTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Alimentos);
        }

        private void Eliminar(int id)
        {
            conexion.Open();
            string consulta = "delete from Alimentos where id_codigo = " + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            contador++;
            conexion.Close();
        }
        private void Cargar_datagrid()
        {
            //dataGridView1.DataSource = tabla;
            string consulta = "select id_codigo, NOMBRE, CANTIDAD, PRECIO, AREA, DEPARTAMENTO, MARCA, MODELO, TIPO_INVENTARIO, TIPO, FECHA from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int id = dataGridView1.SelectedCells[0].RowIndex;//la columna 0 que se este seleccionando del datagrid y no de la bd
                string dato = dataGridView1.Rows[id].Cells[0].Value.ToString();
                if (txt_codigo.Text != "")
                {
                    Eliminar(Convert.ToInt16(txt_codigo.Text));
                    dataGridView1.Update();
                    MessageBox.Show("Se ha eliminado el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debes ingresar el codigo que quieres eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No tienes seleccionado ningun registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Registro_Alimentos volver = new Registro_Alimentos();
            volver.Show();
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Cargar_datagrid();
        }

        private void btn_borrar_MouseHover(object sender, EventArgs e)
        {
            btn_borrar.BackColor = Color.LightGreen;

        }
        private void btn_borrar_MouseLeave(object sender, EventArgs e)
        {
            btn_borrar.BackColor = Color.Transparent; 
        }
        private void btn_actualizar_MouseHover(object sender, EventArgs e)
        {
            btn_actualizar.BackColor = Color.LightGreen;
        }
        private void btn_actualizar_MouseLeave(object sender, EventArgs e)
        {
            btn_actualizar.BackColor = Color.Transparent; //ml
        }
        private void btn_volver_MouseHover(object sender, EventArgs e)
        {
            btn_volver.BackColor = Color.LightGreen;
        }
        private void btn_volver_MouseLeave(object sender, EventArgs e)
        {
            btn_volver.BackColor = Color.Transparent;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
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
