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
    public partial class MateriaBaja : Form
    {
        SqlConnection Miconexion7;
        public MateriaBaja(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion7 = Miconexion;
        }

        private void MateriaBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Eliminación no válida. Por favor, ingrese el ID de la materia a eliminar.", "Información");
            }
            else
                try
                {
                    Miconexion7.Open();
                    int ID_Materias = Convert.ToInt32(txtID.Text);
                    string cadena = "DELETE FROM Materias WHERE(ID_Materias='" + ID_Materias + "')";

                    SqlCommand comando = new SqlCommand(cadena, Miconexion7);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("La materia ha sido eliminada correctamente", "Información");
                    Miconexion7.Close();

                    DialogResult msg = MessageBox.Show("¿Desea eliminar otra materia?", "Eliminar  materia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    Miconexion7.Close() ;
                }

        }

        public void Eliminar()
        {
            txtID.Text = "";
            txtID.Focus();
        }

    }
}

