using HiparAppData.Data.Models;
using HiparAppTests.Mocks;
using Microsoft.AspNetCore.Identity;
using RastafarAppData.Data.Models;
using RastafarWebApp.Data;
using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	public class UnitTestsBase
	{
		protected RastafarContext context;


		public Post testPost1 { get; set; }
		public Post testPost2 { get; set; }
		public Post testPost3 { get; set; }

		public CampType tent { get; set; }
		public CampType hammok { get; set; }
		public CampType caravan { get; set; }
		public CampType camper { get; set; }
		public CampType bungalow { get; set; }

		public TravelType none { get; set; }
		public TravelType train { get; set; }
		public TravelType bus { get; set; }
		public TravelType plain { get; set; }
		public TravelType shareTravel { get; set; }

		public Country bulgaria { get; set; }
		public Country greece { get; set; }
		public Country turkey { get; set; }

		public Camp gradina { get; set; }
		public Camp saravari { get; set; }
		public Camp boshkaada { get; set; }

		public Product product1 { get; set; }
		public Product product2 { get; set; }
		public Product product3 { get; set; }

		public ApplicationUser admin { get; set; }
		public ApplicationUser user1 { get; set; }

		public IdentityRole adminRole { get; set; }

		public IdentityUserRole<string> userRoleAdmin { get; set; }


		[OneTimeSetUp]
		public void SetUpBase()
		{
			context = DatabaseMock.Instance;
			SeedDatabase();
		}

		[OneTimeTearDown]
		public void TearDownBase()
		{
			context.Dispose();
		}

		private void SeedDatabase()
		{
			SeedUsers();
			context.Users.Add(admin);
			context.Users.Add(user1);

			SeedRoles();
			context.Roles.Add(adminRole);

			SeedUserRoles();
			context.UserRoles.Add(userRoleAdmin);

			SeedCampTypes();
			context.CampTypes.Add(tent);
			context.CampTypes.Add(hammok);
			context.CampTypes.Add(caravan);
			context.CampTypes.Add(camper);
			context.CampTypes.Add(bungalow);

			SeedTravelTypes();
			context.TravelTypes.AddRange(train, bus, shareTravel, none, plain);

			SeedEvents();
			context.Posts.AddRange(testPost1, testPost2, testPost3);

			SeedCountries();
			context.Countries.AddRange(bulgaria, turkey, greece);

			SeedCamps();
			context.Camps.AddRange(saravari, gradina, boshkaada);

			SeedProducts();
			context.Products.AddRange(product1, product2, product3);

			context.SaveChanges();
		}

		private void SeedUsers()
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			admin = new ApplicationUser()
			{
				Image = "https://z-p3-scontent.fskg1-1.fna.fbcdn.net/v/t1.15752-9/367483380_254225674190931_6660571953597606357_n.jpg?_nc_cat=108&cb=99be929b-59f725be&ccb=1-7&_nc_sid=510075&_nc_ohc=cP_4NBUNEWAAX-f4BEl&_nc_ht=z-p3-scontent.fskg1-1.fna&oh=03_AdTtHrrDehU39JJDnP0CJ3F9l2R7BiAANbI1pZok2mxZ5A&oe=65016CAA",
				FistName = "Emil",
				LastName = "Savov",
				UserName = "Car Hipar",
				Age = 16,
				Id = Guid.NewGuid().ToString(),
				NormalizedUserName = "Car Hipar".ToUpper(),
				Email = "embakks@gmail.com",
				NormalizedEmail = "embakks@gmail.com"
			};

			admin.PasswordHash = hasher.HashPassword(admin, "admin123");

			user1 = new ApplicationUser()
			{
				Image = "https://scontent.xx.fbcdn.net/v/t1.15752-9/367410880_248954934732977_4076882259522423148_n.jpg?stp=dst-jpg_p180x540&_nc_cat=101&cb=99be929b-59f725be&ccb=1-7&_nc_sid=510075&_nc_ohc=7QXwtqRoJUMAX8SULHh&_nc_ad=z-m&_nc_cid=0&_nc_ht=scontent.xx&oh=03_AdRDfvnD_b7noUC6HzF2v4kUmCYjtJdBnrSOKFd_j0bnJg&oe=65016737",
				FistName = "Test",
				LastName = "User",
				Age = 20,
				Id = Guid.NewGuid().ToString(),
				UserName = "testuser@gmail.com",
				NormalizedUserName = "testuser@gmail.com".ToUpper(),
				Email = "testuser@gmail.com",
				NormalizedEmail = "testuser@gmail.com"
			};

			user1.PasswordHash = hasher.HashPassword(user1, "admin123");

		}
		private void SeedRoles()
		{
			adminRole = new IdentityRole()
			{
				Id = Guid.NewGuid().ToString(),
				Name = "Admin",
				NormalizedName = "ADMIN"
			};
		}
		private void SeedUserRoles()
		{
			userRoleAdmin = new IdentityUserRole<string>()
			{
				RoleId = adminRole.Id,
				UserId = admin.Id
			};
		}
		private void SeedProducts()
		{
			product1 = new Product()
			{
				Id = Guid.NewGuid(),
				Name = "Summar Hammok",
				Description = "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.",
				ImgUrl = "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426",
				Price = 20.00m,
				CreatedOn = DateTime.Now
			};

			product2 = new Product()
			{
				Id = Guid.NewGuid(),
				Name = "Camping Cup",
				Description = "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers",
				ImgUrl = "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg",
				Price = 15.99m,
				CreatedOn = DateTime.Now
			};

			product3 = new Product()
			{
				Id = Guid.NewGuid(),
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
				Id = Guid.NewGuid(),
				Name = "Bulgaria",
				Camps = new List<Camp>()
			};

			greece = new Country()
			{
				Id = Guid.NewGuid(),
				Name = "Greece",
				Camps = new List<Camp>()
			};

			turkey = new Country()
			{
				Id = Guid.NewGuid(),
				Name = "Turkey",
				Camps = new List<Camp>()
			};
		}

		private void SeedCamps()
		{

			gradina = new Camp()
			{
				Id = Guid.NewGuid(),
				CountryId = bulgaria.Id,
				Name = "Gradina",
				Image = "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG",

				Posts = new List<Post>()
			};

			saravari = new Camp()
			{
				Id = Guid.NewGuid(),
				CountryId = greece.Id,
				Name = "Saravari",
				Image = "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg",
				Posts = new List<Post>()
			};

			boshkaada = new Camp()
			{
				Id = Guid.NewGuid(),
				CountryId = turkey.Id,
				Name = "Bozcaada",
				Image = "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg",
				Posts = new List<Post>()
			};
		}

		private void SeedEvents()
		{
			testPost1 = new Post()
			{
				Id = Guid.NewGuid(),
				Name = "Camping in Sinemorets",
				Description = "We are going to camp in the forest next to beach Butamqta in Sinemorec",
				CampTypeId = tent.Id,
				TravelTypeId = none.Id,
				Destination = "Sinemorec",
				OwnerId = admin.Id,
				ImgsUrl = "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg",
				CreatedOn = DateTime.Now
			};

			testPost2 = new Post()
			{
				Id = Guid.NewGuid(),
				Name = "Campers and chill in Gradina",
				Description = "We are going to camp on the beach in one of the biggest camps in bulgaria.",
				CampTypeId = caravan.Id,
				TravelTypeId = plain.Id,
				Destination = "Gradina",
				OwnerId = admin.Id,
				ImgsUrl = "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg",
				CreatedOn = DateTime.Now
			};

			testPost3 = new Post()
			{
				Id = Guid.NewGuid(),
				Name = "Travel trough black sea",
				Description = "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol",
				CampTypeId = camper.Id,
				TravelTypeId = plain.Id,
				Destination = "BlackSea",
				OwnerId = user1.Id,
				ImgsUrl = "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597",
				CreatedOn = DateTime.Parse("01.05.2023")
			};
		}

		private void SeedCampTypes()
		{
			this.tent = new CampType()
			{
				Id = Guid.NewGuid(),
				Name = "Tent",
				Posts = new List<Post>()
			};

			this.hammok = new CampType()
			{
				Id = Guid.NewGuid(),
				Name = "Hammok",
				Posts = new List<Post>()
			};

			this.caravan = new CampType()
			{
				Id = Guid.NewGuid(),
				Name = "Caravan",
				Posts = new List<Post>()
			};

			this.camper = new CampType()
			{
				Id = Guid.NewGuid(),
				Name = "Camper",
				Posts = new List<Post>()
			};

			this.bungalow = new CampType()
			{
				Id = Guid.NewGuid(),
				Name = "Bungalow",
				Posts = new List<Post>()
			};
		}

		private void SeedTravelTypes()
		{
			this.none = new TravelType()
			{
				Id = Guid.NewGuid(),
				Name = "None",
				Posts = new List<Post>()
			};

			this.train = new TravelType()
			{
				Id = Guid.NewGuid(),
				Name = "Train",
				Posts = new List<Post>()
			};

			this.bus = new TravelType()
			{
				Id = Guid.NewGuid(),
				Name = "Bus",
				Posts = new List<Post>()
			};

			this.plain = new TravelType()
			{
				Id = Guid.NewGuid(),
				Name = "Plain",
				Posts = new List<Post>()
			};

			this.shareTravel = new TravelType()
			{
				Id = Guid.NewGuid(),
				Name = "Share Travel",
				Posts = new List<Post>()
			};
		}
	}
}
