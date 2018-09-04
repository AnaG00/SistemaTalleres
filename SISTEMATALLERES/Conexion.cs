using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SISTEMATALLERES
{
    public partial class Conexion : Form
    {
        Configuration onapp_AppConfig;
        public Conexion()
        {
            InitializeComponent();
            onapp_AppConfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Conexion_Load(object sender, EventArgs e)
        {

        }

        public void InicioProceso()
        {
            this.Cursor = Cursors.WaitCursor;
        }

       private void button1_Click(object sender, EventArgs e)
        {
            string vnstr_Cadena;
            try
            {
                //Buscamos todas las cadenas de conexion              
                ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
                if (settings != null)
                {
                    //Se establece el nuevo valor de la cadena de conexion
                    vnstr_Cadena = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtCatalogoInitial.Text.Trim() + "; Integrated Security=true; ";

                    onapp_AppConfig.ConnectionStrings.ConnectionStrings["Cadena1"].ConnectionString = vnstr_Cadena;
                    onapp_AppConfig.Save();

                 ;

                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InicioProceso();
            string cadena = "";
            //cadena = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtCatalogoInitial.Text.Trim() + ";User ID=" + txtUser.Text.Trim() + ";Password=" + txtPassword.Text.Trim();
            cadena = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtCatalogoInitial.Text.Trim() + "; Integrated Security=true; ";
           
               SqlConnection onsql_ConnectionDB = new SqlConnection(cadena);

            try
            {
                onsql_ConnectionDB.Open();
                MessageBox.Show("Conexion Establecida Con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
            }
            catch (Exception)
            {
                onsql_ConnectionDB.Close();
                MessageBox.Show("Conexion No Establecida, Verifiqué los Parametros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXTMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
