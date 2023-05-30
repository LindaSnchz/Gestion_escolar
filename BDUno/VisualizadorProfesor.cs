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
    public partial class VisualizadorProfesor : Form
    {
        SqlConnection Miconexion13;
        public VisualizadorProfesor(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion13 = Miconexion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualizadorProfesor_Load(object sender, EventArgs e)
        {
            Miconexion13.Open();
            string cadena = "SELECT * FROM Profesor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadena, Miconexion13);

            DataSet Conjunto = new DataSet();
            Adaptador.Fill(Conjunto, "PROFESOR");

            VisualizadorDTView.DataSource = Conjunto;
            VisualizadorDTView.DataMember = "PROFESOR";

            Miconexion13.Close();
        }
    }
}
