namespace BDUno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnoAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAlumnoEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAlumnoActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAlumnoListado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriasAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMateriasEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMateriasActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMateriasListado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfesoresAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProfesoresEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProfesoresActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProfesoresListado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlumnos,
            this.toolStripMenuItem1,
            this.menuMateria,
            this.toolStripMenuItem2,
            this.menuProfesores,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlumnoAgregar,
            this.toolStripSeparator1,
            this.menuAlumnoEliminar,
            this.toolStripSeparator2,
            this.menuAlumnoActualizar,
            this.toolStripSeparator3,
            this.menuAlumnoListado});
            this.menuAlumnos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(74, 20);
            this.menuAlumnos.Text = "Alumnos";
            // 
            // menuAlumnoAgregar
            // 
            this.menuAlumnoAgregar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAlumnoAgregar.Name = "menuAlumnoAgregar";
            this.menuAlumnoAgregar.Size = new System.Drawing.Size(183, 22);
            this.menuAlumnoAgregar.Text = "Agregar nuevo...";
            this.menuAlumnoAgregar.Click += new System.EventHandler(this.menuAlumnoAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // menuAlumnoEliminar
            // 
            this.menuAlumnoEliminar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAlumnoEliminar.Name = "menuAlumnoEliminar";
            this.menuAlumnoEliminar.Size = new System.Drawing.Size(183, 22);
            this.menuAlumnoEliminar.Text = "Eliminar";
            this.menuAlumnoEliminar.Click += new System.EventHandler(this.menuAlumnoEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // menuAlumnoActualizar
            // 
            this.menuAlumnoActualizar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuAlumnoActualizar.Name = "menuAlumnoActualizar";
            this.menuAlumnoActualizar.Size = new System.Drawing.Size(183, 22);
            this.menuAlumnoActualizar.Text = "Actualizar";
            this.menuAlumnoActualizar.Click += new System.EventHandler(this.menuAlumnoActualizar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // menuAlumnoListado
            // 
            this.menuAlumnoListado.Font = new System.Drawing.Font("Arial", 9F);
            this.menuAlumnoListado.Name = "menuAlumnoListado";
            this.menuAlumnoListado.Size = new System.Drawing.Size(183, 22);
            this.menuAlumnoListado.Text = "Listado de Alumnos";
            this.menuAlumnoListado.Click += new System.EventHandler(this.menuAlumnoListado_Click);
            // 
            // menuMateria
            // 
            this.menuMateria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMateriasAgregar,
            this.toolStripSeparator4,
            this.menuMateriasEliminar,
            this.toolStripSeparator5,
            this.menuMateriasActualizar,
            this.toolStripSeparator6,
            this.menuMateriasListado});
            this.menuMateria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMateria.Name = "menuMateria";
            this.menuMateria.Size = new System.Drawing.Size(73, 20);
            this.menuMateria.Text = "Materias";
            // 
            // menuMateriasAgregar
            // 
            this.menuMateriasAgregar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuMateriasAgregar.Name = "menuMateriasAgregar";
            this.menuMateriasAgregar.Size = new System.Drawing.Size(182, 22);
            this.menuMateriasAgregar.Text = "Agregar nuevo...";
            this.menuMateriasAgregar.Click += new System.EventHandler(this.menuMateriasAgregar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // menuMateriasEliminar
            // 
            this.menuMateriasEliminar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuMateriasEliminar.Name = "menuMateriasEliminar";
            this.menuMateriasEliminar.Size = new System.Drawing.Size(182, 22);
            this.menuMateriasEliminar.Text = "Eliminar";
            this.menuMateriasEliminar.Click += new System.EventHandler(this.menuMateriasEliminar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(179, 6);
            // 
            // menuMateriasActualizar
            // 
            this.menuMateriasActualizar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuMateriasActualizar.Name = "menuMateriasActualizar";
            this.menuMateriasActualizar.Size = new System.Drawing.Size(182, 22);
            this.menuMateriasActualizar.Text = "Actualizar";
            this.menuMateriasActualizar.Click += new System.EventHandler(this.menuMateriasActualizar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(179, 6);
            // 
            // menuMateriasListado
            // 
            this.menuMateriasListado.Font = new System.Drawing.Font("Arial", 9F);
            this.menuMateriasListado.Name = "menuMateriasListado";
            this.menuMateriasListado.Size = new System.Drawing.Size(182, 22);
            this.menuMateriasListado.Text = "Listado de Materias";
            this.menuMateriasListado.Click += new System.EventHandler(this.menuMateriasListado_Click);
            // 
            // menuProfesores
            // 
            this.menuProfesores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProfesoresAgregar,
            this.toolStripSeparator7,
            this.menuProfesoresEliminar,
            this.toolStripSeparator8,
            this.menuProfesoresActualizar,
            this.toolStripSeparator9,
            this.menuProfesoresListado});
            this.menuProfesores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProfesores.Name = "menuProfesores";
            this.menuProfesores.Size = new System.Drawing.Size(86, 20);
            this.menuProfesores.Text = "Profesores";
            // 
            // menuProfesoresAgregar
            // 
            this.menuProfesoresAgregar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuProfesoresAgregar.Name = "menuProfesoresAgregar";
            this.menuProfesoresAgregar.Size = new System.Drawing.Size(196, 22);
            this.menuProfesoresAgregar.Text = "Agregar nuevo...";
            this.menuProfesoresAgregar.Click += new System.EventHandler(this.menuProfesoresAgregar_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(193, 6);
            // 
            // menuProfesoresEliminar
            // 
            this.menuProfesoresEliminar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuProfesoresEliminar.Name = "menuProfesoresEliminar";
            this.menuProfesoresEliminar.Size = new System.Drawing.Size(196, 22);
            this.menuProfesoresEliminar.Text = "Eliminar";
            this.menuProfesoresEliminar.Click += new System.EventHandler(this.menuProfesoresEliminar_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(193, 6);
            // 
            // menuProfesoresActualizar
            // 
            this.menuProfesoresActualizar.Font = new System.Drawing.Font("Arial", 9F);
            this.menuProfesoresActualizar.Name = "menuProfesoresActualizar";
            this.menuProfesoresActualizar.Size = new System.Drawing.Size(196, 22);
            this.menuProfesoresActualizar.Text = "Actualizar";
            this.menuProfesoresActualizar.Click += new System.EventHandler(this.menuProfesoresActualizar_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(193, 6);
            // 
            // menuProfesoresListado
            // 
            this.menuProfesoresListado.Font = new System.Drawing.Font("Arial", 9F);
            this.menuProfesoresListado.Name = "menuProfesoresListado";
            this.menuProfesoresListado.Size = new System.Drawing.Size(196, 22);
            this.menuProfesoresListado.Text = "Listado de Profesores";
            this.menuProfesoresListado.Click += new System.EventHandler(this.menuProfesoresListado_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(10, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(10, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(10, 20);
            this.toolStripMenuItem3.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión escolar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnoAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnoEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnoActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnoListado;
        private System.Windows.Forms.ToolStripMenuItem menuMateria;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasListado;
        private System.Windows.Forms.ToolStripMenuItem menuProfesores;
        private System.Windows.Forms.ToolStripMenuItem menuProfesoresAgregar;
        private System.Windows.Forms.ToolStripMenuItem menuProfesoresEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuProfesoresActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuProfesoresListado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

