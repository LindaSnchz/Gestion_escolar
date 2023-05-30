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
    public partial class Form1 : Form
    {
        SqlConnection Miconexion = new SqlConnection("Data Source=LAPTOP-HKJ7G8S5\\SQLEXPRESS;database=BDUno;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }


        private void menuAlumnoAgregar_Click(object sender, EventArgs e)
        {
            AlumnoAlt AA = new AlumnoAlt(Miconexion);
            AA.Show();
        }

    

        private void menuAlumnoEliminar_Click(object sender, EventArgs e)
        {
            AlumnoBaja AB = new AlumnoBaja(Miconexion);
            AB.Show();
        }

        private void menuAlumnoActualizar_Click(object sender, EventArgs e)
        {
            AlumnoModif AC = new AlumnoModif(Miconexion);
            AC.Show();
        }

        private void menuAlumnoListado_Click(object sender, EventArgs e)
        {
            VisualizadorAlumn AD = new VisualizadorAlumn(Miconexion);
            AD.Show();
        }

        private void menuMateriasAgregar_Click(object sender, EventArgs e)
        {
            MateriaAlt BA = new MateriaAlt(Miconexion);
            BA.Show();
        }

        private void menuMateriasEliminar_Click(object sender, EventArgs e)
        {
            MateriaBaja BB = new MateriaBaja(Miconexion);
            BB.Show();
        }

        private void menuMateriasActualizar_Click(object sender, EventArgs e)
        {
            MateriaModif BC = new MateriaModif(Miconexion);
            BC.Show();
        }

        private void menuMateriasListado_Click(object sender, EventArgs e)
        {
            VisualizadorMaterias BD = new VisualizadorMaterias(Miconexion);
            BD.Show();
        }

        private void menuProfesoresAgregar_Click(object sender, EventArgs e)
        {
            ProfesorAlta CA = new ProfesorAlta(Miconexion);
            CA.Show();
        }

        private void menuProfesoresEliminar_Click(object sender, EventArgs e)
        {
            ProfesorBaja CB = new ProfesorBaja(Miconexion);
            CB.Show();
        }

        private void menuProfesoresActualizar_Click(object sender, EventArgs e)
        {
            ProfesorModif CC = new ProfesorModif(Miconexion);
            CC.Show();
        }

        private void menuProfesoresListado_Click(object sender, EventArgs e)
        {
            VisualizadorProfesor CD = new VisualizadorProfesor(Miconexion);
            CD.Show();
        }
    }
}
