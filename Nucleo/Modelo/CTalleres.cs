/**
 * Archivo: CProfesor.cs
 * Autor: ALGO
 * Fecha: Febrero - Julio 2018
 * Descripción:  Realiza acciones manipulando los talleres, alumnos y profesores, interacción con la BD.
 **/
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Nucleo.Modelo
{
    public class CTalleres
    {
        ManagerBD objManagerBD;
        #region ATRIBUTOS/PROPIEDADES
        public string NombreDisciplina { get; set; }
        public string NombreProfesor { get; set; }
        public int PkDisciplina { get; set; }
        public int PkProfesor { get; set; }

        public int Matricula { get; set; }
        public string Periodo { get; set; }
        public int Anio { get; set; }
        public string FkDisciplina { get; set; }
        #endregion

        public CTalleres()
        {
            objManagerBD = new ManagerBD();
        }

        #region REGISTRO: DISCIPLINA, RELACIÓN PROFESOR-DISCIPLINA, ALUMNO A UN TALLER 
        /// <summary>
        /// Registra la disciplina en el catalogo
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="disciplina">Nombre</param>
        /// <param name="claven">Devuelve la clave de la disciplina</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool AgregarDisciplina(int Opcion, string disciplina, ref string claven)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@NombreD", SqlDbType.NVarChar, 25) { Value = disciplina });
            lstParametros.Add(new SqlParameter("@ClaveD", SqlDbType.Int) { Direction = ParameterDirection.Output });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("RDisciplina", lstParametros.ToArray()))
            {
                claven = lstParametros[2].Value.ToString();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Hace el registro de la relación del taller con el profesor, con sus claves
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="objNew">Objeto del taller donde toma las primarykey</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool RegistroTaller(int Opcion, CTalleres objNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Disciplina", SqlDbType.Int) { Value = objNew.PkDisciplina });
            lstParametros.Add(new SqlParameter("@Profesor", SqlDbType.Int) { Value = objNew.PkProfesor });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("RTaller", lstParametros.ToArray()))
                return true;
            return false;
        }
        /// <summary>
        /// Realiza el registro de de un taller a un alumno
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="objNew"></param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool RegistrarATaller(int Opcion, CTalleres objNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Matricula ", SqlDbType.Int) { Value = objNew.Matricula });
            lstParametros.Add(new SqlParameter("@Periodo", SqlDbType.NVarChar, 50) { Value = objNew.Periodo });
            lstParametros.Add(new SqlParameter("@Anio", SqlDbType.Int) { Value = objNew.Anio });
            lstParametros.Add(new SqlParameter("@PkTaller", SqlDbType.Int) { Value = objNew.FkDisciplina });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("RegistroATaller", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        #region MODIFICACIÓN: LOGOS
        public bool CambiarLogo(int Opcion, string logo1, string logo2, string logo3)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Logo1", SqlDbType.NVarChar, 50) { Value = logo1 });
            lstParametros.Add(new SqlParameter("@Logo2", SqlDbType.NVarChar, 50) { Value = logo2 });
            lstParametros.Add(new SqlParameter("@Logo3", SqlDbType.NVarChar, 50) { Value = logo3 });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("CambioLogo", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        #region CONSULTA: LISTARDATOS, CONSULTADATOS MEDIANTE UN PARAMETRO, LOGIN
        /// <summary>
        /// Consulta diversos datos depediendo de la opcion: Taller-prosefor, Profesores
        /// </summary>
        /// <param name="Opcion">La opción se que ejectura, 1--Listar carreras, 2--Taller con profesor, 3--Profesores, 4--isciplinas, 
        /// 5--Periodos, 6--Años</param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool ListarDatos(int Opcion, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("ListarDatos", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
        /// <summary>
        /// Consulta de datos dependiendo de la  y el paramentro
        /// </summary>
        /// <param name="Opcion"> 2--Calificaciones de taller(Matricula), 3--PkProfesor(Nombre del profesor),
        /// 4--PkDisciplina(Nombre de Disciplina), 5--Relación taller-profesor(PkProfesor), 7--Tabla para carta(matricula) 8--Logos</param>
        /// <param name="dato"></param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool ConsultarDato(int Opcion, string dato, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Consulta", SqlDbType.NVarChar, 250) { Value = dato });
            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("VEAlumno", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }

        /// <summary>
        /// Realiza la logue, para acceder a la aplicación
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <param name="usuario">Clave, número de control</param>
        /// <param name="passsword"></param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool Login(int Opcion, ref DataSet objDatos, string usuario, string passsword)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Nocontrol", SqlDbType.NVarChar, 50) { Value = usuario });
            lstParametros.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50) { Value = passsword });
            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("Login", lstParametros.ToArray());
            if (objDatos.Tables[0].Rows.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
        #endregion
    }
}
