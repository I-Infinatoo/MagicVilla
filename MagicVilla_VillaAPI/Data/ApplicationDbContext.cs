using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    /* DbContext : includes the methods
     *  for dealing with DB
     */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }


        /* DbSet<>
        * querying is done by using 'link statements' and
        * link statements can automatically be converted
        * in to SQL statements
        */
        /* Name of this entity will become the Table Name in DB
         */
        public DbSet<Villa> Villas { get; set; }


        /* For auto filling the table.
         * i.e. Auto migration
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa {
                    Id = 1,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Name = "Royal Villa",
                    Occupancy = 4,
                    Rate = 200.0,
                    Sqft = 550
                },
                new Villa
                {
                    Id = 2,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Name = "Premium Pool Villa",
                    Occupancy = 4,
                    Rate = 300.0,
                    Sqft = 550
                },
                new Villa
                {
                    Id = 3,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                    Name = "Luxury Pool Villa",
                    Occupancy = 4,
                    Rate = 400.0,
                    Sqft = 750,
                    UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                },
                new Villa
                {
                    Id = 4,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                    Name = "Diamond Villa",
                    Occupancy = 4,
                    Rate = 550.0,
                    Sqft = 900,
                    UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                },
                new Villa
                {
                    Id = 5,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                    Name = "Diamond Pool Villa",
                    Occupancy = 4,
                    Rate = 600.0,
                    Sqft = 1100,
                    UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                }
                );
        }
    }
}
