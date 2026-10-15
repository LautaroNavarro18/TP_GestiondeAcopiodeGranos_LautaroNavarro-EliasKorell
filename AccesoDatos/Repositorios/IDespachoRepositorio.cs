using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public interface IDespachoRepositorio
    {
        void Agregar(Despacho despacho);
        void Modificar(Despacho despacho);
        void Eliminar(int id);
        Despacho ObtenerPorId(int id);
        List<Despacho> ObtenerTodos();
    }
}
