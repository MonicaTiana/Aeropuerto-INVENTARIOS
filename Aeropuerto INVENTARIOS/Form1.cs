using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeropuerto_INVENTARIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_alimentos_Click(object sender, EventArgs e)
        {
            Registro_Alimentos ir = new Registro_Alimentos();
            ir.Show();
           // this.Close();
        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            Add_Registros_Seguridad ir = new Add_Registros_Seguridad();
            ir.Show();
           // this.Close();
        }

        private void btn_limpieza_Click(object sender, EventArgs e)
        {
            Add_Registros_Limpiesa ir = new Add_Registros_Limpiesa();
            ir.Show();
           // this.Close();
        }

        private void btn_equipaje_Click(object sender, EventArgs e)
        {
            Registro_Equipaje ir = new Registro_Equipaje();
            ir.Show();
            //this.Close();
        }

        private void btn_papeleria_Click(object sender, EventArgs e)
        {
            AgregarPapeleria ir = new AgregarPapeleria();
            ir.Show();
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            AgregarMantenimiento ir = new AgregarMantenimiento();
            ir.Show();
        }
    }
}
