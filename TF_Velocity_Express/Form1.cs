using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace TF_Velocity_Express
{
    public partial class Form1 : Form
    {
        //Bitmap^ bmp_fondo;
        nUsuario nusuario = new nUsuario();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tipousuario = nusuario.Iniciar_Sesion(txbUsuario.Text, txbContraseña.Text);
            if (txbUsuario.TextLength>0 && txbContraseña.TextLength>0)
            {
                if (String.IsNullOrEmpty(tipousuario))
                {
                    MessageBox.Show("Datos Incorrectos");
                }
                else
                {
                    this.Hide();
                    FrInicio inicio_usuario = new FrInicio();
                    FrPantallaAdministrador inicio_administrador = new FrPantallaAdministrador();
                    if (tipousuario == "Administrador")
                        inicio_administrador.Show();
                    if (tipousuario == "Usuario")
                        inicio_usuario.Show();
                }
            }
            else
            {
                MessageBox.Show("No dejar los espacio en blanco", "Advertencia");
            }
           
        }
     
          
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrRegistro vtnregistro = new FrRegistro();
            vtnregistro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
