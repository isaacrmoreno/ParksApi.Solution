using Microsoft.EntityFrameworkCore;

namespace StateParksApi.Models
{
  public class StateParksApiContext : DbContext
  {
    public StateParksApiContext(DbContextOptions<StateParksApiContext> options) : base(options) { }

    public DbSet<StatePark> StateParks { get; set; }
    // protected override void OnModelCreating(ModelBuilder builder)
    //   {
    //     builder.Entity<StatePark>()
    //     .HasData(
    //       new StatePark { StateParkId = 1, ParkName = "Alfred A. Loeb State Park", ParkDescription = "Alfred A. Loeb State Park, known simply as 'Loeb' by the locals, is nestled in a dense grove of ancient Myrtlewood trees along the Chetco River, eight miles inland from Oregon's southern coastline. This quiet park is located away from town and industry — a chorus of owls will lull you to sleep. Several campsites and three rental cabins face the scenic river.  During the year, you can fish, swim and raft, or walk the Riverview Nature Trail. The river offers some of the finest fall and winter salmon and steelhead fishing on the south coast. You can plunk from the bank or try your luck on a drift boat. Throughout spring and summer you may see scampering squirrels, soaring osprey, or a family of river otters frolicking in the water. The northern-most redwood grove in the U.S. can be found at the end of the Riverview Nature Trail by crossing the North Bank Road and hiking the 1-mile U.S. Forest Service Redwood Loop.", AmenitiesFacilities = "Camping (Accessible)",
    //       // ,"Cabin""Picknicking","Restrooms Flush (Accessible)","Hot Shower (Accessible)","Cabin/Yurts Pets OK", 
    //       Region = "Oregon Coast"}
    //     );
    //   }
  }
}