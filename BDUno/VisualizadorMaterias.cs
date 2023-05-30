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
    public partial class VisualizadorMaterias : Form
    {
        SqlConnection Miconexion9;
        public VisualizadorMaterias(SqlConnection Miconexion)
        {
            InitializeComponent();
            Miconexion9= Miconexion;
        }

        private void VisualizadorMaterias_Load(object sender, EventArgs e)
        {
            Miconexion9.Open();
            string cadena = "SELECT * FROM Materias";
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadena, Miconexion9);

            DataSet Conjunto = new DataSet();
            Adaptador.Fill(Conjunto, "MATERIAS");

            VisualizadorDTView.DataSource = Conjunto;
            VisualizadorDTView.DataMember = "MATERIAS";

            Miconexion9.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
