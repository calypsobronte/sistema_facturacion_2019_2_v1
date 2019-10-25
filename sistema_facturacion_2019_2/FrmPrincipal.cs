using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace sistema_facturacion_2019_2
{
    //Aca le vamos a decir que va a heredar de MaterialSkin Forms y no de form
    public partial class FrmPrincipal : MaterialForm //Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Creamos un nuevo metodo en el cual nos ayudara a abrir diferentes formularios por medio de los contenedores que creamos por medio de pnlCoontenedor
        private void AbrirForm(Form frmHijo)
        {
            if (pblContenedor.Controls.Count > 0)
            {
                this.pblContenedor.Controls.RemoveAt(0);
            }

            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            pblContenedor.Controls.Add(frmHijo);
            frmHijo.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        //Salir de la aplicación
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Mostrar clientes desde el formulario FrmClientes
        // Para esto importamos el Formulario que hemos creado
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmclientes = new FrmClientes();
            AbrirForm(frmclientes);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            AbrirForm(frmproductos);
        }

        private void BtnCatergoria_Click(object sender, EventArgs e)
        {
            FrmCategorias frmcategoria = new FrmCategorias();
            AbrirForm(frmcategoria);
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            FrmFacturas frmfacturas = new FrmFacturas();
            AbrirForm(frmfacturas);
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes frminformes = new FrmInformes();
            AbrirForm(frminformes);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmempleados = new FrmEmpleados();
            AbrirForm(frmempleados);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new FrmRoles();
            AbrirForm(frmroles);
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            FrmSeguridad frmseguridad = new FrmSeguridad();
            AbrirForm(frmseguridad);
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmayuda = new FrmAyuda();
            AbrirForm(frmayuda);
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            FrmAcerca frmacerca = new FrmAcerca();
            AbrirForm(frmacerca);
        }
    }
}
