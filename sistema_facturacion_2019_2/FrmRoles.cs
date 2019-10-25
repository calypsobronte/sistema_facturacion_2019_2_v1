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
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();

            dt = Acceso.cargarTabla("TBLROLES", "");
            dgRoles.DataSource = dt;

        }

        public void Nuevo()
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            txtDetalle.Text = "";
        }

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Rol '{Convert.ToInt32(txtID.Text)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            LLENAR_GRID();
            Nuevo();
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtDescripcion.Text == string.Empty)
            {
                MensajeError.SetError(txtDescripcion, "Debe ingresar el Rol");
                txtDescripcion.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDescripcion, "");
            }

            MensajeError.SetError(txtDescripcion, "");

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
                    string sentencia = $"Exec actualizar_Rol '{Convert.ToInt16(txtID.Text)}','{txtDescripcion.Text}','{txtDetalle.Text}'";
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

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgRoles.CurrentRow.Index;
            txtID.Text = dgRoles[0, posActual].Value.ToString();
            txtDescripcion.Text = dgRoles[1, posActual].Value.ToString();
            txtDetalle.Text = dgRoles[2, posActual].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
