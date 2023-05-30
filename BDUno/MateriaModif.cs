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
    public partial class MateriaModif : Form
    {
        SqlConnection Miconexion8;
        public MateriaModif(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion8 = Miconexion;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Miconexion8.Open();
                int IDCtrl = Convert.ToInt32(txtIDCtrl.Text);
                string cadena = "SELECT * FROM Materias WHERE (ID_Materias= " + IDCtrl + ")";

                SqlCommand comando = new SqlCommand(cadena, Miconexion8);
                SqlDataReader leer = comando.ExecuteReader(); /*Nos permite leer todos los datos*/
                if (leer.Read()) //En caso de si haber leido bien los datos, rellena los txtbox
                {
                    txtID.Text = leer["ID_Materias"].ToString();
                    txtNombre.Text = leer["Nombre"].ToString();
                    txtCarrera.Text = leer["Carrera"].ToString();

                    Miconexion8.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se ha podido ingresar a los registros", "Alerta");
            }
            finally
            {
                Miconexion8.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDCtrl.Text == "" || txtID.Text == "" || txtNombre.Text == "" || txtCarrera.Text == "")
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtIDCtrl.Focus();
            }
            else
            {
                try
                {
                    Miconexion8.Open();
                    int ID = Convert.ToInt32(txtID.Text);
                    int IDCTRL = Convert.ToInt32(txtIDCtrl.Text);
                    string Nombre = txtNombre.Text;
                    string Carrera = txtCarrera.Text;
                    string cadena = "UPDATE Materias SET Nombre ='" + Nombre + "', Carrera='" + Carrera + "', ID_Materias=" + ID + "" + "WHERE (ID_Materias=" + IDCTRL + ");";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion8);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("La materia se ha modificado. ", "Información");

                    Miconexion8.Close();

                    DialogResult msg = MessageBox.Show("¿Desea modificar otra materia?", "Modificar materia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    MessageBox.Show("No se pudo realizar la modificación", "Alerta");
                }
                finally
                {
                    Miconexion8.Close();
                }
            }
        }
        public void Inicializar()
        {
            txtIDCtrl.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtCarrera.Text = "";

            txtIDCtrl.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
