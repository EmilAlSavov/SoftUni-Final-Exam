using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RastafarAppData.Data.Models;
using RastafarWebApp.Data.Models;

namespace RastafarWebApp.Data
{
    public class RastafarContext : IdentityDbContext
    {
        private Post testPost1 { get; set; }
        private Post testPost2 { get; set; }
        private Post testPost3 { get; set; }

        private CampType tent { get; set; }
        private CampType hammok { get; set; }
        private CampType caravan { get; set; }
        private CampType camper { get; set; }
        private CampType bungalow { get; set; }

        private TravelType none { get; set; }
        private TravelType train { get; set; }
        private TravelType bus { get; set; }
        private TravelType plain { get; set; }
        private TravelType shareTravel { get; set; }

        private Country bulgaria { get; set; }
        private Country greece { get; set; }
        private Country turkey { get; set; }

        private Camp gradina { get; set; }
        private Camp saravari { get; set; }
        private Camp boshkaada { get; set; }

        private Product product1 { get; set; }
        private Product product2 { get; set; }
        private Product product3 { get; set; }

        public RastafarContext(DbContextOptions<RastafarContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<IdentityUserPosts> UsersPosts { get; set; }

        public DbSet<CampType> CampTypes { get; set; }

        public DbSet<TravelType> TravelTypes { get; set; }

        public DbSet<Camp> Camps { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserPosts>()
                .HasKey(ip => new { ip.PostId, ip.ParticipantId });

            SeedCampTypes();
            builder.Entity<CampType>()
                .HasData(tent, hammok, caravan, camper, bungalow);

            SeedTravelTypes();
            builder.Entity<TravelType>()
                .HasData(none, train, bus, plain, shareTravel);

            SeedEvents();

            builder.Entity<Post>()
                .HasData(testPost1, testPost2, testPost3);

            SeedCountries();
            builder.Entity<Country>()
                .HasData(bulgaria, greece, turkey);

            SeedCamps();
            builder.Entity<Camp>()
                .HasData(gradina, saravari, boshkaada);

            SeedProducts();
            builder.Entity<Product>()
                .HasData(product1, product2, product3);
        }

        private void SeedProducts()
        {
            product1 = new Product()
            {
                Id = 1,
                Name = "Summar Hammok",
                Description = "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.",
                ImgUrl = "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426",
                Price = 20.00m,
                CreatedOn = DateTime.Now
            };

            product2 = new Product()
            {
                Id = 2,
                Name = "Camping Cup",
                Description = "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers",
                ImgUrl = "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg",
                Price = 15.99m,
                CreatedOn = DateTime.Now
            };

            product3 = new Product()
            {
                Id = 3,
                Name = "Pocket Ashtray",
                Description = "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!",
                ImgUrl = "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff",
                Price = 10,
                CreatedOn = DateTime.Now
            };
        }

        private void SeedCountries()
        {
            bulgaria = new Country()
            {
                Id = 1,
                Name = "Bulgaria",
                Camps = new List<Camp>()
            };

            greece = new Country()
            {
                Id = 2,
                Name = "Greece",
                Camps = new List<Camp>()
            };

            turkey = new Country()
            {
                Id = 3,
                Name = "Turkey",
                Camps = new List<Camp>()
            };
        }

        private void SeedCamps()
        {
            gradina = new Camp()
            {
                Id = 1,
                CountryId = 1,
                Name = "Gradina",
                Posts = new List<Post>()
            };

            saravari = new Camp()
            {
                Id = 2,
                CountryId = 2,
                Name = "Saravari",
                Posts = new List<Post>()
            };

            boshkaada = new Camp()
            {
                Id = 3,
                CountryId = 3,
                Name = "Boshkaada",
                Posts = new List<Post>()
            };
        }

        private void SeedEvents()
        {
            testPost1 = new Post()
            {
                Id = 1,
                Name = "Camping in Sinemorets",
                Description = "We are going to camp in the forest next to beach Butamqta in Sinemorec",
                CampTypeId = 1,
                TravelTypeId = 1,
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
				CampTypeId = 3,
				TravelTypeId = 4,
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
                CampTypeId = 4,
                TravelTypeId = 4,
                Destination = "BlackSea",
                OwnerId = "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8",
                ImgsUrl = "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597",
                CreatedOn = DateTime.Parse("01.05.2023")
			};
		}

        private void SeedCampTypes()
        {
            this.tent = new CampType()
            {
                Id = 1,
                Name = "Tent",
                Posts = new List<Post>()
            };

            this.hammok = new CampType()
            {
                Id = 2,
                Name = "Hammok",
                Posts = new List<Post>()
            };

            this.caravan = new CampType()
            {
                Id = 3,
                Name = "Caravan",
                Posts = new List<Post>()
            };

            this.camper = new CampType()
            {
                Id = 4,
                Name = "Camper",
                Posts = new List<Post>()
            };

            this.bungalow = new CampType()
            {
                Id = 5,
                Name = "Bungalow",
                Posts = new List<Post>()
            };
        }

        private void SeedTravelTypes()
        {
            this.none = new TravelType()
            {
                Id = 1,
                Name = "None",
                Posts = new List<Post>()
            };

            this.train = new TravelType()
            {
                Id = 2,
                Name = "Train",
                Posts = new List<Post>()
            };

            this.bus = new TravelType()
            {
                Id = 3,
                Name = "Bus",
                Posts = new List<Post>()
            };

            this.plain = new TravelType()
            {
                Id = 4,
                Name = "Plain",
                Posts = new List<Post>()
            };

            this.shareTravel = new TravelType()
            {
                Id = 5,
                Name = "Share Travel",
                Posts = new List<Post>()
            };
        }
    }
}