using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Nucleo.Presentador;
using Nucleo.Modelo;
using Nucleo.Vista;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMATALLERES
{
    public partial class Login : Form, ITalleres
    {
        WTalleres WTalleres;
        public string NombreProfesor=""; 
        public string Cargo = "";
        public string PKey = "";

        #region OBJETO/DATASET: LISTARPROFESOR
        public DataSet ListarProfesor
        {
            set
            {
                NombreProfesor = value.Tables[0].Rows[0]["NombreProfesor"].ToString();
                Cargo = value.Tables[0].Rows[0]["Cargo"].ToString();
                PKey = value.Tables[0].Rows[0]["PkProfesor"].ToString();
            }
        }
        public CTalleres Taller => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        public DataSet ObtenerUnDato { set => throw new NotImplementedException(); }
        public DataSet ListarTaller { set => throw new NotImplementedException(); }
        #endregion

        public Login()
        {
            InitializeComponent();
            WTalleres = new WTalleres(this);
        }

        #region BOTONES MÉTODOS
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();           
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                login();
            }
        }

        public void login()
        {
            Menu obj = new Menu();
            bool r = WTalleres.Login(TxtNoUsuario.Text, TxtContraseña.Text);
            if (r == true)
            {
                this.Hide();
                obj.Tipo.Text = Cargo;
                obj.Nombre.Text = NombreProfesor;
                obj.Pkeyy = PKey;
                if (Cargo == "Profesor")
                {
                    obj.btnRegistroAlumno.Visible = false;
                    obj.btnTalleres.Visible = false;
                    obj.button5.Visible = false;
                    obj.button6.Visible = false;
                }
                obj.Show();
            }
            else
            {
                Mensaje("ad1", "Acceso denegado", "Usuario y/o contraseña incorrectos");
            }
        }
        #endregion

        #region
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        public void Mensaje(string imagen, string titulo, string texto)
        {
            Mensaje a = new Mensaje(imagen, titulo, texto);
            a.Show();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            Conexion a = new Conexion();
            a.Show();
        }
    }
}
