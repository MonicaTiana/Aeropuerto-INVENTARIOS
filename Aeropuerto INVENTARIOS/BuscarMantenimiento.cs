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
    public partial class BuscarMantenimiento : Form
    {
        SqlCommand comando;//insert into, update, select, delete
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-91HEBB2\\SQLEXPRESS;Initial Catalog=Aeropuerto_Inventarios1;Integrated Security=True");
        public BuscarMantenimiento()
        {
            InitializeComponent();
        }

        private void BuscarMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aeropuerto_Inventarios1DataSet.Mantenimento' Puede moverla o quitarla según sea necesario.
            this.mantenimentoTableAdapter.Fill(this.aeropuerto_Inventarios1DataSet.Mantenimento);
            cargar_data(dataGridView1);
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
            string consulta = "Select* from Mantenimento";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            Mostrar.DataSource = tabla;
            conexion.Close();
        }
        private DataTable cargar_comonombre()
        {
            string consulta = "Select distinct NOMBRE from Mantenimento";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comoarea()
        {
            string consulta = "Select distinct  AREA from Mantenimento";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            return tabla;
        }
        private DataTable cargar_comodepa()
        {
            string consulta = "Select distinct  Departamento from Mantenimento";
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
            string consulta = "select *from Mantenimento where NOMBRE like '%" + combo_nombre.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Mantenimento");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Mantenimento";
            conexion.Close();
        }

        private void combo_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Mantenimento where AREA like '%" + combo_area.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Mantenimento");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Mantenimento";
            conexion.Close();
        }

        private void combo_departamneto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet tabla = new DataSet();
            conexion.Open();
            string consulta = "select *from Mantenimento where DEPARTAMENTO like '%" + combo_departamneto.SelectedItem.ToString() + "%'";
            comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            adaptar.Fill(tabla, "Mantenimento");
            dataGridView1.DataSource = tabla;
            dataGridView1.DataMember = "Mantenimento";
            conexion.Close();
        }
    }
}
