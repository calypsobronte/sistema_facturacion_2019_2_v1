using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_facturacion_2019_2
{
    class Acceso_datos
    {
        SqlConnection conexion_db;
        SqlCommand acceso_datos;
        SqlDataReader array_lector = null;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        // Funcion para acceder a la base de datos
        public void AbrirBd() 
        {
            try // permite captura de un error en caso que se presente una conexion_db fallida
            {
                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de conexión
                conexion_db = new SqlConnection("Data Source=calypsobronte;Initial Catalog=DBFACTURAS;Integrated Security=True");
                conexion_db.Open(); // invocamos método para abrir la base de datos

            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("Conexión fallida. Intenatalo nuevamente." + ex);
            }
        }

        // Funcion para salir de la base de datos
        public void exit_db() 
        {
            try // permite captura de un error en caso que se presente una conexion_db fallida
            {
                conexion_db.Close(); // salida de la db
            }
            catch (Exception ex)// si se tiene fallas sale mensaje
            {
                MessageBox.Show("La conexión fallo al tratar de cerrar. " + ex);
            }
        }

        // Funcion que valida el ingreso del usuario al sistema
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {   
                // Parametros 
                string strEmpleado = "";
                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";

                AbrirBd();

                // Accedemos a los datos que te
                acceso_datos = new SqlCommand(); 
                acceso_datos.Connection = conexion_db;
                acceso_datos.CommandText = sentencia;
                acceso_datos.CommandType = CommandType.Text;
                acceso_datos.CommandTimeout = 10;

                array_lector = acceso_datos.ExecuteReader();

                while (array_lector.Read())
                {
                    strEmpleado = Convert.ToString(array_lector.GetValue(0));
                }
                if (array_lector != null) // cerramos el lector de datos
                {
                    array_lector.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA DE DATOS: " + ex);
                return "";
            }
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE";

            try
            {
                int return_datos;
                AbrirBd();
                acceso_datos = new SqlCommand(sentencia, conexion_db);
                return_datos = acceso_datos.ExecuteNonQuery();
                exit_db();
                if (return_datos > 0)
                {
                    salida = "Los datos fueron actualizados con exito.";
                }
                else
                {
                    salida = "Los datos no fueron actualizados, revise su conexion.";
                }
            }
            catch (Exception ex)
            {
                salida = "Falló la comunicación de datos: " + ex;
            }

            return salida;
        }

        public DataTable cargarTabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string SQL = "SELECT * FROM " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(SQL, conexion_db);
                ds = new DataSet();
                da.Fill(ds, tabla);

                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                exit_db();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        public DataTable EjecutarComandoDatos(string acceso_datos)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(acceso_datos, conexion_db);
                dt = new DataTable();
                da.Fill(dt);
                exit_db();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ LA OPERACIÓN: " + ex.ToString());
                return null;
            }
        }

    }
}
