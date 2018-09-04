using SISTEMATALLERES.Recursos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SISTEMATALLERES
{
    public partial class Menu : Form
    {
        Login a = new Login();
        public string Pkeyy="";
        public Menu()
        {
            InitializeComponent();
            var form = Application.OpenForms.OfType<AC>().FirstOrDefault();
            AC hijo = form ?? new AC();
            AddFormInPanel(hijo);

        }
        private void Form1_Load(object sender, EventArgs e) { }

        #region BOTONES
        private void button3_Click(object sender, EventArgs e)
        {//Registro de alumno
            Cerrar();
            var form = Application.OpenForms.OfType<RegistroAlumno>().FirstOrDefault();
            RegistroAlumno hijo = form ?? new RegistroAlumno();
            AddFormInPanel(hijo);
        }

        private void button10_Click(object sender, EventArgs e)
        {//Registro de taller a un alumno
            Cerrar();
            var form = Application.OpenForms.OfType<RegistroTaller>().FirstOrDefault();
            RegistroTaller hijo = form ?? new RegistroTaller();
            AddFormInPanel(hijo);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {//Registro de profesor o taller
            Cerrar();
            var form = Application.OpenForms.OfType<TallerAgregar>().FirstOrDefault();
            TallerAgregar hijo = form ?? new TallerAgregar();
            AddFormInPanel(hijo);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//Registro de calificaciones, manda valores de usuario
            Cerrar();
            var form = Application.OpenForms.OfType<Calificaciones>().FirstOrDefault();
            Calificaciones hijo = form ?? new Calificaciones();
            hijo.nombre = Nombre.Text;
            hijo.cargo = Tipo.Text;
            hijo.PKEY = Pkeyy;
            AddFormInPanel(hijo);
           
        }
        private void button4_Click(object sender, EventArgs e)
        {//Consulta de alumnos
            Cerrar();
            var form = Application.OpenForms.OfType<ConsultaAlumno>().FirstOrDefault();
            ConsultaAlumno hijo = form ?? new ConsultaAlumno();
            AddFormInPanel(hijo);
        }

        private void label1_Click(object sender, EventArgs e)
        {//Principal
            Cerrar();
            var form = Application.OpenForms.OfType<AC>().FirstOrDefault();
            AC hijo = form ?? new AC();
            AddFormInPanel(hijo);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {//Generar carta
            Cerrar();
            var form = Application.OpenForms.OfType<Liberacion>().FirstOrDefault();
            Liberacion hijo = form ?? new Liberacion();
            AddFormInPanel(hijo);
        }
        private void button6_Click(object sender, EventArgs e)
        {//Generación de reportes
            Cerrar();
            var form = Application.OpenForms.OfType<Reportes>().FirstOrDefault();
            Reportes hijo = form ?? new Reportes();
            AddFormInPanel(hijo);
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {//Configuración de PDF
            Cerrar();
            var form = Application.OpenForms.OfType<Logos>().FirstOrDefault();
            Logos hijo = form ?? new Logos();
            AddFormInPanel(hijo);
        }

        private void button7_Click(object sender, EventArgs e)
        {//Cerrar sesión
            a.Show();            
            this.Close();            
        }
        #endregion

        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        public void Cerrar()
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Calificaciones) || frm.GetType() == typeof(ConsultaAlumno) || frm.GetType() == typeof(Liberacion) || frm.GetType() == typeof(RegistroAlumno) || frm.GetType() == typeof(RegistroTaller) || frm.GetType() == typeof(Reportes) || frm.GetType() == typeof(TallerAgregar) || frm.GetType() == typeof(Talleres))
                {
                    frm.Close();
                    break;
                }
            }
        }

        #region 
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Tipo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click_2(object sender, EventArgs e)
        {
            CambioPass form = new CambioPass();
            form.Show();
        }

        private void btnConexión_Click(object sender, EventArgs e)
        {
            Conexion form = new Conexion();
            form.Show();
        }
    }
}
