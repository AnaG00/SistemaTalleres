using Nucleo.Modelo;
using Nucleo.Vista;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Presentador
{
    public class WTalleres
    {
        ManagerBD Manager;
        ITalleres ViewTaller;
        CTalleres objTaller;
        CProfesor objUsuario;
        //Conexion
        public bool ExisteConexion()
        {
            bool ConexionAbierta = false;
            SqlConnection sqlCon = Manager.GetConnection1();
            if (sqlCon.State == ConnectionState.Open)
                ConexionAbierta = true;
            return ConexionAbierta;
        }
        //Constructor
        public WTalleres(ITalleres InterfazTalleres)
        {
            ViewTaller = InterfazTalleres;
            objTaller = new CTalleres();
            objUsuario = new CProfesor();
            Manager = new ManagerBD();

        }

        public bool Login(string Usuario, string password)
        {
            bool resul = false;
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.Login(1, ref dtsDatos, Usuario, password);
                if (ExistenDatos == true)
                {
                    ViewTaller.ListarProfesor = dtsDatos;
                    resul = true;
                }
                else
                    resul = false;
            }
            return resul;
        }

        //Registro
        public bool RegistroTaller(CTalleres objTaller)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objTaller.RegistroTaller(1, objTaller);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public bool AgregarDisciplina(string disciplina, ref string claveN)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objTaller.AgregarDisciplina(1, disciplina, ref claveN);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public bool RegistrarUsuario(CProfesor objProfesor)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objProfesor.RegistroUsuario(1, objProfesor);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }



        public bool RegistrarATaller(CTalleres objTaller)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objTaller.RegistrarATaller(1, objTaller);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public bool CambiarLogo(string logo1, string logo2, string logo3)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objTaller.CambiarLogo(1, logo1,logo2,logo3);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }
        //Consulta
        public void ListarProfesores()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ListarDatos(3, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarProfesor = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }
        public void ListarLogos()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ListarDatos(10, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ObtenerUnDato = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ObtenerTaller(string disciplina)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ConsultarDato(4, disciplina,ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarTaller = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        
        public void ObtenerProfesor(string profesor)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ConsultarDato(3, profesor, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ObtenerUnDato = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void TalleresAlumno(int opcion, string matricula)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ConsultarDato(opcion, matricula, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarTaller = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void TalleresAlumnoC(int opcion, string matricula)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ConsultarDato(opcion, matricula, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarProfesor = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarTalleres()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ListarDatos(2, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarTaller = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarDisciplina(string Profesor)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objTaller.ConsultarDato(5, Profesor, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewTaller.ListarTaller = dtsDatos;
                else
                    ViewTaller.Mensaje("ad1", "Advertencia", "Error al obtener los datos, vuelva a intertarlo");
            }
            else
                ViewTaller.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public bool ChangePass(string Usuario, string passwordOld, string passwordNew)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objUsuario.CambioPassword(1, Usuario, passwordOld, passwordNew);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public bool CambiarNombre(string Clave, string NNombre)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objUsuario.CambiarNombre(1, Clave, NNombre);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }


    }
}
