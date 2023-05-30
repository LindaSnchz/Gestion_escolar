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
    public partial class ProfesorAlta : Form
    {
        SqlConnection Miconexion10;
        public ProfesorAlta(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion10 = Miconexion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "") /*el if chequea que todos los datos esten completos*/
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtID.Focus();
            }
            else //si estan completos, tratara de ingresarlos a la bd
            {
                try
                {
                    Miconexion10.Open(); /*se abre la conexio*/

                    int ID = Convert.ToInt32(txtID.Text);
                    int DNI = Convert.ToInt32(txtDNI.Text);
                    string Nombre = txtNombre.Text;
                    string Direccion = txtDireccion.Text;
                    string Telefono = txtTelefono.Text;

                    string cadena = "insert into Profesor(ID_Materia, DNI_Prof, Nombre, Direccion, Telefono) values" + "('" + ID + "', '" + DNI + "', '" + Nombre + "', '" + Direccion + "', '" + Telefono + "');";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion10);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han guardado correctamente.");

                    Miconexion10.Close(); /*una vez guardados los datos ingresados, se cierra la conexion*/

                    DialogResult msg = MessageBox.Show("¿Desea ingresar otro profesor?", "Ingresar  profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                finally
                {
                    Miconexion10.Close();
                }
            }
        }
        public void Inicializar()
        {
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            txtID.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
