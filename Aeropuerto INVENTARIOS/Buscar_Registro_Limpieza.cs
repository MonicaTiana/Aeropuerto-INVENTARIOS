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
    public partial class Buscar_Registro_Limpieza : Form
    {
        SqlCommand comando;//insert into, update, select, delete
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Buscar_Registro_Limpieza()
        {
            InitializeComponent();
        }

        private void Buscar_Registro_Limpieza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Limpiesa' Puede moverla o quitarla según sea necesario.
            this.limpiesaTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Limpiesa);
            cargar_data(dataGridView1);
            // DataTable dato1 = new DataTable();
            DataTable dato1 = cargar_comonombre();
            foreach (DataRow fila in dato1.Rows)
            {
                combo_nombre.Items.Add(Convert.ToString(fila["NOMBRE"]));
            }
            DataTable dato2 = cargar_comoarea();
            foreach (DataRow fila in dato2.Rows)
            {
                combo_area.Items.Add(Convert.ToString(fila["AREA"]));
            }
            DataTable dato3 = cargar_comodepa();
            foreach (DataRow fila in dato3.Rows)
            {
                combo_departamneto.Items.Add(Convert.ToString(fila["DEPARTAMENTO"]));
            }

        }

        private void btv_volver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        public void cargar_data(DataGridView Mostrar)
        {
            conexion.Open();
            string consulta = "Select* from Limpiesa";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            Mostrar.DataSource = tabla;

            conexion.Close();

        }
        private DataTable cargar_comonombre()
        {
            string consulta = "Select distinct NOMBRE from Limpiesa";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comoarea()
        {
            string consulta = "Select distinct  AREA from Limpiesa";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comodepa()
        {
            string consulta = "Select distinct  Departamento from Limpiesa";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }

        private void combo_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Limpiesa where NOMBRE like '%" + combo_nombre.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Limpiesa");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Limpiesa";
            conexion.Close();
        }

        private void combo_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Limpiesa where AREA like '%" + combo_area.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Limpiesa");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Limpiesa";
            conexion.Close();
        }

        private void combo_departamneto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Limpiesa where DEPARTAMENTO like '%" + combo_departamneto.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Limpiesa");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Limpiesa";
            conexion.Close();
        }

    }
}
