using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Nucleo.Modelo
{
    class CCarrera
    {
        ManagerBD objManagerBD;
        public CCarrera()
        {
            objManagerBD = new ManagerBD();
        }
        public bool ObtenerDatos(int Opcion, ref DataSet objDatos)
        {
            bool ExiteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = Opcion });
            objDatos = objManagerBD.GetData("Listar", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExiteDatos = true;
            return ExiteDatos;
        }
    }
}
