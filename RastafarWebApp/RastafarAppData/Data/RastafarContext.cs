using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RastafarWebApp.Data.Models;
using RastafarWebApp.Data.Models.Enums;

namespace RastafarWebApp.Data
{
    public class RastafarContext : IdentityDbContext
    {
        private Post testPost1 { get; set; }
        private Post testPost2 { get; set; }
        private Post testPost3 { get; set; }
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
                .HasData(testPost1, testPost2, testPost3);


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
                OwnerId = "7540a0ae-e992-4280-af31-14df7178f178",
                ImgsUrl = "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg",
                CreatedOn = DateTime.Now
            };

			testPost2 = new Post()
			{
				Id = 2,
				Name = "Campers and chill in Gradina",
				Description = "We are going to camp on the beach in one of the biggest camps in bulgaria.",
				campType = (CampType)3,
				travelType = (TravelType)4,
				Destination = "Gradina",
				OwnerId = "7540a0ae-e992-4280-af31-14df7178f178",
				ImgsUrl = "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg",
				CreatedOn = DateTime.Now
			};

            testPost3 = new Post()
            {
                Id = 3,
                Name = "Travel trough black sea",
                Description = "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol",
                campType = (CampType)4,
                travelType = (TravelType)4,
                Destination = "BlackSea",
                OwnerId = "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8",
                ImgsUrl = "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597",
                CreatedOn = DateTime.Parse("01.05.2023")
			};
		}
    }
}