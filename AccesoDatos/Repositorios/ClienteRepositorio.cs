using AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IDbContextFactory<AcopioContext> _contextFactory;

        public ClienteRepositorio(IDbContextFactory<AcopioContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Agregar(Cliente cliente)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Clientes
                .Add(cliente);
            context
                .SaveChanges();
        }

        public void Modificar(Cliente cliente)
        {
            using var context = _contextFactory
                .CreateDbContext();
            context.Clientes
                .Update(cliente);
            context
                .SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var context = _contextFactory
                .CreateDbContext();
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
            using var context = _contextFactory
                .CreateDbContext();
            return context.Clientes
                .Find(id);
        }

        public List<Cliente> ObtenerTodos()
        {
            using var context = _contextFactory
                .CreateDbContext();
            return context.Clientes
                .Where(c => c.Activo)
                .ToList();
        }
    }
}
