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
    public partial class Buscar_Alimento : Form
    {
        SqlCommand comando;
        DataTable tabla = new DataTable();
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public Buscar_Alimento()
        {
            InitializeComponent();
            combo_area.Text = "Seleccionar";
            combo_departamento.Text = "Seleccionar";
            combo_nombre.Text = "Seleccionar";
        }

        private void Buscar_Alimento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Alimentos' Puede moverla o quitarla según sea necesario.
            this.alimentosTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Alimentos);
            Cargar_data(dataGridView1);
            DataTable dato1 = Cargar_nombre();
            foreach (DataRow fila in dato1.Rows)
            {
                combo_nombre.Items.Add(Convert.ToString(fila["NOMBRE"]));
            }
            DataTable dato2 = Cargar_area();
            foreach (DataRow fila in dato2.Rows)
            {
                combo_area.Items.Add(Convert.ToString(fila["AREA"]));
            }
            DataTable dato3 = Cargar_depa();
            foreach (DataRow fila in dato3.Rows)
            {
                combo_departamento.Items.Add(Convert.ToString(fila["DEPARTAMENTO"]));
            }
        }
        private DataTable Cargar_nombre()
        {
            string consulta = "Select distinct NOMBRE from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable Cargar_area()
        {
            string consulta = "Select distinct  AREA from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable Cargar_depa()
        {
            string consulta = "Select distinct  DEPARTAMENTO from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }

        public void Cargar_data(DataGridView Mostrar)
        {
            conexion.Open();
            string consulta = "Select* from Alimentos";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            Mostrar.DataSource = tabla;
            conexion.Close();
        }

        private void combo_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Alimentos where NOMBRE like '%" + combo_nombre.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Alimentos");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Alimentos";
            conexion.Close();
        }

        private void combo_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Alimentos where AREA like '%" + combo_area.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Alimentos");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Alimentos";
            conexion.Close();
        }

        private void combo_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Alimentos where DEPARTAMENTO like '%" + combo_departamento.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Alimentos");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Alimentos";
            conexion.Close();
        }

        private void btv_volver_Click(object sender, EventArgs e)
        {
            Registro_Alimentos volver = new Registro_Alimentos();
            volver.Show();
            this.Close();
        }

        private void btv_volver_MouseHover(object sender, EventArgs e)
        {
            btv_volver.BackColor = Color.LightGreen;

        }

        private void btv_volver_MouseLeave(object sender, EventArgs e)
        {

            btv_volver.BackColor = Color.Transparent;
        }
    }
}