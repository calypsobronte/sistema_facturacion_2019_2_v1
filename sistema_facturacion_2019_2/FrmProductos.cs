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
    public partial class FrmProductos : Form
    {
        public bool cargado = false;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            _ = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();

            DataTable dt = Acceso.cargarTabla("TBLPRODUCTO", "");
            dgProductos.DataSource = dt;

            dt = Acceso.cargarTabla("TBLCATEGORIA_PROD", "");
            cbCategoria.DataSource = dt;
            cbCategoria.DisplayMember = "StrDescripcion";
            cbCategoria.ValueMember = "idCategoria";

            if (!cargado)
            {
                Consultar();
                cargado = true;
            }
            
        }

        public void Nuevo()
        {
            txtCodigo.Text = "-1";
            txtNombre.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            cbCategoria.SelectedIndex = 0;
            txtDetalle.Text = "";
            txtImagen.Text = "";
            txtImagen.Text = "";
        }

        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Producto '{Convert.ToInt32(txtCodigo.Text)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            LLENAR_GRID();
            Nuevo();
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del producto");
                txtNombre.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombre, "");
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

            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Producto '{txtCodigo.Text}','{txtNombre.Text}','{txtReferencia.Text}','{txtPrecioCompra.Text}','{txtPrecioVenta.Text}','{Convert.ToInt32(cbCategoria.SelectedValue)}','{txtDetalle.Text}','{txtImagen.Text}','{txtCantidad.Text}','{DateTime.Now.ToString("MM-dd-yy")}','{"admin"}'";
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

        public void Consultar()
        {
            _ = new DataTable();
            string sentencia = "Select StrReferencia From TBLCATEGORIA_PROD where idCategoria=" + cbCategoria.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos();
            DataTable dt = Acceso.EjecutarComandoDatos(sentencia);

            if (dt.Rows.Count > 0)
            {
                txtReferencia.Text = dt.Rows[0]["StrReferencia"].ToString();
            }
            else
            {
                MessageBox.Show("No se dispone de datos de ingreso");
                txtReferencia.Text = "";
            }
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            Consultar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void DgProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = dgProductos.CurrentRow.Index;
            txtCodigo.Text = dgProductos[0, posActual].Value.ToString();
            txtNombre.Text = dgProductos[1, posActual].Value.ToString();
            txtReferencia.Text = dgProductos[2, posActual].Value.ToString();
            txtPrecioCompra.Text = dgProductos[3, posActual].Value.ToString();
            txtPrecioVenta.Text = dgProductos[4, posActual].Value.ToString();
            cbCategoria.SelectedIndex = Convert.ToInt16(dgProductos[5, posActual].Value.ToString()) - 1;
            txtDetalle.Text = dgProductos[6, posActual].Value.ToString();
            txtImagen.Text = dgProductos[7, posActual].Value.ToString();
            txtCantidad.Text = dgProductos[8, posActual].Value.ToString();
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                Consultar();
            }
           
        }
    }
}
