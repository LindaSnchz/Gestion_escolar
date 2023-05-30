using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDUno
{
    public partial class AlumnoAlt : Form
    {
        SqlConnection Miconexion2;
        public AlumnoAlt(SqlConnection Miconexion)  /*Le agregamos la conexion con el Miconexion hecho en el form1*/
        {
            InitializeComponent();
            Miconexion2= Miconexion;
        }

        private void btnGuardarAlum_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtCarrera.Text ==  "" || txtSemestre.Text == "") /*el if chequea que todos los datos esten completos*/
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtDNI.Focus();
            }
            else //si estan completos, tratara de ingresarlos a la bd
            {
                try
                {
                    Miconexion2.Open(); /*se abre la conexio*/

                    int DNI = Convert.ToInt32(txtDNI.Text);
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    string Direccion = txtDireccion.Text;
                    string Carrera = txtCarrera.Text;
                    int Semestre = Convert.ToInt32(txtSemestre.Text);

                    string cadena = "insert into Alumnos(DNI, Nombre, Apellido, Direccion, Carrera, Semestre) values" + "('" + DNI + "', '" + Nombre + "', '" + Apellido + "', '" + Direccion + "', '" + Carrera + "', '" + Semestre + "');";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion2);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han guardado correctamente.");

                    Miconexion2.Close(); /*una vez guardados los datos ingresados, se cierra la conexion*/

                    DialogResult msg = MessageBox.Show("¿Desea ingresar otro alumno?", "Ingresar  alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        Inicializar();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("No se pudo realizar la operación", "Alerta");
                }
                finally{
                    Miconexion2.Close() ;
                }
            }
        }

        public void Inicializar()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCarrera.Text = "";
            txtSemestre.Text = "";

            txtDNI.Focus();
        }

        private void btnSalirAlum_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
