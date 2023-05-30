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
    public partial class ProfesorBaja : Form
    {
        SqlConnection Miconexion11;
        public ProfesorBaja(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion11 = Miconexion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Eliminación no válida. Por favor, ingrese el DNI del profesor a eliminar.", "Información");
            }
            else
                try
                {
                    Miconexion11.Open();
                    int DNI = Convert.ToInt32(txtDNI.Text);
                    string cadena = "DELETE FROM Profesor WHERE(DNI_Prof='" + DNI + "')";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion11);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El profesor ha sido eliminado correctamente", "Información");
                    Miconexion11.Close();

                    DialogResult msg = MessageBox.Show("¿Desea eliminar otro profesor?", "Eliminar  profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        Eliminar();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Alerta");
                }
                finally
                {
                    Miconexion11.Close();
                }

        }

        public void Eliminar()
        {
            txtDNI.Text = "";
            txtDNI.Focus();
        }
    }
}

