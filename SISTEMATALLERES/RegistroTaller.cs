using Nucleo.Vista;
using Nucleo.Presentador;
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

namespace SISTEMATALLERES
{
    public partial class RegistroTaller : Form, ITalleres, IAlumno
    {
        WTalleres objWTaller;
        WAlumno wAlumno;
        string taller;
        string Nombre;
        string Apellido;
        string carrera;
        #region OBJETOS: TALLER
        public CTalleres Taller
        {
            
            get
            {
                CTalleres nuevo = new CTalleres();
                nuevo.Matricula = Convert.ToInt32(TXTMatricula.Text);
                nuevo.Periodo = CBPeriodo.SelectedValue.ToString();
                nuevo.Anio = Convert.ToUInt16(CBAnio.SelectedValue.ToString());
                nuevo.FkDisciplina = taller;
                return nuevo;
            }
        }
        public CProfesor Profesor => throw new NotImplementedException();
        public CAlumno Alumno => throw new NotImplementedException();
        #endregion

        #region DATASET: LISTARTALLERES, ALUMNO, PERIODO, AÑO
        public DataSet ListarTaller
        {
            set
            {
                TBLTALLERES.DataSource = value;
                TBLTALLERES.DataMember = "Datos";
                TBLTALLERES.AutoResizeColumns();
                TBLTALLERES.AutoResizeRows();
                TBLTALLERES.Columns["ClaveTaller"].Visible = false;
                TBLTALLERES.Columns["PkDisciplina"].Visible = false;
                TBLTALLERES.Columns["Disciplina"].Visible = true;
                TBLTALLERES.Columns["PkProfesor"].Visible = false;
                TBLTALLERES.Columns["NombreProfesor"].Visible = false;

            }
        }
        public DataSet ListarAlumno
        {
            set
            {
                Nombre = value.Tables[0].Rows[0]["NombreAlumno"].ToString();
                Apellido = value.Tables[0].Rows[0]["ApellidoAlumno"].ToString();
                carrera = value.Tables[0].Rows[0]["NombreCarrera"].ToString();

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
        public DataSet ObtenerUnDato { set => throw new NotImplementedException(); }
        public DataSet Carreras { set => throw new NotImplementedException(); }
        public DataSet Alumnos { set => throw new NotImplementedException(); }
        public DataSet Disciplina { set => throw new NotImplementedException(); }
        public DataSet Promedio { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor { set => throw new NotImplementedException(); }
        #endregion

        public RegistroTaller()
        {
            InitializeComponent();
            FormatoTabla(TBLTALLERES);
        }             
        private void RegistroTaller_Load(object sender, EventArgs e)
        {
            objWTaller = new WTalleres(this);
            wAlumno = new WAlumno(this);
            objWTaller.ListarTalleres();
            wAlumno.ListarPeriodo();
            wAlumno.ListarAnio();
            ObtenerPeriodo();
        }

        #region BOTONES, VALIDADORES Y MÉTODOS
        private void TBLTALLERES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LBDisciplina.Text = TBLTALLERES.CurrentRow.Cells[2].Value.ToString();
            LBNombreP.Text = TBLTALLERES.CurrentRow.Cells[4].Value.ToString();
            taller= TBLTALLERES.CurrentRow.Cells[0].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            wAlumno.ConsultaAlumno(1, TXTMatricula.Text);
            LBNombre.Text = Nombre +" "+Apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool r = objWTaller.RegistrarATaller(Taller);
            if (r == true)
            {
                Mensaje("listo1", "Listo", "El registro exitoso");
                TXTMatricula.Text = "";
            }
        }
        private void TXTMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
             e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void TXTMatricula_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (TXTMatricula.Text.Trim().Length == 7)
                {
                    wAlumno.ConsultaAlumno(1, TXTMatricula.Text);
                    LBNombre.Text = Nombre + " " + Apellido;
                }
                else
                {
                    LBNombre.Text = "**Ingrese matricula correcta**";
                }
            }
            catch (Exception)
            {
                LBNombre.Text = "**Matricula no válida**";
            }
            
        }
        public void ObtenerPeriodo()
        {
            DateTime fecha_actual = DateTime.Today;
            int mes = fecha_actual.Month;
            LBAnio.Text = fecha_actual.Year.ToString();

            if (mes <= 4)
            {
                LBPeriodo.Text = "Enero - Abril";
            }
            if (mes <= 8 && mes > 4)
            {
                LBPeriodo.Text = "Mayo - Agosto";
            }
            if (mes > 8)
            {
                LBPeriodo.Text = "Septiembre - Diciembre";
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBLTALLERES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LBAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void TXTMatricula_Leave(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
