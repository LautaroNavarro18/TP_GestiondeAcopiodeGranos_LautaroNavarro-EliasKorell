using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public interface IClienteRepositorio
    {
        void Agregar(Cliente cliente);
        void Modificar(Cliente cliente);
        void Eliminar(int id);
        Cliente ObtenerPorId(int id);
        List<Cliente> ObtenerTodos();
    }
}
