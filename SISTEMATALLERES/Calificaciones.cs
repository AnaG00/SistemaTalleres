using Nucleo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nucleo.Modelo;
using Nucleo.Presentador;

namespace SISTEMATALLERES
{
    public partial class Calificaciones : Form, ITalleres, IAlumno
    {
        WTalleres wTalleres;
        WAlumno wAlumno;
        string Matricula, aprobado; decimal cal1, cal2, cal3, calfinal, promedio;
        public string cargo, nombre, PKEY;

        #region OBJETOS: ALUMNO
        public CAlumno Alumno
        {
            get
            {
                CAlumno nuevo = new CAlumno();
                nuevo.Matricula = Matricula;
                nuevo.Disciplina = CBDisciplina.SelectedValue.ToString();
                nuevo.Parcial1 = cal1;
                nuevo.Parcial2 = cal2;
                nuevo.Parcial3 = cal3;
                nuevo.Califinal = calfinal;
                nuevo.Aprobado = aprobado;
                return nuevo;
            }
        }
        public CTalleres Taller => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        #endregion

        #region DATASET: LISTARTALLERES, PROFESORES, ALUMNO, PERIODO, AÑO, PROMEDIO
        public DataSet ListarTaller
        {
            set
            {
                CBDisciplina.DataSource = value.Tables[0];
                CBDisciplina.DisplayMember = "Disciplina";
                CBDisciplina.ValueMember = "ClaveTaller";
            }
        }
        public DataSet ListarProfesor
        {
            set
            {
                CBProfesor.DataSource = value.Tables[0];
                CBProfesor.DisplayMember = "NombreProfesor";
                CBProfesor.ValueMember = "PkProfesor";
            }
        }
        public DataSet ListarAlumno
        {
            set
            {
                TBLGENERAL.DataSource = value;
                TBLGENERAL.DataMember = "Datos";
                TBLGENERAL.AutoResizeColumns();
                TBLGENERAL.AutoResizeRows();
                TBLGENERAL.Columns["Matricula"].Visible = true;
                TBLGENERAL.Columns["Nombre"].Visible = true;
                TBLGENERAL.Columns["Parcial 1"].Visible = true;
                TBLGENERAL.Columns["Parcial 2"].Visible = true;
                TBLGENERAL.Columns["Parcial 3"].Visible = true;

            }
        }
        public DataSet Periodo
        {
            set
            {
                CBPeriodo.DataSource = value.Tables[0];
                CBPeriodo.DisplayMember = "PkPeriodo";
                CBPeriodo.ValueMember = "PkPeriodo";
            }
        }
        public DataSet Anios
        {
            set
            {
                CBAnio.DataSource = value.Tables[0];
                CBAnio.DisplayMember = "Año";
                CBAnio.ValueMember = "Año";
            }
        }
        public DataSet Promedio
        {
            set
            {
                promedio = Convert.ToDecimal(value.Tables[0].Rows[0]["PROMEDIO"].ToString());
            }
        }
        public DataSet Alumnos { set => throw new NotImplementedException(); }
        public DataSet Disciplina { set => throw new NotImplementedException(); }
        public DataSet ObtenerUnDato { set => throw new NotImplementedException(); }        
        public DataSet Carreras { set => throw new NotImplementedException(); }
        #endregion

        public Calificaciones()
        {
            InitializeComponent();
            wTalleres = new WTalleres(this);
            wAlumno = new WAlumno(this);
            FormatoTabla(TBLGENERAL);
            wAlumno.ListarPeriodo();
        }        
        private void Calificaciones_Load(object sender, EventArgs e)
        {//Carga la vista dependiendo del usuario
            if (cargo == "Profesor")
            {
                DateTime fecha_actual = DateTime.Today;
                LBAnio.Text = fecha_actual.Year.ToString();
                CBProfesor.Text = nombre;
                CBProfesor.Enabled = false;
                CBAnio.Visible = false;
                wTalleres.ListarDisciplina(PKEY);
            }
            else
            {
                wAlumno.ListarAnio();
                wTalleres.ListarProfesores();
                wTalleres.ListarDisciplina(CBProfesor.SelectedValue.ToString());
            } 
        }

        #region MÉTODOS, BOTONES
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//Muestra las disciplinas dependiendo del profesor
            wTalleres.ListarDisciplina(CBProfesor.SelectedValue.ToString());
        }        
        private void button18_Click(object sender, EventArgs e)
        {//Enlista los alumnos del taller, para calificar.
            int anio = 0;
            try
            {
                if (LBAnio.Text == "")
                    anio = Convert.ToInt32(CBAnio.SelectedValue.ToString());
                else
                    anio = Convert.ToInt32(LBAnio.Text);
                wAlumno.ListarCalificaciones(CBDisciplina.SelectedValue.ToString(), anio, CBPeriodo.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                Mensaje("ad1", "Inexistente", "Sin registros");
            }           
        }   
        private void button1_Click(object sender, EventArgs e)
        {//Obtiene las calificaciones, promedio, estado de aprobación
            bool r = false;
            foreach (DataGridViewRow row in TBLGENERAL.Rows)
            {
                Matricula=(row.Cells["Matricula"].Value.ToString());
                cal1 = Convert.ToDecimal(row.Cells["Parcial 1"].Value.ToString());
                cal2 = Convert.ToDecimal(row.Cells["Parcial 2"].Value.ToString());
                cal3 = Convert.ToDecimal(row.Cells["Parcial 3"].Value.ToString());
                calfinal = (cal1 + cal2 + cal3) / 3;
                if (calfinal >= 7)
                    aprobado = "SI";
                else
                    aprobado = "NO";

                r = wAlumno.Calificar(Alumno);
                liberar(Matricula);
            }
            if (r==true)
            {
                Mensaje("listo1", "Listo", "Calificación almacenada");
            }
        }        
        public void liberar(string matricula)   
        {//Cambia el estado del liberación del alumno, obteniedo el promedio global   
            wAlumno.Promedio(6, matricula);
            if (promedio>=7)
            {
                wAlumno.Liberar(1, Convert.ToInt32(matricula));
            }
        }
        public void FormatoTabla(DataGridView Table)
        {//Da formato a las tabla de la aplicación
            Table.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10);
            Table.DefaultCellStyle.ForeColor = Color.Brown;
            Table.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 13);
            Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Table.ColumnHeadersDefaultCellStyle.BackColor = Color.Brown;
        }
        #endregion

        #region
        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void LBPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBLGENERAL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        public void Mensaje(string ima, string titulo, string texto)
        {
            Mensaje a = new Mensaje(ima, titulo, texto);
            a.Show();
        }
    }
}
