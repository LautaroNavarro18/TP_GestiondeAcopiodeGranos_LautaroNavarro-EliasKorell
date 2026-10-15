using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public interface IDescargaRepositorio
    {
        void Agregar(Descarga descarga);
        void Modificar(Descarga descarga);
        void Eliminar(int id);
        Descarga ObtenerPorId(int id);
        List<Descarga> ObtenerTodos();
    }
}
