using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nucleo.Modelo;
using Nucleo.Vista;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Presentador
{
    public class WAlumno
    {
        ManagerBD Manager;
        IAlumno ViewAlumno;
        CAlumno objAlumno;
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
        public WAlumno(IAlumno InterfazAlumno)
        {
            ViewAlumno = InterfazAlumno;
            objAlumno = new CAlumno();
            Manager = new ManagerBD();

        }
        //Registro
        public bool RegistrarAlumno(CAlumno objAlumno)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objAlumno.RegistroAlumno(1, objAlumno);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }
        //Modifcación
        public bool Calificar(CAlumno objAlumno)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objAlumno.Calificar(1, objAlumno);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public bool Liberar(int opcion, int matricula)
        {
            bool bolRegistro = false, realizado = false;
            if (ExisteConexion())
            {
                bolRegistro = objAlumno.Liberar(opcion, matricula);
                if (bolRegistro == true)
                    realizado = true;
            }
            return realizado;
        }

        public void LLenarCarreras()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarDatos(1, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Carreras = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "El combo de carreras no pudo ser llenado");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarPeriodo()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarDatos(5, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Periodo = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "El combo de periodos no pudo ser llenado");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarAnio()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarDatos(6, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Anios = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "El combo de periodos no pudo se llenado");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarTaller()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarDatos(4, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Disciplina = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "El combo de talleres no pudo se llenado");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarMeses()
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarDatos(9, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Alumnos = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "El combo de meses no pudo se llenado");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void MesLiberadas(string mes, string anio)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.MesLiberadas(1, mes, anio, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.ListarAlumno = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void LiberadoSinCarta(int opcion, string carrera)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.LiberadoSinCarta(opcion, carrera, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.ListarAlumno = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ConsultaAlumno(int opcion, string matricula)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ConsultaAlumno(opcion, matricula, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.ListarAlumno = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void Promedio(int opcion, string matricula)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ConsultaAlumno(opcion, matricula, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Promedio = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void consultageneral(string Disiciplina, string Anio, string Periodo, string Carrera)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.consultageneral(1, Disiciplina, Anio, Periodo, Carrera, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.Alumnos = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin registros", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        public void ListarCalificaciones(string Disiciplina, int Anio, string Periodo)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = objAlumno.ListarCalificaciones(1, Disiciplina, Anio, Periodo, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewAlumno.ListarAlumno = dtsDatos;
                else
                    ViewAlumno.Mensaje("ad1", "Sin alumnos", "No existen registros en la base de datos");
            }
            else
                ViewAlumno.Mensaje("error1", "Sin conexión a red", "Verifique la conexión al servidor");
        }

        
    }
}
