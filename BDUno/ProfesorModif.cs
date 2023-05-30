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
    public partial class ProfesorModif : Form
    {
        SqlConnection Miconexion12;
        public ProfesorModif(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion12 = Miconexion;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Miconexion12.Open();
                int DNICtrl = Convert.ToInt32(txtDNICtrl.Text);
                string cadena = "SELECT * FROM Profesor WHERE (DNI_Prof= " + DNICtrl + ")";

                SqlCommand comando = new SqlCommand(cadena, Miconexion12);
                SqlDataReader leer = comando.ExecuteReader(); /*Nos permite leer todos los datos*/
                if (leer.Read()) //En caso de si haber leido bien los datos, rellena los txtbox
                {
                    txtID.Text = leer["ID_Materia"].ToString();
                    txtDNI.Text = leer["DNI_Prof"].ToString();
                    txtNombre.Text = leer["Nombre"].ToString();
                    txtDireccion.Text = leer["Direccion"].ToString();
                    txtTelefono.Text = leer["Telefono"].ToString();

                    Miconexion12.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se ha podido ingresar a los registros", "Alerta");
            }
            finally
            {
                Miconexion12.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDNICtrl.Text == "" || txtID.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtDNICtrl.Focus();
            }
            else
            {
                try
                {
                    Miconexion12.Open();
                    int DNI = Convert.ToInt32(txtDNI.Text);
                    int DNICTRL = Convert.ToInt32(txtDNICtrl.Text);
                    int ID = Convert.ToInt32(txtID.Text);
                    string Nombre = txtNombre.Text;
                    string Direccion = txtDireccion.Text;
                    string Telefono = txtTelefono.Text;
                    string cadena = "UPDATE Profesor SET DNI_Prof = '" + DNI + "', Nombre ='" + Nombre + "', Direccion='" + Direccion + "', Telefono='" + Telefono + "', ID_Materia=" + ID + "" + "WHERE (DNI_Prof=" + DNICTRL + ");";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion12);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("El profesor se ha modificado.", "Información");

                    Miconexion12.Close();

                    DialogResult msg = MessageBox.Show("¿Desea modificar otro profesor?", "Modificar profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    MessageBox.Show("No se pudo realizar la modificacion", "Alerta");
                }
                finally
                {
                    Miconexion12.Close();
                }
            }
        }
        public void Inicializar()
        {
            txtDNICtrl.Text = "";
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            txtDNICtrl.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}