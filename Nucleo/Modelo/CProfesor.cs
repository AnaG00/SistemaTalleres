/**
 * Archivo: CProfesor.cs
 * Autor: ALGO
 * Fecha: Febrero - Julio 2018
 * Descripción:  Realiza acciones manipulando el usuario Profesor o coordinador, interacción con la BD.
 **/
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Nucleo.Modelo
{
    public class CProfesor
    {
        ManagerBD objManagerBD;
        #region ATRIBUTOS/PROPIEDADES
        public string NombreProfesor { get; set; }
        public int NoControl { get; set; }
        public string Pass { get; set; }
        public string Cargo { get; set; }
        #endregion

        public CProfesor()
        {
            objManagerBD = new ManagerBD();
        }

        #region REGISTRO USUARIO
        /// <summary>
        /// Registro de usuarios del sistema; profesor o coordinador, administrador
        /// </summary>
        /// <param name="Opcion">Valor 1</param>
        /// <param name="objNew">Datos del usuario</param>
        /// <returns>Verdadero / Falso: Acción realizada</returns>
        public bool RegistroUsuario(int Opcion, CProfesor objNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 250) { Value = objNew.NombreProfesor });
            lstParametros.Add(new SqlParameter("@NoControl", SqlDbType.Int) { Value = objNew.NoControl });
            lstParametros.Add(new SqlParameter("@Contraseña", SqlDbType.NVarChar, 50) { Value = objNew.Pass });
            lstParametros.Add(new SqlParameter("@Cargo", SqlDbType.NVarChar, 50) { Value = objNew.Cargo});

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("RegistroU", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        #region MODIFICAR: CONTRASEÑA, NOMBRE
        public bool CambioPassword(int Opcion, string usuario, string passswordOld, string passwordNew)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = 1 });
            lstParametros.Add(new SqlParameter("@NoCtrol", SqlDbType.NVarChar, 50) { Value = usuario });
            lstParametros.Add(new SqlParameter("@PassOld", SqlDbType.NVarChar, 50) { Value = passswordOld });
            lstParametros.Add(new SqlParameter("@PassNew", SqlDbType.NVarChar, 50) { Value = passwordNew });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("CambiarPass", lstParametros.ToArray()))
                return true;
            return false;
        }

        public bool CambiarNombre(int Opcion, string clave, string Nnombre)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            lstParametros.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 250) { Value = Nnombre });
            lstParametros.Add(new SqlParameter("@Control", SqlDbType.Int) { Value = clave });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("NomProfesor", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion        
    }
}
