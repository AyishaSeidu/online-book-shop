using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookShop.Api.Migrations
{
    public partial class initialShopDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    YearPublished = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Ola", "Rotimi" },
                    { 2, "Carl", "Sagan" },
                    { 3, "Jane", "Austen" },
                    { 4, "Chimamanda Ngozi", "Adichie" },
                    { 5, "Wendy", "Northcutt" },
                    { 6, "Morgan", "Housel" },
                    { 7, "J.K", "Rowlings" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorID", "GenreID", "ISBN", "ImageURL", "Price", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, 1, 4, "093281758302", "/Images/Playwrights/the_gods_are_not_to_blame", 50.0, "The Gods are not to Blame", 1971 },
                    { 2, 1, 4, "093200758302", "/Images/Playwrights/our_husband_has_gone_mad_again", 55.200000000000003, "Our Husband has Gone Mad Again", 1977 },
                    { 3, 4, 1, "903200758302", "/Images/Novels/americana", 70.0, "Americana", 2016 },
                    { 4, 3, 1, "9032007583", "/Images/Novels/pride_and_prejudice", 20.0, "Pride and Prejudice", 1918 },
                    { 5, 5, 5, "903200752583", "/Images/Documentaries/the_darwin_award", 45.899999999999999, "The Darwin Award", 2008 },
                    { 6, 7, 1, "903200752587", "/Images/Fantasies/harry_porter_and_the_sorcerers_stone", 45.899999999999999, "Harry Porter and the Sorcerer's Stone", 2008 },
                    { 7, 7, 2, "024700752583", "/Images/Fantasies/fantastic_beasts", 89.989999999999995, "Fantastic Beasts", 2001 },
                    { 8, 3, 3, "024712752583", "/Images/Sciences/cosmos", 90.0, "Cosmos", 1992 },
                    { 9, 3, 3, "024712778983", "/Images/Sciences/the_demon_haunted_world", 92.579999999999998, "The Demon-Haunted World", 1997 },
                    { 10, 6, 6, "024712778966", "/Images/Wealth/the_psychology_of_money", 92.579999999999998, "The Psychology of Money", 1997 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Novel" },
                    { 2, "Fantasy" },
                    { 3, "Science" },
                    { 4, "Playwright" },
                    { 5, "Documentary" },
                    { 6, "Wealth" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { 1, "Ayisha", "Seidu", "ayi1" },
                    { 2, "Hisham", "Osman", "zanya" },
                    { 3, "Bilbo", "Baggins", "bilbag2" },
                    { 4, "Sly", "Ogoe", "adewele" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserID" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserID" },
                values: new object[] { 2, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
