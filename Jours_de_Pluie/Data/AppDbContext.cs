using Microsoft.EntityFrameworkCore;

namespace Jours_de_Pluie.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //commit here
        }
    }
}
