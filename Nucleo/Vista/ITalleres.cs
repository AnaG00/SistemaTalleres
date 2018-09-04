
using System.Data;
using Nucleo.Modelo;

namespace Nucleo.Vista
{
    public interface ITalleres
    {
        void Mensaje(string imagen, string titulo, string texto);
        CTalleres Taller { get; }
        CProfesor Profesor { get; }
        DataSet ListarTaller { set; }
        DataSet ListarProfesor { set; }
        DataSet ObtenerUnDato { set; }
    }
}
