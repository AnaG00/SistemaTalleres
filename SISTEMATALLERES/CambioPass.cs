using System;
using System.Data;
using System.Windows.Forms;
using Nucleo.Vista;
using Nucleo.Modelo;
using Nucleo.Presentador;

namespace SISTEMATALLERES.Recursos
{
    public partial class CambioPass : Form, ITalleres
    {
        WTalleres objWUsuario;
        WTalleres wTalleres;
        public string nombre;
        string NombreProfesor = "";
        string Cargo = "";
        string Clav = "";

        public CambioPass()
        {
            InitializeComponent();
            objWUsuario = new WTalleres(this);
            this.Hide();

            Tipo.Text = Cargo;
            Nom.Text = NombreProfesor;
            Clave.Text = Clav;

            wTalleres = new WTalleres(this);
        }

        public DataSet ListarUsuario
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public CTalleres Taller => throw new NotImplementedException();

        public CProfesor Profesor
        {
            get
            {
                CProfesor Profesor = new CProfesor();
                Profesor.NombreProfesor = "";
                return Profesor;
            }
        }

        public DataSet ListarTaller { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor { set => throw new NotImplementedException(); }
        public DataSet ObtenerUnDato
        {
            set
            {               
                NombreProfesor = value.Tables[0].Rows[0]["NombreProfesor"].ToString();                
                Clav = value.Tables[0].Rows[0]["NoControl"].ToString();
                Cargo = value.Tables[0].Rows[0]["Cargo"].ToString();

            }
        }

        private void CambioPass_Load(object sender, EventArgs e)
        {
            //wTalleres.ObtenerProfesor(Nom.Text);
        }

        private void ActContraseña_Click(object sender, EventArgs e)
        {
            if (CC.Text == NC.Text)
            {

                bool resultado = objWUsuario.ChangePass(Clave.Text,CA.Text, NC.Text);
                if (resultado == true)
                    Mensaje("listo1", "¡LISTO!", "El cambio se realizó con éxito");
                else
                    Mensaje("ad1", "Contraseña incorrecta", "Error, verifique e");
            }
            else
            {
                Mensaje("ad1", "Las contraseñas no coiciden", "Verifique que la nueva contraseña y la confirmación sean iguales");

            }

            Close();
        }

        public void Mensaje(string imagen, string titulo, string texto)
        {
            Mensaje a = new Mensaje(imagen, titulo, texto);
             a.Show();
        }

        public void Mensaje(string texto)
        {
            throw new NotImplementedException();
        }

        private void CambPass_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActNom_Click(object sender, EventArgs e)
        {
            wTalleres.CambiarNombre(Clave.Text,Nom.Text);
            Mensaje("listo1", "¡LISTO!", "El cambio se realizó con éxito");
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
//ESTO ES NUEVO PÁ' AGREGAR