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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();
            dt = Acceso.cargarTabla("TBLCATEGORIA_PROD", "");
            dgCategorias.DataSource = dt;
        }

        public void Nuevo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_CategoriaProd '{Convert.ToInt32(txtID.Text)}'";
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
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del empleado");
                txtNombre.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombre, "");
            }

            if (txtCodigo.Text == string.Empty)
            {
                MensajeError.SetError(txtCodigo, "Debe ingresar el código para la categoría");
                txtCodigo.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCodigo, "");
            }

            if (!esNumerico(txtCodigo.Text))
            {
                MensajeError.SetError(txtCodigo, "El código debe ser númerico");
                txtCodigo.Focus();
                return false;
            }

            MensajeError.SetError(txtCodigo, "");

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
                    string sentencia = $"Exec actualizar_CategoriaProd '{txtID.Text}','{txtCodigo.Text}','{txtNombre.Text}','{DateTime.Now.ToString("MM-dd-yy")}','{"admin"}'";
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

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dgEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgCategorias.CurrentRow.Index;
            txtID.Text = "ID: "+dgCategorias[0, posActual].Value.ToString();
            txtCodigo.Text = "Código Referencia: " +dgCategorias[1, posActual].Value.ToString();
            txtNombre.Text = "Nombre Categoría: "+dgCategorias[2, posActual].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
