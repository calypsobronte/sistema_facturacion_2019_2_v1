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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();
            dt = Acceso.cargarTabla("TBLCLIENTES", "");
            dgClientes.DataSource = dt;
        }

        public void Nuevo()
        {
            txtIDCliente.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Cliente '{Convert.ToInt32(txtIDCliente.Text)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            LLENAR_GRID();
            Nuevo();
        }

        //Funcion para validar los datos ingresados
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombre, "");
            }

            if (txtDocumento.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el número de documento del cliente");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumento, "");
            }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El documento debe ser númerico");
                txtDocumento.Focus();
                return false;
            }

            MensajeError.SetError(txtDocumento, "");

            return errorCampos;
        }

        private bool esNumerico(string num)
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

            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Cliente '{txtNombre.Text}','{txtDocumento.Text}','{txtDireccion.Text}','{txtTelefono.Text}','{txtEmail.Text}','{DateTime.Now.ToString("MM-dd-yy")}','{"admin"}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    LLENAR_GRID();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("¿Desea salir de la edición?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dgClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgClientes.CurrentRow.Index;
            txtIDCliente.Text = dgClientes[0, posActual].Value.ToString();
            txtNombre.Text = dgClientes[1, posActual].Value.ToString();
            txtDocumento.Text = dgClientes[2, posActual].Value.ToString();
            txtDireccion.Text = dgClientes[3, posActual].Value.ToString();
            txtTelefono.Text = dgClientes[4, posActual].Value.ToString();
            txtEmail.Text = dgClientes[5, posActual].Value.ToString();
        }
    }
}
