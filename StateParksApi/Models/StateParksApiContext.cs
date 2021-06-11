using Microsoft.EntityFrameworkCore;

namespace StateParksApi.Models
{
  public class StateParksApiContext : DbContext
  {
    public StateParksApiContext(DbContextOptions<StateParksApiContext> options)
        : base(options)
    {
    }

    public DbSet<Destination> Destinations { get; set; }
  }
}