using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RastafarWebApp.Data.Models;
using RastafarWebApp.Data.Models.Enums;

namespace RastafarWebApp.Data
{
    public class RastafarContext : IdentityDbContext
    {
        private Post testPost1 { get; set; }
        public RastafarContext(DbContextOptions<RastafarContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<IdentityUserPosts> UsersPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserPosts>()
                .HasKey(ip => new { ip.PostId, ip.ParticipantId });

            SeedEvents();

            builder.Entity<Post>()
                .HasData(testPost1);


        }

        private void SeedEvents()
        {
            testPost1 = new Post()
            {
                Id = 1,
                Name = "Camping in Sinemorets",
                Description = "We are going to camp in the forest next to beach Butamqta in Sinemorec",
                campType = (CampType)1,
                travelType = (TravelType)1,
                Destination = "Sinemorec",
                OwnerId = "cd98eb91-adb9-43f2-9e74-3c201e04b4d3",
                ImgsUrl = new List<string>()
                {
                    "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg"
                }
            };
        }
    }
}