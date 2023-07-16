﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RastafarWebApp.Data;

#nullable disable

namespace RastafarAppData.Migrations
{
    [DbContext(typeof(RastafarContext))]
    [Migration("20230716115137_ChangeIdsToGuids")]
    partial class ChangeIdsToGuids
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Camp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Camps");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca575d4d-3bdd-4617-af8b-3697e530931a"),
                            CountryId = new Guid("40e209ff-596f-4256-8059-fc430ee66146"),
                            Image = "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG",
                            Name = "Gradina"
                        },
                        new
                        {
                            Id = new Guid("af351011-87e8-4a41-b71d-563e43bf0ab6"),
                            CountryId = new Guid("0132a7a6-25c2-4bcc-b0a7-5304ea02d36b"),
                            Image = "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg",
                            Name = "Saravari"
                        },
                        new
                        {
                            Id = new Guid("4a79fcd8-56ba-4041-ab4f-7245cdda8f37"),
                            CountryId = new Guid("6fa7c81f-4b8b-43b7-ba69-b9362641871a"),
                            Image = "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg",
                            Name = "Bozcaada"
                        });
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.CampType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CampTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ceb85b7-ff4a-4bd3-befe-067e3a7688ae"),
                            Name = "Tent"
                        },
                        new
                        {
                            Id = new Guid("453055e3-7958-4926-824e-815666d68149"),
                            Name = "Hammok"
                        },
                        new
                        {
                            Id = new Guid("f4622d97-e7c8-477f-aedd-993ecd8d7cb3"),
                            Name = "Caravan"
                        },
                        new
                        {
                            Id = new Guid("34f8783d-b4dd-4ae4-bb3d-d47c6728a2de"),
                            Name = "Camper"
                        },
                        new
                        {
                            Id = new Guid("10acb856-f9b1-416c-a422-094b351111da"),
                            Name = "Bungalow"
                        });
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40e209ff-596f-4256-8059-fc430ee66146"),
                            Name = "Bulgaria"
                        },
                        new
                        {
                            Id = new Guid("0132a7a6-25c2-4bcc-b0a7-5304ea02d36b"),
                            Name = "Greece"
                        },
                        new
                        {
                            Id = new Guid("6fa7c81f-4b8b-43b7-ba69-b9362641871a"),
                            Name = "Turkey"
                        });
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8bd7c7d5-1046-4f86-9d91-025eb9ce780c"),
                            CreatedOn = new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4856),
                            Description = "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.",
                            ImgUrl = "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426",
                            Name = "Summar Hammok",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = new Guid("ad6ae157-ff89-4feb-99ed-aaadcd564c4c"),
                            CreatedOn = new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4864),
                            Description = "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers",
                            ImgUrl = "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg",
                            Name = "Camping Cup",
                            Price = 15.99m
                        },
                        new
                        {
                            Id = new Guid("2d14d2bb-f8dc-496b-b322-0ad1d994ab61"),
                            CreatedOn = new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4877),
                            Description = "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!",
                            ImgUrl = "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff",
                            Name = "Pocket Ashtray",
                            Price = 10m
                        });
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.TravelType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TravelTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8fe54c2b-b2bd-4a17-9616-fc06ccc1c6b9"),
                            Name = "None"
                        },
                        new
                        {
                            Id = new Guid("b398d39e-489b-40c8-8159-f16705da934e"),
                            Name = "Train"
                        },
                        new
                        {
                            Id = new Guid("1f32b3af-7440-4b6d-95c7-b0cc71c0d93d"),
                            Name = "Bus"
                        },
                        new
                        {
                            Id = new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623"),
                            Name = "Plain"
                        },
                        new
                        {
                            Id = new Guid("a4aedb8c-a41d-4df8-b013-86b6f742a541"),
                            Name = "Share Travel"
                        });
                });

            modelBuilder.Entity("RastafarWebApp.Data.Models.IdentityUserPosts", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("UsersPosts");
                });

            modelBuilder.Entity("RastafarWebApp.Data.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CampId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CampTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImgsUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("TravelTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CampId");

                    b.HasIndex("CampTypeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TravelTypeId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b11959e-5f0f-4579-be3e-943eef22dfdd"),
                            CampTypeId = new Guid("1ceb85b7-ff4a-4bd3-befe-067e3a7688ae"),
                            CreatedOn = new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4524),
                            Description = "We are going to camp in the forest next to beach Butamqta in Sinemorec",
                            Destination = "Sinemorec",
                            ImgsUrl = "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg",
                            Name = "Camping in Sinemorets",
                            OwnerId = "7540a0ae-e992-4280-af31-14df7178f178",
                            TravelTypeId = new Guid("8fe54c2b-b2bd-4a17-9616-fc06ccc1c6b9")
                        },
                        new
                        {
                            Id = new Guid("55023207-ba7b-4860-b8e5-96a5619a8b28"),
                            CampTypeId = new Guid("f4622d97-e7c8-477f-aedd-993ecd8d7cb3"),
                            CreatedOn = new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4572),
                            Description = "We are going to camp on the beach in one of the biggest camps in bulgaria.",
                            Destination = "Gradina",
                            ImgsUrl = "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg",
                            Name = "Campers and chill in Gradina",
                            OwnerId = "7540a0ae-e992-4280-af31-14df7178f178",
                            TravelTypeId = new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623")
                        },
                        new
                        {
                            Id = new Guid("0b6a58ab-d0f7-4300-9018-43aea2b18d84"),
                            CampTypeId = new Guid("34f8783d-b4dd-4ae4-bb3d-d47c6728a2de"),
                            CreatedOn = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol",
                            Destination = "BlackSea",
                            ImgsUrl = "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597",
                            Name = "Travel trough black sea",
                            OwnerId = "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8",
                            TravelTypeId = new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Camp", b =>
                {
                    b.HasOne("RastafarAppData.Data.Models.Country", "Country")
                        .WithMany("Camps")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("RastafarWebApp.Data.Models.IdentityUserPosts", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RastafarWebApp.Data.Models.Post", "Post")
                        .WithMany("Participants")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("RastafarWebApp.Data.Models.Post", b =>
                {
                    b.HasOne("RastafarAppData.Data.Models.Camp", "Camp")
                        .WithMany("Posts")
                        .HasForeignKey("CampId");

                    b.HasOne("RastafarAppData.Data.Models.CampType", "CampType")
                        .WithMany("Posts")
                        .HasForeignKey("CampTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RastafarAppData.Data.Models.TravelType", "TravelType")
                        .WithMany("Posts")
                        .HasForeignKey("TravelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camp");

                    b.Navigation("CampType");

                    b.Navigation("Owner");

                    b.Navigation("TravelType");
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Camp", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.CampType", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.Country", b =>
                {
                    b.Navigation("Camps");
                });

            modelBuilder.Entity("RastafarAppData.Data.Models.TravelType", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("RastafarWebApp.Data.Models.Post", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
