using AccesoDatos;
using Microsoft.EntityFrameworkCore;

namespace AppWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var context = new AcopioContext())
            {
                context.Database.Migrate();
            }

            Application.Run(new FormProductores());
        }
    }
}
