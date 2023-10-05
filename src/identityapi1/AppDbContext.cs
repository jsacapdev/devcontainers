using Microsoft.EntityFrameworkCore;

namespace identityapi1;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {
    }
}
