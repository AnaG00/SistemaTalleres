using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Nucleo.Modelo
{
    public class ManagerBD
    {

        public string strCadenaConexion
        { get; set; }

        public string cadena
        { get;set; }

        public ManagerBD()
        {
          
        }
           
        public SqlConnection GetConnection1()
        {
            strCadenaConexion = ConfigurationManager.ConnectionStrings["Cadena1"].ConnectionString;
            SqlConnection sqlConexionBD = new SqlConnection(strCadenaConexion);
            try
            {
                sqlConexionBD.Open();
            }
            catch (Exception)
            {
                sqlConexionBD.Close();
            }
            return sqlConexionBD;
        }
   

        /// <summary>
        /// Autor: MHR
        /// Realiza la consulta de datos de acuerdo a los parametros de Busqueda recibidos
        /// </summary>
        /// <param name="spStoreProcedure">Nombre del Procemiento Almacenado</param>
        /// <param name="sqlParameters">Lista de parametros</param>
        /// <returns>Colección de Datos</returns>
        public DataSet GetData(string spStoreProcedure, SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConexion = null;
            SqlCommand sqlComman = null;
            SqlDataAdapter sqlDataAdapter;
            DataSet datColeccionDatos = new DataSet();

            try
            {
                sqlConexion = GetConnection1();
                using (sqlConexion)
                {
                    sqlComman = new SqlCommand(spStoreProcedure, sqlConexion);
                    using (sqlComman)
                    {
                        sqlComman.CommandType = CommandType.StoredProcedure;

                        if (sqlParameters != null)
                            sqlComman.Parameters.AddRange(sqlParameters);

                        sqlDataAdapter = new SqlDataAdapter(sqlComman);
                        sqlDataAdapter.Fill(datColeccionDatos,"Datos");
                    }
                }
            }
            catch (Exception exeExcepcion)
            {
                exeExcepcion.Message.ToString();
            }
            finally
            {
                if (sqlConexion != null)
                {
                    if (sqlConexion.State == ConnectionState.Open)
                        sqlConexion.Close();
                }
            }
            return datColeccionDatos;
        }


        /// <summary>
        /// Autor: MHR
        /// Operaciones: Insertar, Modificar y Eliminar Datos en la BD.
        /// </summary>
        /// <param name="spStoreProcedure">Nombre del Procedimiento Almacenado</param>
        /// <param name="sqlParameters">Lista de parametros</param>
        /// <returns>Verdadero / Falso: Datos Registrados</returns>
        public bool UpdateData(string spStoreProcedure, SqlParameter[] sqlParameters)
        {
            SqlConnection sqlConexion = null;
            SqlCommand sqlComman = null;
            SqlTransaction sqlTransaction = null;
            int intRegistrosAfectados = 0;
            bool bolRegisterData = false;

            try
            {
                sqlConexion = this.GetConnection1();
                using (sqlConexion)
                {
                    sqlTransaction = sqlConexion.BeginTransaction();
                    sqlComman = new SqlCommand(spStoreProcedure, sqlConexion);
                    using (sqlComman)
                    {
                        sqlComman.Transaction = sqlTransaction;
                        sqlComman.CommandType = CommandType.StoredProcedure;

                        if (sqlParameters != null)
                            sqlComman.Parameters.AddRange(sqlParameters);

                        sqlTransaction.Commit();
                        intRegistrosAfectados = sqlComman.ExecuteNonQuery();
                    }

                    if (intRegistrosAfectados > 0)
                        bolRegisterData = true;
                }
            }
            catch (Exception exExcepcion1)
            {
                try
                {
                    sqlTransaction.Rollback();
                    exExcepcion1.Message.ToString();
                }
                catch (Exception exExcepcion2)
                {
                    exExcepcion2.Message.ToString();
                }
                exExcepcion1.Message.ToString();
            }
            finally
            {
                if (sqlConexion != null)
                {
                    if (sqlConexion.State == ConnectionState.Open)
                        sqlConexion.Close();
                }
            }
            return bolRegisterData;
        }
    }
}
