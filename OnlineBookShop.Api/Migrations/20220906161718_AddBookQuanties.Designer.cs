﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBookShop.Api.Data;

#nullable disable

namespace OnlineBookShop.Api.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20220906161718_AddBookQuanties")]
    partial class AddBookQuanties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineBookShop.Api.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ola",
                            LastName = "Rotimi"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Carl",
                            LastName = "Sagan"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Jane",
                            LastName = "Austen"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Chimamanda Ngozi",
                            LastName = "Adichie"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Wendy",
                            LastName = "Northcutt"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Morgan",
                            LastName = "Housel"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "J.K",
                            LastName = "Rowlings"
                        });
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearPublished")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("GenreID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorID = 1,
                            GenreID = 4,
                            ISBN = "093281758302",
                            ImageURL = "/Images/Playwrights/the_gods_are_not_to_blame",
                            Price = 50.0,
                            Quantity = 0,
                            Title = "The Gods are not to Blame",
                            YearPublished = 1971
                        },
                        new
                        {
                            Id = 2,
                            AuthorID = 1,
                            GenreID = 4,
                            ISBN = "093200758302",
                            ImageURL = "Images/Playwrights/our_husband_has_gone_mad_again",
                            Price = 55.200000000000003,
                            Quantity = 12,
                            Title = "Our Husband has Gone Mad Again",
                            YearPublished = 1977
                        },
                        new
                        {
                            Id = 3,
                            AuthorID = 4,
                            GenreID = 1,
                            ISBN = "903200758302",
                            ImageURL = "/Images/Novels/americana",
                            Price = 70.0,
                            Quantity = 7,
                            Title = "Americana",
                            YearPublished = 2016
                        },
                        new
                        {
                            Id = 4,
                            AuthorID = 3,
                            GenreID = 1,
                            ISBN = "9032007583",
                            ImageURL = "/Images/Novels/pride_and_prejudice",
                            Price = 20.0,
                            Quantity = 10,
                            Title = "Pride and Prejudice",
                            YearPublished = 1918
                        },
                        new
                        {
                            Id = 5,
                            AuthorID = 5,
                            GenreID = 5,
                            ISBN = "903200752583",
                            ImageURL = "/Images/Documentaries/the_darwin_award",
                            Price = 45.899999999999999,
                            Quantity = 8,
                            Title = "The Darwin Award",
                            YearPublished = 2008
                        },
                        new
                        {
                            Id = 6,
                            AuthorID = 7,
                            GenreID = 1,
                            ISBN = "903200752587",
                            ImageURL = "/Images/Fantasies/harry_porter_and_the_sorcerers_stone",
                            Price = 45.899999999999999,
                            Quantity = 50,
                            Title = "Harry Porter and the Sorcerer's Stone",
                            YearPublished = 2008
                        },
                        new
                        {
                            Id = 7,
                            AuthorID = 7,
                            GenreID = 1,
                            ISBN = "024700752583",
                            ImageURL = "/Images/Fantasies/fantastic_beasts",
                            Price = 89.989999999999995,
                            Quantity = 100,
                            Title = "Fantastic Beasts",
                            YearPublished = 2001
                        },
                        new
                        {
                            Id = 8,
                            AuthorID = 3,
                            GenreID = 3,
                            ISBN = "024712752583",
                            ImageURL = "/Images/Sciences/cosmos",
                            Price = 90.0,
                            Quantity = 56,
                            Title = "Cosmos",
                            YearPublished = 1992
                        },
                        new
                        {
                            Id = 9,
                            AuthorID = 3,
                            GenreID = 3,
                            ISBN = "024712778983",
                            ImageURL = "/Images/Sciences/the_demon_haunted_world",
                            Price = 92.579999999999998,
                            Quantity = 10,
                            Title = "The Demon-Haunted World",
                            YearPublished = 1997
                        },
                        new
                        {
                            Id = 10,
                            AuthorID = 6,
                            GenreID = 6,
                            ISBN = "024712778966",
                            ImageURL = "/Images/Wealth/the_psychology_of_money",
                            Price = 92.579999999999998,
                            Quantity = 37,
                            Title = "The Psychology of Money",
                            YearPublished = 1997
                        });
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserID = 4
                        },
                        new
                        {
                            Id = 2,
                            UserID = 3
                        });
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookID");

                    b.HasIndex("CartID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Novel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Playwright"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Wealth"
                        });
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ayisha",
                            LastName = "Seidu",
                            UserName = "ayi1"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hisham",
                            LastName = "Osman",
                            UserName = "zanya"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Bilbo",
                            LastName = "Baggins",
                            UserName = "bilbag2"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Sly",
                            LastName = "Ogoe",
                            UserName = "adewele"
                        });
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.Book", b =>
                {
                    b.HasOne("OnlineBookShop.Api.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBookShop.Api.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.Cart", b =>
                {
                    b.HasOne("OnlineBookShop.Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineBookShop.Api.Models.CartItem", b =>
                {
                    b.HasOne("OnlineBookShop.Api.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBookShop.Api.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
