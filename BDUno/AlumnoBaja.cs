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
    public partial class AlumnoBaja : Form
    {
        SqlConnection Miconexion3;
        public AlumnoBaja(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion3 = Miconexion;
        }

        private void AlumnoBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDNIBaja.Text == "")
            {
                MessageBox.Show("Eliminación no válida. Por favor, ingrese el DNI del alumno.", "Información");
            }
            else
                try
                {
                    Miconexion3.Open();
                    int DNI = Convert.ToInt32(txtDNIBaja.Text);
                    string cadena = "DELETE FROM ALUMNOS WHERE(DNI='" + DNI + "')";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion3);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El alumno ha sido eliminado correctamente", "Información");
                    Miconexion3.Close();

                    DialogResult msg = MessageBox.Show("¿Desea eliminar otro alumno?", "Eliminar  alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    MessageBox.Show("No se pudo eliminar el alumno", "Alerta");
                }

        }

        public void Eliminar()
        {
            txtDNIBaja.Text = "";
            txtDNIBaja.Focus();
        }


    }
}
