using Nucleo.Modelo;
using Nucleo.Presentador;
using Nucleo.Vista;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SISTEMATALLERES
{
    public partial class Logos : Form, ITalleres
    {
        WTalleres wTalleres;
        string logo1, logo2, logo3;
        public Logos()
        {
            InitializeComponent();
            wTalleres = new WTalleres(this);
        }
        private void Logos_Load(object sender, EventArgs e)
        {
            MostrarLogos();
        }

        #region DATASET: OBTENER LOGOS
        public DataSet ObtenerUnDato
        {
            set
            {
                logo1 = value.Tables[0].Rows[0]["LInstitucional"].ToString();
                logo2 = value.Tables[0].Rows[0]["LSecretaria"].ToString();
                logo3 = value.Tables[0].Rows[0]["LEstado"].ToString();
            }
        }
        public CTalleres Taller => throw new NotImplementedException();
        public CProfesor Profesor => throw new NotImplementedException();
        public DataSet ListarTaller { set => throw new NotImplementedException(); }
        public DataSet ListarProfesor { set => throw new NotImplementedException(); }
        #endregion

        #region BOTONES
        private void LogoI_Click(object sender, EventArgs e)
        {
            string nombrelgo = cambiarLogo(LogoI);
            wTalleres.CambiarLogo(nombrelgo,"","");
        }
       
        private void LogoSE_Click(object sender, EventArgs e)
        {
            string nombrelgo = cambiarLogo(LogoSE);
            wTalleres.CambiarLogo("", nombrelgo, "");
        }

        private void LogoE_Click(object sender, EventArgs e)
        {
            string nombrelgo = cambiarLogo(LogoE);
            wTalleres.CambiarLogo("", "", nombrelgo);
        }
        #endregion

        #region MÉTODOS
        public void MostrarLogos()
        {
            wTalleres.ListarLogos();
            string ruta = "C:\\Users\\ANA GOMEZ ORTIZ\\Documents\\UPT\\SERVICIOSOCIAL\\SISTEMATALLERES\\SISTEMATALLERES\\SISTEMATALLERES\\bin\\Debug\\";
            LogoI.Image = Image.FromFile(ruta + logo1);
            LogoSE.Image = Image.FromFile(ruta + logo2);
            LogoE.Image = Image.FromFile(ruta + logo3);
        }
        public string cambiarLogo(PictureBox logo)
        {
            
            string ruta = "C:\\Users\\ANA GOMEZ ORTIZ\\Documents\\UPT\\SERVICIOSOCIAL\\SISTEMATALLERES\\SISTEMATALLERES\\SISTEMATALLERES\\bin\\Debug\\";
            string nombrelogo = "";
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = nombrelogo;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                nombrelogo = BuscarImagen.FileName;
                logo.SizeMode = PictureBoxSizeMode.StretchImage;
                logo.Image = Image.FromFile(nombrelogo);
            }
            string nombreImagen = nombrelogo.Substring(nombrelogo.LastIndexOf("\\") + 1);
            try
            {
                logo.Image.Save(ruta+nombreImagen);
            }
            catch (Exception)
            {
                Mensaje("ad1", "Error", "Cambiar el nombre de la imagen");
            }
            return nombreImagen;
        }
        #endregion
        public void Mensaje(string imagen, string titulo, string texto)
        {
            Mensaje a = new Mensaje(imagen, titulo, texto);
            a.Show();
        }
    }
}
