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
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();
            dt = Acceso.cargarTabla("TBLEMPLEADO", "");

            cbEmpleado.DataSource = dt;
            cbEmpleado.DisplayMember = "strNombre";
            cbEmpleado.ValueMember = "IdEmpleado";
            Acceso.exit_db();
        }

        //Funcion para validar los datos ingresados
        private bool Validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar un valor de usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtUsuario, "");
            }

            if (txtClave.Text == string.Empty)
            {
                MensajeError.SetError(txtClave, "Debe ingresar un valor de cédula");
                txtClave.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtClave, "");
            }

            return errorCampos;
        }

        private bool EsNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;

            if (Validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Seguridad '{Convert.ToInt32(cbEmpleado.SelectedValue)}','{txtUsuario.Text}','{txtClave.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','admin'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló inserción " + ex);
                    actualizado = false;
                }
            }

            return actualizado;
        }

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_seguridad '{Convert.ToInt32(cbEmpleado.SelectedValue)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
        
        public void Consultar()
        {
            _ = new DataTable();
            string sentencia = "Select StrUsuario, StrClave From TBLSEGURIDAD where IdEmpleado=" + cbEmpleado.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos();
            DataTable dt = Acceso.EjecutarComandoDatos(sentencia);

            if (dt.Rows.Count > 0)
            {
                txtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtUsuario.Text = "";
                txtClave.Text = "";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("¿Desea salir de la edición?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                Close();
            }
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _ = Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
