using Nucleo.Vista;
using System;
using System.Data;
using System.Windows.Forms;
using Nucleo.Modelo;
using Nucleo.Presentador;

namespace SISTEMATALLERES
{
    public partial class TallerAgregar : Form, ITalleres
    {
        WTalleres wTalleres;
        int PkDisciplina;
        int PkProfesor;
        string ClaveDi = "";

        #region OBJETOS: TALLER, PROFESOR
        public CTalleres Taller
        {
            get
            {
                CTalleres nuevo = new CTalleres();
                nuevo.PkProfesor = Convert.ToInt32(CBProfesor.SelectedValue.ToString());                
                nuevo.PkDisciplina = Convert.ToInt32(ClaveDi);
                return nuevo;
            }
        }

        public CProfesor Profesor
        {
            get
            {
                CProfesor nuevo = new CProfesor();
                nuevo.NombreProfesor = txtNombreU.Text +" "+ txtApellidosU.Text;
                nuevo.NoControl = Convert.ToInt32(txtNoControlU.Text);
                nuevo.Pass = txtpassU.Text;
                nuevo.Cargo= cbCargoU.SelectedItem.ToString();

                return nuevo;
            }
        }
        #endregion

        #region DATASET: PKTALLER, PROFESOR, PKPROFESOR
        public DataSet ListarTaller
        {
            set
            {
                PkDisciplina = Convert.ToInt32(value.Tables[0].Rows[0]["PkDisciplina"].ToString());
            }
        }

        public DataSet ListarProfesor
        {  set
            {

                CBProfesor.DataSource = value.Tables[0];
                CBProfesor.DisplayMember = "NombreProfesor";
                CBProfesor.ValueMember = "PkProfesor";
            }
        }

        public DataSet ObtenerUnDato
        {
            set
            {
                PkProfesor = Convert.ToInt32(value.Tables[0].Rows[0]["PkProfesor"].ToString());
            }
        }
        #endregion

        public TallerAgregar()
        {
            InitializeComponent();
            wTalleres = new WTalleres(this);
            wTalleres.ListarProfesores();
            wTalleres.ListarTalleres();
        }
        #region BOTONES
        private void button18_Click(object sender, EventArgs e)
        {
            
            bool hecho = false;
            bool r = wTalleres.AgregarDisciplina(TXTDisciplina.Text, ref ClaveDi);
            if (r == true)
            {
                hecho= wTalleres.RegistroTaller(Taller);
            }
            else
                Mensaje("ad1", "Error al registrar", "Verifique que todos los campos esten llenos e intente de nuevo");

            if (hecho==true)
            {
                Mensaje("listo1", "Listo", "Registro exitoso");
            }
            else
                Mensaje("ad1", "Error al registrar", "Verifique que todos los campos esten llenos e intente de nuevo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool r = wTalleres.RegistrarUsuario(Profesor);
            if (r == true)
            {
                Mensaje("listo1", "Listo", "El registro exitoso");
                wTalleres.ListarProfesores();
            }
                
            else
                Mensaje("ad1", "Error al registrar", "Verifique los datos, ó quiza ya esté registrado");
        }

        private void cbCargoU_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool r = wTalleres.RegistrarUsuario(Profesor);
            if (r == true)
            {
                Mensaje("listo1", "Listo", "El registro exitoso");
                wTalleres.ListarProfesores();
            }

            else
                Mensaje("ad1", "Error al registrar", "Verifique los datos, ó quiza ya esté registrado");
        }
        #endregion

        public void Mensaje(string ima, string titulo, string texto)
        {
            Mensaje a = new Mensaje(ima, titulo, texto);
            a.Show();
        }
        #region 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TallerAgregar_Load(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void CBCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Nuevo_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
