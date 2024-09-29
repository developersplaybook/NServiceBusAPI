using Microsoft.EntityFrameworkCore;

namespace Server.DAL
{
    public class NServiceBusDbContext : DbContext
    {
        public NServiceBusDbContext(DbContextOptions<NServiceBusDbContext> options)
            : base(options)
        {
        }
    }
}