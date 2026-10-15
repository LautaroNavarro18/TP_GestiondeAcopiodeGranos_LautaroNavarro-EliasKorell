using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public interface IProductorRepositorio
    {
        void Agregar(Productor productor);
        void Modificar(Productor productor);
        void Eliminar(int id);
        Productor ObtenerPorId(int id);
        List<Productor> ObtenerTodos();
    }
}
