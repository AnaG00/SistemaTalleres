/**
 * Archivo: CAlumno.cs
 * Autor: ALGO
 * Fecha: Febrero - Julio 2018
 * Descripción:  Realiza acciones manipulando el usuario Alumno, interacción con la BD.
 **/
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Modelo
{
  
    public class CAlumno
    {        
        ManagerBD objManagerBD;
        #region ATRIBUTOS/PROPIEDADES
        public string Matricula { get; set; }
        public string Nombre_1 { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public string Carrera { get; set; }
        public string Genero { get; set; }

        public string Disciplina { get; set; }
        public string Periodo { get; set; }
        public int Anio { get; set; }
        public decimal Parcial1 { get; set; }
        public decimal Parcial2 { get; set; }
        public decimal Parcial3 { get; set; }
        public decimal Califinal { get; set; }
        public string Aprobado { get; set; }
        #endregion

        public CAlumno()
        {
            objManagerBD = new ManagerBD();
        }

        #region REGISTRO ALUMNO
        /// <summary>
        /// Permitira el registro del alumno a la BD 
        /// </summary>
        /// <param name="Opcion">La opción se que ejectura, valor 1</param>
        /// <param name="objNew">Objeto alumno con los datos personales</param>
        /// <returns>Verdadero / Falso: Datos Registrados</returns>
        public bool RegistroAlumno(int Opcion, CAlumno objNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Matricula", SqlDbType.Int) { Value = objNew.Matricula });
            lstParametros.Add(new SqlParameter("@NombreA", SqlDbType.NVarChar, 50) { Value = objNew.Nombre_1 });
            lstParametros.Add(new SqlParameter("@ApellidoA", SqlDbType.NVarChar, 50) { Value = objNew.Apellido_P +" "+ objNew.Apellido_M });
            lstParametros.Add(new SqlParameter("@Genero", SqlDbType.NVarChar, 25) { Value = objNew.Genero });
            lstParametros.Add(new SqlParameter("@PkCarrera", SqlDbType.NVarChar, 25) { Value = objNew.Carrera });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("Registro", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        #region MODIFICACIONES: CALIFICACIONES, ESTADO LIBERAR
        /// <summary>
        /// Modificara las calificación del alumno en determinado taller
        /// </summary>
        /// <param name="Opcion">La opción se que ejectura, valor 1</param>
        /// <param name="objNew">Objeto alumno con las calificaciones</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool Calificar(int Opcion, CAlumno objNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Matricula", SqlDbType.NVarChar, 7) { Value = objNew.Matricula });
            lstParametros.Add(new SqlParameter("@Taller", SqlDbType.Int) { Value = objNew.Disciplina });  
            lstParametros.Add(new SqlParameter("@Cali1", SqlDbType.Decimal) { Value = objNew.Parcial1 });
            lstParametros.Add(new SqlParameter("@Cali2", SqlDbType.Decimal) { Value = objNew.Parcial2 });
            lstParametros.Add(new SqlParameter("@Cali3", SqlDbType.Decimal) { Value = objNew.Parcial3 });
            lstParametros.Add(new SqlParameter("@CFinal", SqlDbType.Decimal) { Value = objNew.Califinal });
            lstParametros.Add(new SqlParameter("@Apro", SqlDbType.NVarChar, 2) { Value = objNew.Aprobado });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("SubirCalificacion", lstParametros.ToArray()))
                return true;
            return false;
        }
        /// <summary>
        /// Cambia el estado del alumno cuando cubrio todos los talleres
        /// </summary>
        /// <param name="Opcion">La opción se que ejectura, valor 1</param>
        /// <param name="matricula">Matricula del alumnno</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool Liberar(int Opcion, int matricula)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Matricula", SqlDbType.Int) { Value = matricula });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("Liberar", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        #region CONSULTAS; LISTARDATOS, DATOS-ALUMNO, CALIFICACIONES, ALUMNOS CON FILTROS, CARTAS GENERADAS, CARTAS POR GENERAR
        /// <summary>
        /// Consulta diversos datos depediendo de la opcion
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
        /// Consulta de datos del alumno dependiendo de la opción: datos, promedio global
        /// </summary>
        /// <param name="Opcion">  1--Datos principales del Alumno, 6--Promedio</param>
        /// <param name="Matricula">Matricula del alumno a consultar</param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool ConsultaAlumno(int Opcion, string Matricula, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Consulta", SqlDbType.NVarChar, 250) { Value = Matricula });

            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("VEAlumno", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
        /// <summary>
        /// Muestra los alumnos y las calificaciones
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="Disiciplina"></param>
        /// <param name="Anio"></param>
        /// <param name="Periodo"></param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns></returns>
        public bool ListarCalificaciones(int Opcion, string Disiciplina, int Anio, string Periodo, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Taller", SqlDbType.NVarChar, 250) { Value = Disiciplina });
            lstParametros.Add(new SqlParameter("@Anio", SqlDbType.Int) { Value = Anio });
            lstParametros.Add(new SqlParameter("@Periodo", SqlDbType.NVarChar, 100) { Value = Periodo });

            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("ListarCalificaciones", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;

        }
        /// <summary>
        /// Consulta de alumnos deacuerdo a los parametros siguientes:
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="Disiciplina"></param>
        /// <param name="Anio"></param>
        /// <param name="Periodo"></param>
        /// <param name="Carrera"></param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool consultageneral(int Opcion, string Disiciplina, string Anio, string Periodo, string Carrera, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Taller", SqlDbType.NVarChar, 250) { Value = Disiciplina });
            lstParametros.Add(new SqlParameter("@Anio", SqlDbType.Int) { Value = Anio });
            lstParametros.Add(new SqlParameter("@Periodo", SqlDbType.NVarChar, 100) { Value = Periodo });
            lstParametros.Add(new SqlParameter("@Carrera", SqlDbType.NVarChar, 100) { Value = Carrera });

            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("ConsultaGSimple", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;

        }
        /// <summary>
        /// Muestra a los alumnos que se les a generado su carta acorde a los parametros.
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="mes"></param>
        /// <param name="anio"></param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns></returns>
        public bool MesLiberadas(int Opcion, string mes, string anio, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Mes", SqlDbType.NVarChar, 10) { Value = mes });
            lstParametros.Add(new SqlParameter("@Anio", SqlDbType.NVarChar, 10) { Value = anio });

            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("ConsultaCartas", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
        /// <summary>
        /// Muestra ls alumnos los cuales tiene liberado sus talleres, pero no tiene su carta
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="carrera"></param>
        /// <param name="objDatos">Se almacena los datos de la consulta</param>
        /// <returns></returns>
        public bool LiberadoSinCarta(int Opcion, string carrera, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@carrera", SqlDbType.NVarChar, 20) { Value = carrera });

            objManagerBD = new ManagerBD();
            objDatos = objManagerBD.GetData("ConsultaCartasNoGeneradas", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
        #endregion
    }
}
