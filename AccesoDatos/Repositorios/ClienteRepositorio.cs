using AccesoDatos.Entidades;

namespace AccesoDatos.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public void Agregar(Cliente cliente)
        {
            using var context = new AcopioContext();
            context.Clientes
                .Add(cliente);
            context
                .SaveChanges();
        }

        public void Modificar(Cliente cliente)
        {
            using var context = new AcopioContext();
            context.Clientes
                .Update(cliente);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = new AcopioContext();
            Cliente cliente = context.Clientes
                .Find(id);
            if (cliente != null)
            {
                cliente.Activo = false;
                context
                    .SaveChanges();
            }
        }

        public Cliente ObtenerPorId(int id)
        {
            using var context = new AcopioContext();
            return context.Clientes
                .Find(id);
        }

        public List<Cliente> ObtenerTodos()
        {
            using var context = new AcopioContext();
            return context.Clientes
                .Where(c => c.Activo)
                .ToList();
        }
    }
}
