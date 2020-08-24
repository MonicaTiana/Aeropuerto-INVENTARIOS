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

namespace Aeropuerto_INVENTARIOS
{
    public partial class Login : Form
    {
        public Login()
        {

            Thread tardar = new Thread(new ThreadStart(pantalla));//Se crea un hilo 
            tardar.Start();//Arranca el hilo
            Thread.Sleep(4000);//Se pone a dormir la forma principal 
            InitializeComponent();
            tardar.Abort();//Se finaliza el hilo 
        }


        //Se crea el metodo para correr el SplashScreen
        public void pantalla()
        {
            Application.Run(new SplashScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txt_usuario.Text != "") && (txt_contraseña.Text !=""))
            {
                if ((txt_usuario.Text == "Rafa") && (txt_contraseña.Text == "elrafa") || (txt_usuario.Text == "Monica") && (txt_contraseña.Text == "elrafa") || (txt_usuario.Text == "Evelin") && (txt_contraseña.Text == "elrafa") || (txt_usuario.Text == "Blanca") && (txt_contraseña.Text == "elrafa"))
                {
                    Form1 ir = new Form1();
                    ir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
