using System;
using System.Windows.Forms;
using Nucleo.Presentador;
using Nucleo.Modelo;
using Nucleo.Vista;
using System.Data;
using System.Linq;

namespace SISTEMATALLERES
{
    public partial class RegistroAlumno : Form, IAlumno
    {
        WAlumno objWAlumno;

        public CAlumno Alumno
        {
            get
            {
                CAlumno nuevo = new CAlumno();
                nuevo.Matricula = TXTMatricula.Text;
                nuevo.Nombre_1 = TNombre.Text;
                nuevo.Apellido_P = TApellidoP.Text;
                nuevo.Apellido_M = TApellidoM.Text;
                nuevo.Carrera = CBCarrera.SelectedValue.ToString();
                if (radioButton1.Checked)
                    nuevo.Genero = radioButton1.Text;
                else if (radioButton2.Checked)
                    nuevo.Genero = radioButton2.Text;
                return nuevo;
            }
        }
        #region DATASET: CARRERAS
        public DataSet Carreras
        {
            set
            {

                CBCarrera.DataSource = value.Tables[0];
                CBCarrera.DisplayMember = "NombreCarrera";
                CBCarrera.ValueMember = "PkCarrera";
            }
        }        
        public DataSet ListarAlumno { set { throw new NotImplementedException(); } }
        public DataSet Periodo { set => throw new NotImplementedException(); }
        public DataSet Anios { set => throw new NotImplementedException(); }
        public DataSet Alumnos { set => throw new NotImplementedException(); }
        public DataSet Disciplina { set => throw new NotImplementedException(); }
        public DataSet Promedio { set => throw new NotImplementedException(); }
        #endregion

        public RegistroAlumno()
        {
            InitializeComponent();
            objWAlumno = new WAlumno(this);
            objWAlumno.LLenarCarreras();
            
        }
        private void RegistroAlumno_Load(object sender, EventArgs e) { }

        private void button18_Click(object sender, EventArgs e)
        {
            bool r = objWAlumno.RegistrarAlumno(Alumno);
            if (r == true) {
                Mensaje("listo1", "Listo", "El registro exitoso");
                TXTMatricula.Text = "";
                TNombre.Text = "";
                TApellidoM.Text = "";
                TApellidoP.Text="";
        }          
            else
                Mensaje("ad1", "Error al registrar", "Verifique los datos, ó quiza ya esté registrado");
        }

        public void Mensaje(string ima, string titulo, string texto)
        {
            Mensaje a = new Mensaje(ima, titulo, texto);
            a.Show();
        }

        #region validadores
        private void TXTMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
              e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            
        }         
        
        public void SoloMayuscula(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloMayuscula(sender, e);
        }

        private void TApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloMayuscula(sender, e);
        }

        private void TApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloMayuscula(sender, e);
        }
        #endregion BA

        #region 
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void TXTMatricula_Click(object sender, EventArgs e)
        {

        }
        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void TXTMatricula_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void label23_Click(object sender, EventArgs e)
        {

        }
        private void CBEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
