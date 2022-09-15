using Microsoft.EntityFrameworkCore;
using OnlineBookShop.Api.Models;

namespace OnlineBookShop.Api.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //initially add users
            modelBuilder.Entity<User>().HasData( new User
                {
                    Id = 1,
                    FirstName = "Ayisha",
                    LastName = "Seidu",
                    UserName = "ayi1"
                });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id=2,
                FirstName = "Hisham",
                LastName = "Osman",
                UserName = "zanya"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 3,
                FirstName = "Bilbo",
                LastName = "Baggins",
                UserName = "bilbag2"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id=4,
                FirstName = "Sly",
                LastName = "Ogoe",
                UserName = "adewele"
            });

            //initially add authors
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                FirstName = "Ola",
                LastName = "Rotimi",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                FirstName = "Carl",
                LastName = "Sagan",
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                FirstName = "Jane",
                LastName = "Austen",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 4,
                FirstName = "Chimamanda Ngozi",
                LastName = "Adichie",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 5,
                FirstName = "Wendy",
                LastName = "Northcutt",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 6,
                FirstName = "Morgan",
                LastName = "Housel",
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 7,
                FirstName = "J.K",
                LastName = "Rowlings",
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 1,
                Name="Novel"
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 2,
                Name = "Fantasy"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 3,
                Name = "Science"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 4,
                Name = "Playwright"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 5,
                Name = "Documentary"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 6,
                Name = "Wealth"
            });

            //adding books

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id= 1,
                Title="The Gods are not to Blame",
                AuthorID = 1,
                Price=50,
                YearPublished=1971,
                ISBN="093281758302",
                GenreID=4,
                ImageURL= "/Images/Playwrights/the_gods_are_not_to_blame.jpg",
                Quantity=17,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Our Husband has Gone Mad Again",
                AuthorID = 1,
                Price = 55.2,
                YearPublished = 1977,
                ISBN = "093200758302",
                GenreID = 4,
                ImageURL = "Images/Playwrights/our_husband_has_gone_mad_again.jpg",
                Quantity=12
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "Americana",
                AuthorID = 4,
                Price = 70,
                YearPublished = 2016,
                ISBN = "903200758302",
                GenreID = 1,
                ImageURL = "/Images/Novels/americana.jpg",
                Quantity= 7
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "Pride and Prejudice",
                AuthorID = 3,
                Price = 20,
                YearPublished = 1918,
                ISBN = "9032007583",
                GenreID = 1,
                ImageURL = "/Images/Novels/pride_and_prejudice.jpg",
                Quantity = 10
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                Title = "The Darwin Award",
                AuthorID = 5,
                Price = 45.9,
                YearPublished = 2008,
                ISBN = "903200752583",
                GenreID = 5,
                ImageURL = "/Images/Documentaries/the_darwin_award.jpg",
                Quantity = 8
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                Title = "Harry Porter and the Sorcerer's Stone",
                AuthorID = 7,
                Price = 45.9,
                YearPublished = 2008,
                ISBN = "903200752587",
                GenreID = 2,
                ImageURL = "/Images/Fantasies/harry_porter_and_the_sorcerers_stone.jpg",
                Quantity=50
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                Title = "Fantastic Beasts",
                AuthorID = 7,
                Price = 89.99,
                YearPublished = 2001,
                ISBN = "024700752583",
                GenreID = 2,
                ImageURL = "/Images/Fantasies/fantastic_beasts.jpg",
                Quantity=100
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "Cosmos",
                AuthorID = 2,
                Price = 90,
                YearPublished = 1992,
                ISBN = "024712752583",
                GenreID = 3,
                ImageURL = "/Images/Sciences/cosmos.jpg",
                Quantity=56
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "The Demon-Haunted World",
                AuthorID = 2,
                Price = 92.58,
                YearPublished = 1997,
                ISBN = "024712778983",
                GenreID = 3,
                ImageURL = "/Images/Sciences/the_demon_haunted_world.jpg",
                Quantity=10,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "The Psychology of Money",
                AuthorID = 6,
                Price = 92.58,
                YearPublished = 1997,
                ISBN = "024712778966",
                GenreID = 6,
                ImageURL = "/Images/Wealth/the_psychology_of_money.jpg",
                Quantity=37
            });

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserID=4,
            });

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserID = 3,
            });

        }

    }
}
