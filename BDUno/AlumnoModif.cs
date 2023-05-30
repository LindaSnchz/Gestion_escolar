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
    public partial class AlumnoModif : Form
    {
        SqlConnection Miconexion4; 
        public AlumnoModif(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion4 = Miconexion;
        }

        private void AlumnoModif_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarModif_Click(object sender, EventArgs e)
        {
            try
            {
                Miconexion4.Open();
                int DNI_Ctrl = Convert.ToInt32(txtDNICtrl.Text);
                string cadena = "SELECT * FROM ALUMNOS WHERE (DNI= " + DNI_Ctrl + ")";

                SqlCommand comando = new SqlCommand(cadena, Miconexion4);
                SqlDataReader leer = comando.ExecuteReader(); /*Nos permite leer todos los datos*/
                if (leer.Read()) //En caso de si haber leido bien los datos, rellena los txtbox
                {
                    txtDNI.Text = leer["DNI"].ToString();
                    txtNombre.Text = leer["Nombre"].ToString();
                    txtApellido.Text = leer["Apellido"].ToString();
                    txtDireccion.Text = leer["Direccion"].ToString();
                    txtCarrera.Text = leer["Carrera"].ToString();
                    txtSemestre.Text = leer["Semestre"].ToString();

                    Miconexion4.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se ha podido ingresar a los registros", "Alerta");
            }
            finally
            {
                Miconexion4.Close();
            }
        }

        private void btnActualizarModif_Click(object sender, EventArgs e)
        {
            if (txtDNICtrl.Text == "" || txtDNI.Text == "" || txtNombre.Text=="" || txtApellido.Text=="" || txtDireccion.Text == "" || txtCarrera.Text == "" || txtSemestre.Text == "")
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtDNICtrl.Focus();
            }
            else
            {
                try
                {
                    Miconexion4.Open();
                    int DNI = Convert.ToInt32(txtDNI.Text);
                    int DNICTRL = Convert.ToInt32(txtDNICtrl.Text);
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    string Direccion = txtDireccion.Text;
                    string Carrera = txtCarrera.Text;
                    int Semestre = Convert.ToInt32(txtSemestre.Text);
                    string cadena = "UPDATE Alumnos SET Nombre ='" + Nombre + "', Apellido = '" + Apellido + "', Direccion='" + Direccion + "', Carrera='" + Carrera + "', Semestre='" + Semestre + "', DNI=" + DNI + "" + "WHERE (DNI=" + DNICTRL + ");";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion4);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("El alumno ha sido modificado.", "Información");

                    Miconexion4.Close();

                    this.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("No se pudo realizar la modificación", "Alerta");
                }finally
                {
                    Miconexion4.Close();
                }
            }
        }

        private void btnSalirModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
