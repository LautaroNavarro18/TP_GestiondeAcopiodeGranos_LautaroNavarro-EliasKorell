using AccesoDatos;
using AccesoDatos.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();

            services
                .AddDbContextFactory<AcopioContext>(options => options
                    .UseSqlite(AcopioContext.CadenaConexion));

            services
                .AddTransient<IProductorRepositorio, ProductorRepositorio>();
            services
                .AddTransient<ICerealRepositorio, CerealRepositorio>();
            services
                .AddTransient<IClienteRepositorio, ClienteRepositorio>();
            services
                .AddTransient<IDescargaRepositorio, DescargaRepositorio>();
            services
                .AddTransient<IDespachoRepositorio, DespachoRepositorio>();
            services
                .AddTransient<IReporteRepositorio, ReporteRepositorio>();

            services
                .AddTransient<FormPrincipal>();
            services
                .AddTransient<FormProductores>();
            services
                .AddTransient<FormCereales>();
            services
                .AddTransient<FormClientes>();
            services
                .AddTransient<FormDescargas>();
            services
                .AddTransient<FormDespachos>();
            services
                .AddTransient<FormReportes>();

            using ServiceProvider serviceProvider = services
                .BuildServiceProvider();

            using (var context = serviceProvider
                .GetRequiredService<IDbContextFactory<AcopioContext>>()
                .CreateDbContext())
            {
                context.Database
                    .Migrate();
            }

            Application.Run(serviceProvider
                .GetRequiredService<FormPrincipal>());
        }
    }
}
