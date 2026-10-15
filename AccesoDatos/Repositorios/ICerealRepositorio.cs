using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public interface ICerealRepositorio
    {
        void Agregar(Cereal cereal);
        void Modificar(Cereal cereal);
        void Eliminar(int id);
        Cereal ObtenerPorId(int id);
        List<Cereal> ObtenerTodos();
    }
}
