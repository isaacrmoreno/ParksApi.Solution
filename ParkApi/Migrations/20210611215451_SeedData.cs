using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StateParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ParkDescription = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AmenitiesFacilities = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Region = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AmenitiesFacilities", "ParkDescription", "ParkName", "Region" },
                values: new object[] { 1, "Camping (Accessible)", "Alfred A. Loeb State Park, known simply as 'Loeb' by the locals, is nestled in a dense grove of ancient Myrtlewood trees along the Chetco River, eight miles inland from Oregon's southern coastline. This quiet park is located away from town and industry — a chorus of owls will lull you to sleep. Several campsites and three rental cabins face the scenic river.  During the year, you can fish, swim and raft, or walk the Riverview Nature Trail. The river offers some of the finest fall and winter salmon and steelhead fishing on the south coast. You can plunk from the bank or try your luck on a drift boat. Throughout spring and summer you may see scampering squirrels, soaring osprey, or a family of river otters frolicking in the water. The northern-most redwood grove in the U.S. can be found at the end of the Riverview Nature Trail by crossing the North Bank Road and hiking the 1-mile U.S. Forest Service Redwood Loop.", "Alfred A. Loeb State Park", "Oregon Coast" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AmenitiesFacilities", "ParkDescription", "ParkName", "Region" },
                values: new object[] { 2, "Beach Access", "Diggers, this park's for you! Razor clamming is a favorite activity as well as surfing. If you plan to visit prime Newport attractions like the Oregon Coast Aquarium and Hatfield Marine Science Center, you must stop in for a refreshing picnic at Agate Beach.Agate Beach Wayside is situated between the new and old highway 101. There is a large parking lot with room for trailer parking. The beach access trail consists of a tunnel that goes underneath the old highway 101 to a large sandy beach area.", "Agate Beach State Recreation Site", "Oregon Coast" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AmenitiesFacilities", "ParkDescription", "ParkName", "Region" },
                values: new object[] { 3, "Cabin (Accessible)", "Champoeg State Heritage Area features a rare combination of history, nature, and recreation. Situated south of Newberg along the scenic Willamette River, Champoeg's forests, fields, and wetlands recreate the landscape of a bygone era. This is the site where Oregon's first provisional government was formed by a historical vote in 1843. A thriving town of 200 was established, only to be washed away during a great flood in 1861. This rich history earns the park’s placement on the National Register of Historic Places. A diversity of activities await. Enjoy walking or biking on the paved trails that pass historical landmarks and hug the river. Play the 18-hole disc golf course under the oak trees, relax at the multitude of scenic picnic areas, or fish or kayak from dock on the Willamette River. The ecologically rich landscape is home to more than 130 bird species, including seasonally nesting western bluebirds and acorn woodpeckers.", "Champoeg State Heritage Area", "Willamette Valley" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
