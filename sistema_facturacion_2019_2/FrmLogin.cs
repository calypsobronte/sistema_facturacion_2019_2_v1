using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_facturacion_2019_2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnvalidar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontrasena.Text != string.Empty)
            {
                Acceso_datos Acceso = new Acceso_datos();
                string user_welcome = Acceso.ValidarUsuario(txtusuario.Text, txtcontrasena.Text);
                if (user_welcome != "")
                {
                    _ = MessageBox.Show($"Bienvenido {txtusuario.Text} al Sistema de Facturación");
                    //Creamos el objeto delformulario FrmPrincipal
                    FrmPrincipal frmppal = new FrmPrincipal();
                    Hide(); // Ocultamos el formulario login
                    frmppal.Show(); // Mostramos el formulario principal
                }
                else
                {
                    _ = MessageBox.Show("Error al iniciar. Por favor verifique de su Usuario/Contraseña");
                    txtusuario.Text = "";
                    txtcontrasena.Text = "";
                    txtusuario.Focus();
                }

            }
            else
            {
                _ = MessageBox.Show("Debes ingresar su Usuario/Contraseña corretamente");
            }


        }
    }
}
