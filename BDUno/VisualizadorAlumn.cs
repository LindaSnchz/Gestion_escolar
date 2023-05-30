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
    public partial class VisualizadorAlumn : Form
    {
        SqlConnection Miconexion5;
        public VisualizadorAlumn(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion5 = Miconexion;
        }

        private void Visualizador_Load(object sender, EventArgs e)
        {
            Miconexion5.Open();
            string cadena = "SELECT * FROM ALUMNOS";
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadena, Miconexion5);

            DataSet Conjunto = new DataSet();
            Adaptador.Fill(Conjunto, "ALUMNOS");

            VisualizadorDTView.DataSource = Conjunto;
            VisualizadorDTView.DataMember = "ALUMNOS";

            Miconexion5.Close();
        }

        private void btnSalirVisualizador_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
