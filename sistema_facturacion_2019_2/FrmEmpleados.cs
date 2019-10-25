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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();
            dt = Acceso.cargarTabla("TBLEMPLEADO","");
            dgEmpleados.DataSource = dt;

            dt = Acceso.cargarTabla("TBLROLES", "");
            cbCargo.DataSource = dt;
            cbCargo.DisplayMember = "StrDescripcion";
            cbCargo.ValueMember = "IdRolEmpleado";
        }

        //Funcion para validar los datos ingresados
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del empleado");
                txtNombre.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombre, "");
            }

            if (txtDocumento.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el número de documento del empleado");
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
                    string sentencia = $"Exec actualizar_Empleado '{txtNombre.Text}','{txtDocumento.Text}','{txtDireccion.Text}','{txtTelefono.Text}','{txtEmail.Text}','{Convert.ToInt32(cbCargo.SelectedValue)}','{DateTime.Now.ToString("MM-dd-yyyy")}','{DateTime.Now.ToString("MM-dd-yyyy")}','{txtDatosAdicionales.Text}','{DateTime.Now.ToString("MM-dd-yy")}','{"admin"}'";
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

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_empleado '{Convert.ToInt32(txtID.Text)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            LLENAR_GRID();
            Nuevo();
        }

        public void Nuevo()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cbCargo.SelectedIndex = 0;
            dtFechaIngreso.Value = DateTime.Now;
            dtFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
            txtDatosAdicionales.Text = "";
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

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgEmpleados.CurrentRow.Index;
            txtID.Text = dgEmpleados[0, posActual].Value.ToString();
            txtNombre.Text = dgEmpleados[1, posActual].Value.ToString();
            txtDocumento.Text = dgEmpleados[2, posActual].Value.ToString();
            txtDireccion.Text = dgEmpleados[3, posActual].Value.ToString();
            txtTelefono.Text = dgEmpleados[4, posActual].Value.ToString();
            txtEmail.Text = dgEmpleados[5, posActual].Value.ToString();
            cbCargo.SelectedIndex = Convert.ToInt16(dgEmpleados[6, posActual].Value.ToString())-1;
            dtFechaIngreso.Value = Convert.ToDateTime(dgEmpleados[7, posActual].Value.ToString());
            dtFechaRetiro.Value = Convert.ToDateTime(dgEmpleados[8, posActual].Value.ToString());
            txtDatosAdicionales.Text = dgEmpleados[9, posActual].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
