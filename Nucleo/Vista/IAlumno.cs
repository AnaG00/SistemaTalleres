
using System.Data;
using Nucleo.Modelo;

namespace Nucleo.Vista
{
    public interface IAlumno
    {
        //Propiedades 
        void Mensaje(string imagen, string titulo, string texto);
        CAlumno Alumno { get; }
        DataSet Alumnos { set; }
        DataSet ListarAlumno { set; }
        DataSet Carreras { set; }
        DataSet Periodo { set; }
        DataSet Anios { set; }
        DataSet Disciplina { set; }
        DataSet Promedio { set; }

    }
}
