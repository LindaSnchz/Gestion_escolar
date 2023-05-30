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
    public partial class MateriaAlt : Form
    {
        SqlConnection Miconexion6;
        public MateriaAlt(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion6 = Miconexion;
        }
        private void MateriaAlt_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text=="" || txtCarrera.Text == "")
            {
                MessageBox.Show("Inserción no válida. Por favor, completar los datos en los campos correspondientes.", "Información");
                txtID.Focus();
            }
            else
            {
                try
                {
                    Miconexion6.Open();
                    int ID_Materias = Convert.ToInt32(txtID.Text);
                    string Nombre = txtNombre.Text;
                    string Carrera = txtCarrera.Text;

                    string cadena = "insert into Materias(ID_Materias, Nombre, Carrera) values" + "('" + ID_Materias + "','" + Nombre + "', '" + Carrera + "');";
                    SqlCommand comando = new SqlCommand(cadena, Miconexion6);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han guardado correctamente.");

                    Miconexion6.Close();

                    DialogResult msg = MessageBox.Show("¿Desea añadir otra materia?", "Añadir  materia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        Inicializar();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch(SqlException)
                {
                    MessageBox.Show("No se pudo realizar la operación.", "Alerta");
                }
                finally
                {
                    Miconexion6.Close();
                }
            }
        }

        public void Inicializar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCarrera.Text = "";

            txtID.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
